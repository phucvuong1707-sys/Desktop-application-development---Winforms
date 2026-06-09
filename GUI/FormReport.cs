using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using ClosedXML.Excel;

namespace GUI;

public partial class FormReport : Form
{
    private readonly ReportsBUS   _reportsBus   = new ReportsBUS();
    private readonly ProductsBUS  _productsBus  = new ProductsBUS();
    private readonly CustomersBUS _customersBus = new CustomersBUS();
    private readonly SalesDetailsDAL _detailDAL = new SalesDetailsDAL();

    private readonly SaveFileDialog _saveDialog = new SaveFileDialog();

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    // ─────────────────────────────────────────────
    // LOAD CHÍNH
    // ─────────────────────────────────────────────
    private void LoadReport()
    {
        DateTime from = dtp_from.Value.Date;
        DateTime to   = dtp_to.Value.Date.AddDays(1).AddTicks(-1);

        var invoices = _reportsBus.GetInvoicesByRange(from, to);
        if (invoices.Count == 0)
        {
            UpdateCards(0, 0, 0, 0, 0);
            dgv_listInvoices.Rows.Clear();
            UpdateFooter(from, to, 0, 0);
            return;
        }

        // Load tất cả details 1 lần (tránh N+1)
        var allDetails = invoices
            .SelectMany(inv => _detailDAL.GetByInvoice(inv.InvoiceID))
            .ToList();

        // Load lookup 1 lần
        var allProducts  = _productsBus.GetAll()
            .ToDictionary(p => p.ProductID, p => p.ProductName);
        var allCustomers = _customersBus.GetAll()
            .ToDictionary(c => c.CustomerID, c => c.FullName);

        // Tính summary
        decimal revenue      = invoices.Sum(i => i.FinalAmount);
        decimal cost         = allDetails.Sum(d => d.CostPrice * d.Quantity);
        decimal profit       = revenue - cost;
        int     invoiceCount = invoices.Count;
        int     productCount = allDetails.Sum(d => d.Quantity);

        UpdateCards(revenue, profit, invoiceCount, productCount, 0);
        LoadTable(invoices, allDetails, allProducts, allCustomers);

        decimal profitRate = revenue > 0 ? Math.Round(profit / revenue * 100, 1) : 0;
        UpdateFooter(from, to, revenue, profitRate);
    }

    // ─────────────────────────────────────────────
    // CẬP NHẬT CARDS — dùng đúng tên Designer
    // ─────────────────────────────────────────────
    private void UpdateCards(decimal revenue, decimal profit,
                             int invoiceCount, int productCount, int warrantyCount)
    {
        lbl_outCome.Text     = $"{revenue:N0} đ\nDoanh thu";
        lbl_grossProfit.Text = $"{profit:N0} đ\nLợi nhuận gộp";
        lbl_invoiceNum.Text  = $"{invoiceCount}\nHóa đơn đã xuất";
        lbl_productSold.Text = $"{productCount}\nSản phẩm bán ra";
        lbl_warranty.Text    = $"{warrantyCount}\nBảo hành phát sinh";
    }

    // ─────────────────────────────────────────────
    // LOAD BẢNG — dùng đúng tên Designer
    // ─────────────────────────────────────────────
    private void LoadTable(
        List<SalesInvoicesDTO>  invoices,
        List<SalesDetailsDTO>   allDetails,
        Dictionary<int, string> allProducts,
        Dictionary<int, string> allCustomers)
    {
        dgv_listInvoices.Rows.Clear();
        dgv_listInvoices.RowHeadersVisible  = false;
        dgv_listInvoices.AllowUserToAddRows = false;
        dgv_listInvoices.ReadOnly           = true;
        dgv_listInvoices.SelectionMode      = DataGridViewSelectionMode.FullRowSelect;

        var detailsByInvoice = allDetails
            .GroupBy(d => d.InvoiceID)
            .ToDictionary(g => g.Key, g => g.ToList());

        foreach (var inv in invoices)
        {
            var details = detailsByInvoice.ContainsKey(inv.InvoiceID)
                ? detailsByInvoice[inv.InvoiceID]
                : new List<SalesDetailsDTO>();

            string customerName = inv.CustomerID.HasValue && allCustomers.ContainsKey(inv.CustomerID.Value)
                ? allCustomers[inv.CustomerID.Value]
                : "Khách lẻ";

            string productSummary = string.Join(", ", details
                .Select(d => allProducts.ContainsKey(d.ProductID) ? allProducts[d.ProductID] : "SP")
                .Distinct());

            decimal totalCost   = details.Sum(d => d.CostPrice * d.Quantity);
            decimal rowProfit   = inv.FinalAmount - totalCost;

            int i = dgv_listInvoices.Rows.Add(
                inv.InvoiceCode,
                inv.SaleDate.ToString("dd/MM/yyyy HH:mm"),
                customerName,
                productSummary,
                $"{inv.FinalAmount:N0}",
                $"{rowProfit:N0}",
                inv.PaymentMethod
            );

            var payCell = dgv_listInvoices.Rows[i].Cells["col_thanhToan"];
            if (inv.PaymentMethod == "Tiền mặt")
            { payCell.Style.BackColor = Color.FromArgb(0, 140, 0);   payCell.Style.ForeColor = Color.White; }
            else
            { payCell.Style.BackColor = Color.FromArgb(0, 102, 204); payCell.Style.ForeColor = Color.White; }
        }
    }

    // ─────────────────────────────────────────────
    // FOOTER
    // ─────────────────────────────────────────────
    private void UpdateFooter(DateTime from, DateTime to, decimal revenue, decimal profitRate)
    {
        lbl_footerLeft.Text  = $"Báo cáo từ: {from:dd/MM/yyyy} đến {to:dd/MM/yyyy}";
        lbl_footerRight.Text = revenue > 0 ? $"Tỉ lệ lợi nhuận: {profitRate}%" : "Tỉ lệ lợi nhuận: —";
    }

    // ─────────────────────────────────────────────
    // EVENTS
    // ─────────────────────────────────────────────
    private void btn_xemBaocao_Click(object sender, EventArgs e) => LoadReport();

    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        if (dgv_listInvoices.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        _saveDialog.Filter   = "Excel Files|*.xlsx";
        _saveDialog.Title    = "Lưu báo cáo doanh thu";
        _saveDialog.FileName = $"BaoCaoDoanhThu_{DateTime.Now:ddMMyyyy}.xlsx";

        if (_saveDialog.ShowDialog() != DialogResult.OK) return;

        try
        {
            using var wb = new XLWorkbook();
            var ws = wb.Worksheets.Add("DoanhThu");

            for (int i = 0; i < dgv_listInvoices.Columns.Count; i++)
            {
                var cell = ws.Cell(1, i + 1);
                cell.Value = dgv_listInvoices.Columns[i].HeaderText;
                cell.Style.Font.Bold = true;
                cell.Style.Fill.BackgroundColor = XLColor.LightGray;
                cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
            }

            int rowIdx = 2;
            foreach (DataGridViewRow row in dgv_listInvoices.Rows)
            {
                if (row.IsNewRow) continue;
                for (int j = 0; j < dgv_listInvoices.Columns.Count; j++)
                {
                    var cell = ws.Cell(rowIdx, j + 1);
                    var val  = row.Cells[j].Value?.ToString() ?? "";
                    cell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                    string colName = dgv_listInvoices.Columns[j].Name.ToLower();
                    if ((colName.Contains("tien") || colName.Contains("doanh") || colName.Contains("loi"))
                        && decimal.TryParse(val.Replace(",", ""), out decimal num))
                    {
                        cell.Value = num;
                        cell.Style.NumberFormat.Format = "#,##0\" đ\"";
                    }
                    else
                    {
                        cell.Value = val;
                    }
                }
                rowIdx++;
            }

            ws.Columns().AdjustToContents();
            wb.SaveAs(_saveDialog.FileName);
            MessageBox.Show("Xuất Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi xuất Excel:\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }
    private void FormReport_Load(object sender, EventArgs e) { }
}