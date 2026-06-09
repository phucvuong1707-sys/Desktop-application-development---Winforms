using System;
using System.Drawing;
using System.Windows.Forms;
using ClosedXML.Excel; // Đưa thư viện Excel vào sử dụng

namespace GUI;

public partial class FormReport : Form
{
    // Khởi tạo hộp thoại lưu file bằng code (Không cần kéo thả Toolbox)
    private readonly SaveFileDialog saveDialog_Excel = new SaveFileDialog();

    public FormReport()
    {
        InitializeComponent();
        LoadReport();
    }

    private void LoadReport()
    {
        UpdateCards();
        LoadTable();
        UpdateFooter();
    }

    private void UpdateCards()
    {
        // Kiểm tra an toàn trước khi gán dữ liệu để tránh lỗi gạch đỏ từ Designer
        if (lbl_doanhThu != null) lbl_doanhThu.Text = "\nDoanh thu (đ)";
        if (lbl_grossProfit != null) lbl_grossProfit.Text = "\nLợi nhuận gộp (đ)";
        if (lbl_invoiceNum != null) lbl_invoiceNum.Text = "\nHóa đơn đã xuất";
    }

    private void LoadTable()
    {
        // ĐÃ BỎ FAKE DATA: Hàm này giờ chỉ làm nhiệm vụ tự động đổi màu sắc định dạng 
        // dựa trên dữ liệu THỰC TẾ đang hiển thị sẵn trong bảng dgv_listInvoices
        if (dgv_listInvoices == null || dgv_listInvoices.Rows.Count == 0) return;

        for (int i = 0; i < dgv_listInvoices.Rows.Count; i++)
        {
            var row = dgv_listInvoices.Rows[i];
            if (row.IsNewRow) continue;

            // Kiểm tra xem cột 'col_thanhToan' có tồn tại trong bảng không
            if (dgv_listInvoices.Columns.Contains("col_thanhToan"))
            {
                var payCell = row.Cells["col_thanhToan"];
                string paymentMethod = payCell.Value?.ToString() ?? "";

                // Đổi màu nền theo phương thức thanh toán thực tế
                if (paymentMethod == "Tiền mặt")
                { 
                    payCell.Style.BackColor = Color.FromArgb(0, 140, 0);   
                    payCell.Style.ForeColor = Color.White; 
                }
                else if (!string.IsNullOrEmpty(paymentMethod))
                { 
                    payCell.Style.BackColor = Color.FromArgb(0, 102, 204); 
                    payCell.Style.ForeColor = Color.White; 
                }
            }
        }
    }

    private void UpdateFooter()
    {
        // Nếu form của bạn không có lbl_footerLeft hoặc lbl_footerRight, phần này sẽ tự bỏ qua không báo lỗi đỏ
    }

    private void btn_xemBaocao_Click(object sender, EventArgs e)
    {
        LoadReport();
    }

    // --- LOGIC XUẤT EXCEL CHÍNH THỨC (ĐÃ BỔ SUNG ĐỊNH DẠNG SỐ & KẺ BẢNG) ---
    private void btn_xuatExcel_Click(object sender, EventArgs e)
    {
        if (dgv_listInvoices == null || dgv_listInvoices.Rows.Count == 0)
        {
            MessageBox.Show("Không có dữ liệu báo cáo để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // Cấu hình hộp thoại lưu file
        saveDialog_Excel.Filter = "Excel Files|*.xlsx";
        saveDialog_Excel.Title = "Lưu báo cáo doanh thu";
        saveDialog_Excel.FileName = $"BaoCaoDoanhThu_{DateTime.Now:ddMMyyyy}.xlsx";

        if (saveDialog_Excel.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using (XLWorkbook workbook = new XLWorkbook())
                {
                    var worksheet = workbook.Worksheets.Add("DoanhThu");

                    // 1. Tạo Tiêu đề cột từ DataGridView thực tế
                    for (int i = 0; i < dgv_listInvoices.Columns.Count; i++)
                    {
                        var headerCell = worksheet.Cell(1, i + 1);
                        headerCell.Value = dgv_listInvoices.Columns[i].HeaderText;
                        headerCell.Style.Font.Bold = true;
                        headerCell.Style.Fill.BackgroundColor = XLColor.LightGray;
                        headerCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin; // Kẻ khung tiêu đề
                        headerCell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center; // Căn giữa tiêu đề
                    }

                    // 2. Đổ dữ liệu THỰC TẾ từ các hàng của DataGridView vào Excel
                    int excelRowIndex = 2;
                    for (int i = 0; i < dgv_listInvoices.Rows.Count; i++)
                    {
                        var row = dgv_listInvoices.Rows[i];
                        if (row.IsNewRow) continue;

                        for (int j = 0; j < dgv_listInvoices.Columns.Count; j++)
                        {
                            var cellValue = row.Cells[j].Value?.ToString() ?? "";
                            var excelCell = worksheet.Cell(excelRowIndex, j + 1);
                            
                            // Kẻ khung mỏng cho từng ô dữ liệu
                            excelCell.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;

                            // Lấy tên Header để nhận diện cột tiền
                            string headerText = dgv_listInvoices.Columns[j].HeaderText.ToLower();
                            string columnName = dgv_listInvoices.Columns[j].Name.ToLower();

                            // Tự động ép kiểu Số nếu cột có chữ "tiền", "giá", "tổng" để Excel dùng được hàm SUM()
                            if (headerText.Contains("tiền") || headerText.Contains("giá") || columnName.Contains("tien"))
                            {
                                if (decimal.TryParse(cellValue, out decimal moneyValue))
                                {
                                    excelCell.Value = moneyValue;
                                    excelCell.Style.NumberFormat.Format = "#,##0\" đ\""; // Thêm dấu phẩy hàng nghìn
                                }
                                else
                                {
                                    excelCell.Value = cellValue; // Nếu không phải số (bị lỗi chữ) thì in bình thường
                                }
                            }
                            else
                            {
                                excelCell.Value = cellValue;
                            }
                        }
                        excelRowIndex++;
                    }

                    // Căn chỉnh độ rộng tự động cho các cột Excel đẹp mắt
                    worksheet.Columns().AdjustToContents();

                    // 3. Lưu file thực tế vào máy tính
                    workbook.SaveAs(saveDialog_Excel.FileName);
                    
                    MessageBox.Show("Xuất báo cáo Excel thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xuất Excel (Đảm bảo file không bị mở ở ứng dụng khác):\n" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

    private void label1_Click(object sender, EventArgs e) { }
    private void pnl_Top_Paint(object sender, PaintEventArgs e) { }
}