using System;
using System.Windows.Forms;

namespace GUI;

public partial class FormSell : Form
{
    public FormSell()
    {
        InitializeComponent();
        cbo_paymentMethod.SelectedIndex = 0;
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

    // ── Xác nhận thanh toán ──────────────────────────────────────────────────
    private void btn_ConfirmPayment_Click(object sender, EventArgs e)
    {
        string paymentMethod = cbo_paymentMethod.Text;
        MessageBox.Show(
            $"Thanh toán thành công!\nPhương thức: {paymentMethod}",
            "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

        // TODO: gọi SalesBUS.Checkout() rồi reset form
        ResetForm();
    }

    // ── In hóa đơn ───────────────────────────────────────────────────────────
    private void btn_Print_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Đang in hóa đơn...", "In hóa đơn",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        // TODO: gọi PrintDocument
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
        // TODO: mở form danh sách hóa đơn
    }

    // ── Khách hàng ───────────────────────────────────────────────────────────
    private void btn_Customer_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Mở danh sách khách hàng.",
            "Khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Information);
        // TODO: mở FormGuest để chọn khách
    }

    // ── Mã khuyến mãi ────────────────────────────────────────────────────────
    private void btn_Promotion_Click(object sender, EventArgs e)
    {
        string promoCode = Microsoft.VisualBasic.Interaction.InputBox(
            "Nhập mã khuyến mãi:", "Khuyến mãi", "");

        if (!string.IsNullOrEmpty(promoCode))
        {
            // TODO: gọi PromotionsBUS.ApplyPromoCode()
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