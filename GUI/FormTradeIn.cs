using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BUS;
using DTO;

namespace Desktop_Application_Development;

public partial class FormTradeIn : Form
{
    // Khởi tạo các đối tượng nghiệp vụ
    private readonly SalesBUS _salesBUS = new SalesBUS();
    private readonly CustomersBUS _customerBUS = new CustomersBUS();

    private int _currentInvoiceID = 0;
    private int _currentCustomerID = 0;

    public FormTradeIn()
    {
        InitializeComponent();
    }

    private void FormTradeIn_Load(object sender, EventArgs e)
    {
        SetupDataGridView();
        txb_reason.Items.Clear();
        txb_reason.Items.AddRange(new string[] { "Sản phẩm lỗi do NSX", "Thu cũ đổi mới", "Khách đổi ý (Có tính phí)", "Khác..." });
        txb_reason.SelectedIndex = 0;
        SetTradeInPanelState(false);
    }

    private void SetupDataGridView()
    {
        dgv_invoiceDetails.Columns.Clear();
        dgv_invoiceDetails.AutoGenerateColumns = false;
        dgv_invoiceDetails.AllowUserToAddRows = false;
        dgv_invoiceDetails.RowHeadersVisible = false;
        dgv_invoiceDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        dgv_invoiceDetails.Columns.Add(new DataGridViewCheckBoxColumn { HeaderText = "Chọn", Name = "chkSelect", Width = 50 });
        dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemCode", HeaderText = "Mã Serial", Name = "ItemCode", Width = 120, ReadOnly = true });
        dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ProductName", HeaderText = "Tên Sản Phẩm", Name = "ProductName", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill, ReadOnly = true });
        dgv_invoiceDetails.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Giá Bán", Name = "UnitPrice", Width = 100, ReadOnly = true });
    }

    private void SetTradeInPanelState(bool isEnabled)
    {
        txb_reason.Enabled = isEnabled;
        rtb_tradeInNote.Enabled = isEnabled;
        txt_refundAmount.Enabled = isEnabled;
        btn_confirmTradeIn.Enabled = isEnabled;
        btn_createTradeIn.Enabled = isEnabled;
    }

    // --- LOGIC GỌI DATABASE THẬT ---
    private void btnSearch_Click(object sender, EventArgs e)
    {
        string invoiceCode = txt_invoiceCode.Text.Trim();
        if (string.IsNullOrEmpty(invoiceCode))
        {
            MessageBox.Show("Vui lòng nhập Mã Hóa Đơn!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        try
        {
            // Thay tên hàm tương ứng với hàm thật trong SalesBUS của bạn
            var invoice = _salesBUS.GetByInvoiceCode(invoiceCode); 

            if (invoice != null)
            {
                _currentInvoiceID = invoice.InvoiceID;
                _currentCustomerID = invoice.CustomerID ?? 0;
                
                var customer = _customerBUS.GetById(_currentCustomerID);
                txt_customerName.Text = customer != null ? customer.FullName : "Khách lẻ";
                txt_phone.Text = customer != null ? customer.Phone : "Không có";
                
                dgv_invoiceDetails.DataSource = _salesBUS.GetInvoiceDetails(_currentInvoiceID);
                SetTradeInPanelState(true);
            }
            else
            {
                MessageBox.Show("Không tìm thấy Hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCancel_Click(null, null);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Lỗi truy vấn Database: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnConfirm_Click(object sender, EventArgs e)
    {
        // 1. Kiểm tra CheckBox
        List<string> selectedSerials = new List<string>();
        foreach (DataGridViewRow row in dgv_invoiceDetails.Rows)
        {
            if (Convert.ToBoolean(row.Cells["chkSelect"].Value))
                selectedSerials.Add(row.Cells["ItemCode"].Value.ToString());
        }

        if (selectedSerials.Count == 0)
        {
            MessageBox.Show("Vui lòng chọn sản phẩm!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        // 2. Validate dữ liệu tiền tệ
        if (!decimal.TryParse(txt_refundAmount.Text.Replace(",", ""), out decimal refundAmount) || refundAmount < 0)
        {
            MessageBox.Show("Số tiền không hợp lệ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        // 3. Thực thi lưu trữ
        if (MessageBox.Show("Xác nhận đổi trả?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
        {
            // TODO: Gọi hàm Insert/Process của TradeInBUS tại đây
            MessageBox.Show("Đã lưu đổi trả thành công!", "Thành công");
            btnCancel_Click(null, null);
        }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
        txt_invoiceCode.Clear();
        txt_customerName.Clear();
        txt_phone.Clear();
        rtb_tradeInNote.Clear();
        txt_refundAmount.Clear();
        dgv_invoiceDetails.DataSource = null;
        SetTradeInPanelState(false);
    }

    private void btnCreateTradeIn_Click(object sender, EventArgs e) { /* Code xử lý tạo phiếu mới */ }
    private void label2_Click(object sender, EventArgs e) { }
}