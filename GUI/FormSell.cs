using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GUI;

public partial class FormSell : Form
{
    // Khởi tạo các công cụ in ấn bằng code (Không cần kéo thả Toolbox)
    private readonly PrintDocument printDocument = new PrintDocument();
    private readonly PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();

    public FormSell()
    {
        InitializeComponent();
        cbo_paymentMethod.SelectedIndex = 0;

        // Gắn sự kiện vẽ hóa đơn cho PrintDocument
        printDocument.PrintPage += PrintDocument_PrintPage;
    }

    // ── Thanh toán ───────────────────────────────────────────────────────────
    private void btn_Payment_Click(object sender, EventArgs e)
    {
        if (dgv_cart.Rows.Count == 0)
        {
            MessageBox.Show("Giỏ hàng đang trống!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }
        // Hiện panel thanh toán (groupBox4 đã có sẵn)
        groupBox4.Visible = true;
    }

    // ── Xác nhận thanh toán (ĐÃ SỬA LOGIC QUY TRÌNH IN ẤN) ───────────────────
    private void btn_ConfirmPayment_Click(object sender, EventArgs e)
    {
        string paymentMethod = cbo_paymentMethod.Text;
        MessageBox.Show(
            $"Thanh toán thành công!\nPhương thức: {paymentMethod}",
            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // TODO: gọi SalesBUS.Checkout() ở đây trước khi xóa dữ liệu

        // QUY TRÌNH CHUẨN: Hỏi in hóa đơn TRƯỚC KHI reset form dữ liệu
        var printResult = MessageBox.Show("Bạn có muốn in hóa đơn cho khách hàng không?", "In hóa đơn",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        if (printResult == DialogResult.Yes)
        {
            ExecutePrint(); // Gọi hàm mở màn hình in hóa đơn
        }

        // Sau khi xử lý in ấn xong mới reset toàn bộ form về trống
        ResetForm();
    }

    // ── Nút bấm in hóa đơn độc lập (Dùng khi muốn in lại hóa đơn chưa reset) ──
    private void btn_Print_Click(object sender, EventArgs e)
    {
        if (dgv_cart.Rows.Count == 0)
        {
            MessageBox.Show("Giỏ hàng trống, không có gì để in!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        ExecutePrint();
    }

    // Tách hàm kích hoạt lệnh in ra riêng để tái sử dụng
    private void ExecutePrint()
    {
        printPreviewDialog.Document = printDocument;
        printPreviewDialog.ShowDialog();
    }

    // ── HÀM VẼ (THIẾT KẾ) BỐ CỤC HÓA ĐƠN ────────────────────────────────────
    private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
    {
        Graphics graphics = e.Graphics;
        
        // Khởi tạo các font chữ
        Font fontTitle = new Font("Courier New", 18, FontStyle.Bold);
        Font fontHeader = new Font("Courier New", 14, FontStyle.Bold);
        Font fontRegular = new Font("Courier New", 12);
        Font fontItalic = new Font("Courier New", 12, FontStyle.Italic);

        float fontHeight = fontRegular.GetHeight();
        int startX = 10;
        int startY = 10;
        int offset = 40;

        // 1. Header (Tên cửa hàng, Ngày giờ)
        graphics.DrawString("CỬA HÀNG CỦA BẢO", fontTitle, new SolidBrush(Color.Black), startX + 50, startY);
        offset += (int)fontTitle.GetHeight() + 10;
        
        graphics.DrawString("HÓA ĐƠN THANH TOÁN", fontHeader, new SolidBrush(Color.Black), startX + 50, startY + offset);
        offset += (int)fontHeader.GetHeight() + 10;

        graphics.DrawString($"Ngày in: {DateTime.Now:dd/MM/yyyy HH:mm}", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 15;

        graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 10;

        // Tiêu đề cột của hóa đơn giấy
        graphics.DrawString("Tên món", fontRegular, Brushes.Black, startX, startY + offset);
        graphics.DrawString("SL", fontRegular, Brushes.Black, startX + 180, startY + offset);
        graphics.DrawString("Thành tiền", fontRegular, Brushes.Black, startX + 230, startY + offset);
        offset += (int)fontHeight + 10;
        graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 10;

        // 2. Lặp qua DataGridView giỏ hàng thực tế (dgv_cart)
        foreach (DataGridViewRow row in dgv_cart.Rows)
        {
            if (row.IsNewRow) continue;

            // Mẹo: Nhớ kiểm tra trỏ đúng tên cột trên Grid của bạn (col_ProductName, col_Quantity, col_TotalPrice)
            string name = row.Cells["col_ProductName"]?.Value?.ToString() ?? "Sản phẩm";
            string qty = row.Cells["col_Quantity"]?.Value?.ToString() ?? "1";
            string totalStr = row.Cells["col_TotalPrice"]?.Value?.ToString() ?? "0";

            // Tự động cắt ngắn tên nếu tên sản phẩm quá dài tránh đè chữ
            if (name.Length > 15) name = name.Substring(0, 15) + "...";

            // Định dạng lại tiền tệ có dấu phẩy hàng nghìn cho đẹp
            if (decimal.TryParse(totalStr, out decimal totalValue))
                totalStr = totalValue.ToString("N0");

            graphics.DrawString(name, fontRegular, Brushes.Black, startX, startY + offset);
            graphics.DrawString(qty, fontRegular, Brushes.Black, startX + 180, startY + offset);
            graphics.DrawString(totalStr, fontRegular, Brushes.Black, startX + 230, startY + offset);
            
            offset += (int)fontHeight + 5;
        }

        graphics.DrawString("---------------------------------------", fontRegular, new SolidBrush(Color.Black), startX, startY + offset);
        offset += (int)fontHeight + 10;

        // 3. Tổng tiền (Bê nguyên nội dung Text từ các nhãn hiển thị trên Form)
        graphics.DrawString(lbl_subTotal.Text, fontRegular, Brushes.Black, startX, startY + offset);
        offset += (int)fontHeight + 5;
        
        graphics.DrawString(lbl_discount.Text, fontRegular, Brushes.Black, startX, startY + offset);
        offset += (int)fontHeight + 15;

        graphics.DrawString(lbl_finalTotal.Text, fontTitle, Brushes.Black, startX, startY + offset);
        offset += (int)fontTitle.GetHeight() + 30;

        // 4. Footer hóa đơn giấy
        graphics.DrawString("CẢM ƠN QUÝ KHÁCH VÀ HẸN GẶP LẠI!", fontItalic, Brushes.Black, startX + 10, startY + offset);
    }

    // ── Hủy hóa đơn ─────────────────────────────────────────────────────────
    private void btn_CancelInvoice_Click(object sender, EventArgs e)
    {
        if (dgv_cart.Rows.Count == 0) return;

        var result = MessageBox.Show("Bạn có chắc muốn hủy hóa đơn?", "Xác nhận",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (result == DialogResult.Yes)
            ResetForm();
    }

    // ── Hóa đơn hôm nay ─────────────────────────────────────────────────────
    private void btnTodayInvoice_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Hiển thị danh sách hóa đơn hôm nay.",
            "Hóa đơn hôm nay", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ── Khách hàng ───────────────────────────────────────────────────────────
    private void btn_Customer_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Mở danh sách khách hàng.",
            "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    // ── Mã khuyến mãi ────────────────────────────────────────────────────────
    private void btn_Promotion_Click(object sender, EventArgs e)
    {
        string promoCode = Microsoft.VisualBasic.Interaction.InputBox(
            "Nhập mã khuyến mãi:", "Khuyến mãi", "");

        if (!string.IsNullOrEmpty(promoCode))
        {
            MessageBox.Show($"Đã áp dụng mã: {promoCode}", "Khuyến mãi");
            lbl_discount.Text = $"Giảm giá: -{promoCode}";
        }
    }

    // ── Click ô xóa trong DataGridView ───────────────────────────────────────
    private void dgv_Cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgv_cart.Columns[e.ColumnIndex].Name == "col_Remove")
        {
            dgv_cart.Rows.RemoveAt(e.RowIndex);
            RecalcTotal();
        }
    }

    // ── Tính lại tổng tiền ───────────────────────────────────────────────────
    private void RecalcTotal()
    {
        decimal subtotal = 0;
        foreach (DataGridViewRow row in dgv_cart.Rows)
        {
            if (decimal.TryParse(row.Cells["col_TotalPrice"].Value?.ToString(), out decimal val))
                subtotal += val;
        }
        lbl_subTotal.Text   = $"Tạm tính:    {subtotal:N0} đ";
        lbl_discount.Text   = "Giảm giá:    - 0 đ";
        lbl_finalTotal.Text = $"Tổng cộng:  {subtotal:N0} đ";
    }

    // ── Reset form sau khi thanh toán / hủy ─────────────────────────────────
    private void ResetForm()
    {
        dgv_cart.Rows.Clear();
        lbl_subTotal.Text   = "Tạm tính:    0 đ";
        lbl_discount.Text   = "Giảm giá:    - 0 đ";
        lbl_finalTotal.Text = "Tổng cộng:  0 đ";
        cbo_paymentMethod.SelectedIndex = 0;
    }

    private void grp_Action_Enter(object sender, EventArgs e) { }
}