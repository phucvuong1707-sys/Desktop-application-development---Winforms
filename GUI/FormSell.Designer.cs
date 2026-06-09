using System.ComponentModel;

namespace GUI;

partial class FormSell
{
    private IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        pnl_top = new System.Windows.Forms.Panel();
        btn_add = new System.Windows.Forms.Button();
        btn_edit = new System.Windows.Forms.Button();
        btn_delete = new System.Windows.Forms.Button();
        btn_refresh = new System.Windows.Forms.Button();
        
        pnl_search = new System.Windows.Forms.Panel();
        txt_searchProduct = new System.Windows.Forms.TextBox();
        
        dgv_cart = new System.Windows.Forms.DataGridView();
        col_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_serielNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
        
        pnl_details = new System.Windows.Forms.Panel();
        grp_payment = new System.Windows.Forms.GroupBox();
        lbl_subTotal = new System.Windows.Forms.Label();
        lbl_discount = new System.Windows.Forms.Label();
        lbl_finalTotal = new System.Windows.Forms.Label();
        
        grp_paymentMethod = new System.Windows.Forms.GroupBox();
        cbo_paymentMethod = new System.Windows.Forms.ComboBox();
        btn_confirmPayment = new System.Windows.Forms.Button();
        
        pnl_bottom = new System.Windows.Forms.Panel();
        btn_save = new System.Windows.Forms.Button();
        btn_cancel = new System.Windows.Forms.Button();
        
        ((System.ComponentModel.ISupportInitialize)dgv_cart).BeginInit();
        pnl_top.SuspendLayout();
        pnl_search.SuspendLayout();
        pnl_details.SuspendLayout();
        grp_payment.SuspendLayout();
        grp_paymentMethod.SuspendLayout();
        pnl_bottom.SuspendLayout();
        SuspendLayout();
        
        // ──── TOP PANEL (Header) ────
        pnl_top.Controls.Add(btn_add);
        pnl_top.Controls.Add(btn_edit);
        pnl_top.Controls.Add(btn_delete);
        pnl_top.Controls.Add(btn_refresh);
        pnl_top.Dock = System.Windows.Forms.DockStyle.Top;
        pnl_top.Location = new System.Drawing.Point(0, 0);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new System.Drawing.Size(1587, 102);
        pnl_top.TabIndex = 0;
        
        // Button Add (Khách Hàng)
        btn_add.Location = new System.Drawing.Point(12, 12);
        btn_add.Name = "btn_add";
        btn_add.Size = new System.Drawing.Size(375, 63);
        btn_add.TabIndex = 0;
        btn_add.Text = "Khách Hàng";
        btn_add.UseVisualStyleBackColor = true;
        btn_add.Click += btn_Customer_Click;
        
        // Button Edit (Khuyến Mãi)
        btn_edit.Location = new System.Drawing.Point(393, 12);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new System.Drawing.Size(402, 63);
        btn_edit.TabIndex = 1;
        btn_edit.Text = "Khuyến Mãi";
        btn_edit.UseVisualStyleBackColor = true;
        btn_edit.Click += btn_Promotion_Click;
        
        // Button Delete (Hủy Hóa Đơn)
        btn_delete.Location = new System.Drawing.Point(801, 12);
        btn_delete.Name = "btn_delete";
        btn_delete.Size = new System.Drawing.Size(421, 63);
        btn_delete.TabIndex = 2;
        btn_delete.Text = "Hủy Hóa Đơn";
        btn_delete.UseVisualStyleBackColor = true;
        btn_delete.Click += btn_CancelInvoice_Click;
        
        // Button Refresh (Hóa Đơn Hôm Nay)
        btn_refresh.Location = new System.Drawing.Point(1228, 12);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new System.Drawing.Size(347, 63);
        btn_refresh.TabIndex = 3;
        btn_refresh.Text = "Hóa Đơn Hôm Nay";
        btn_refresh.UseVisualStyleBackColor = true;
        btn_refresh.Click += btnTodayInvoice_Click;
        
        // ──── SEARCH PANEL ────
        pnl_search.Controls.Add(txt_searchProduct);
        pnl_search.Dock = System.Windows.Forms.DockStyle.Top;
        pnl_search.Location = new System.Drawing.Point(0, 102);
        pnl_search.Name = "pnl_search";
        pnl_search.Size = new System.Drawing.Size(1587, 70);
        pnl_search.TabIndex = 4;
        
        // TextBox Search
        txt_searchProduct.Dock = System.Windows.Forms.DockStyle.Fill;
        txt_searchProduct.Font = new System.Drawing.Font("Segoe UI", 14F);
        txt_searchProduct.Location = new System.Drawing.Point(12, 12);
        txt_searchProduct.Margin = new System.Windows.Forms.Padding(12);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.PlaceholderText = "Quét mã SP / Serial... (Nhấn Enter để thêm)";
        txt_searchProduct.Size = new System.Drawing.Size(1563, 46);
        txt_searchProduct.TabIndex = 0;
        
        // ──── DATAGRIDVIEW (Cart) ────
        dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        dgv_cart.ColumnHeadersHeight = 58;
        dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { 
            col_productName, col_serielNumber, col_quantity, col_unitPrice, col_totalPrice, col_remove });
        dgv_cart.Dock = System.Windows.Forms.DockStyle.Left;
        dgv_cart.Location = new System.Drawing.Point(0, 172);
        dgv_cart.Name = "dgv_cart";
        dgv_cart.RowHeadersWidth = 102;
        dgv_cart.Size = new System.Drawing.Size(640, 658);
        dgv_cart.TabIndex = 1;
        dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        
        col_productName.HeaderText = "Tên SP";
        col_productName.Name = "col_productName";
        col_productName.Width = 180;
        
        col_serielNumber.HeaderText = "Serial";
        col_serielNumber.Name = "col_serielNumber";
        col_serielNumber.Width = 150;
        
        col_quantity.HeaderText = "SL";
        col_quantity.Name = "col_quantity";
        col_quantity.Width = 80;
        
        col_unitPrice.HeaderText = "Đơn giá";
        col_unitPrice.Name = "col_unitPrice";
        col_unitPrice.Width = 120;
        
        col_totalPrice.HeaderText = "Thành tiền";
        col_totalPrice.Name = "col_totalPrice";
        col_totalPrice.Width = 120;
        
        col_remove.HeaderText = "Xóa";
        col_remove.Name = "col_remove";
        col_remove.Width = 70;
        
        // ──── RIGHT PANEL (Details) ────
        pnl_details.Controls.Add(grp_paymentMethod);
        pnl_details.Controls.Add(grp_payment);
        pnl_details.Dock = System.Windows.Forms.DockStyle.Fill;
        pnl_details.Location = new System.Drawing.Point(640, 172);
        pnl_details.Name = "pnl_details";
        pnl_details.Size = new System.Drawing.Size(947, 658);
        pnl_details.TabIndex = 2;
        
        // ──── Payment GroupBox ────
        grp_payment.Controls.Add(lbl_subTotal);
        grp_payment.Controls.Add(lbl_discount);
        grp_payment.Controls.Add(lbl_finalTotal);
        grp_payment.Location = new System.Drawing.Point(6, 6);
        grp_payment.Name = "grp_payment";
        grp_payment.Size = new System.Drawing.Size(929, 280);
        grp_payment.TabIndex = 0;
        grp_payment.TabStop = false;
        grp_payment.Text = "Thanh Toán";
        
        lbl_subTotal.AutoSize = true;
        lbl_subTotal.Location = new System.Drawing.Point(12, 35);
        lbl_subTotal.Name = "lbl_subTotal";
        lbl_subTotal.Size = new System.Drawing.Size(200, 41);
        lbl_subTotal.TabIndex = 0;
        lbl_subTotal.Text = "Tạm tính:    0 đ";
        
        lbl_discount.AutoSize = true;
        lbl_discount.ForeColor = System.Drawing.Color.OrangeRed;
        lbl_discount.Location = new System.Drawing.Point(12, 110);
        lbl_discount.Name = "lbl_discount";
        lbl_discount.Size = new System.Drawing.Size(200, 41);
        lbl_discount.TabIndex = 1;
        lbl_discount.Text = "Giảm giá:    - 0 đ";
        
        lbl_finalTotal.AutoSize = true;
        lbl_finalTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
        lbl_finalTotal.ForeColor = System.Drawing.Color.DarkGreen;
        lbl_finalTotal.Location = new System.Drawing.Point(12, 190);
        lbl_finalTotal.Name = "lbl_finalTotal";
        lbl_finalTotal.Size = new System.Drawing.Size(300, 54);
        lbl_finalTotal.TabIndex = 2;
        lbl_finalTotal.Text = "Tổng cộng:  0 đ";
        
        // ──── Payment Method GroupBox ────
        grp_paymentMethod.Controls.Add(cbo_paymentMethod);
        grp_paymentMethod.Controls.Add(btn_confirmPayment);
        grp_paymentMethod.Location = new System.Drawing.Point(6, 292);
        grp_paymentMethod.Name = "grp_paymentMethod";
        grp_paymentMethod.Size = new System.Drawing.Size(929, 200);
        grp_paymentMethod.TabIndex = 1;
        grp_paymentMethod.TabStop = false;
        grp_paymentMethod.Text = "Phương Thức Thanh Toán";
        grp_paymentMethod.Visible = false;
        
        cbo_paymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
        cbo_paymentMethod.FormattingEnabled = true;
        cbo_paymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "MoMo", "ZaloPay", "Thẻ tín dụng" });
        cbo_paymentMethod.Location = new System.Drawing.Point(12, 40);
        cbo_paymentMethod.Name = "cbo_paymentMethod";
        cbo_paymentMethod.Size = new System.Drawing.Size(905, 49);
        cbo_paymentMethod.TabIndex = 0;
        cbo_paymentMethod.SelectedIndex = 0;
        
        btn_confirmPayment.Location = new System.Drawing.Point(12, 95);
        btn_confirmPayment.Name = "btn_confirmPayment";
        btn_confirmPayment.Size = new System.Drawing.Size(905, 64);
        btn_confirmPayment.TabIndex = 1;
        btn_confirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_confirmPayment.UseVisualStyleBackColor = true;
        btn_confirmPayment.Click += btn_ConfirmPayment_Click;
        
        // ──── BOTTOM PANEL (Action) ────
        pnl_bottom.Controls.Add(btn_save);
        pnl_bottom.Controls.Add(btn_cancel);
        pnl_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
        pnl_bottom.Location = new System.Drawing.Point(0, 830);
        pnl_bottom.Name = "pnl_bottom";
        pnl_bottom.Size = new System.Drawing.Size(1587, 120);
        pnl_bottom.TabIndex = 3;
        
        btn_save.Location = new System.Drawing.Point(12, 28);
        btn_save.Name = "btn_save";
        btn_save.Size = new System.Drawing.Size(766, 64);
        btn_save.TabIndex = 0;
        btn_save.Text = "In Hóa Đơn";
        btn_save.UseVisualStyleBackColor = true;
        btn_save.Click += btn_Print_Click;
        
        btn_cancel.Location = new System.Drawing.Point(809, 28);
        btn_cancel.Name = "btn_cancel";
        btn_cancel.Size = new System.Drawing.Size(766, 64);
        btn_cancel.TabIndex = 1;
        btn_cancel.Text = "Thanh Toán";
        btn_cancel.UseVisualStyleBackColor = true;
        btn_cancel.Click += btn_Payment_Click;
        
        // ──── FORM ────
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1587, 950);
        Controls.Add(pnl_details);
        Controls.Add(dgv_cart);
        Controls.Add(pnl_search);
        Controls.Add(pnl_bottom);
        Controls.Add(pnl_top);
        Margin = new System.Windows.Forms.Padding(6);
        Name = "FormSell";
        Text = "Bán hàng";
        Load += FormSell_Load;
        
        ((System.ComponentModel.ISupportInitialize)dgv_cart).EndInit();
        pnl_top.ResumeLayout(false);
        pnl_search.ResumeLayout(false);
        pnl_search.PerformLayout();
        pnl_details.ResumeLayout(false);
        grp_payment.ResumeLayout(false);
        grp_payment.PerformLayout();
        grp_paymentMethod.ResumeLayout(false);
        pnl_bottom.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Button btn_add;
    private System.Windows.Forms.Button btn_edit;
    private System.Windows.Forms.Button btn_delete;
    private System.Windows.Forms.Button btn_refresh;
    
    private System.Windows.Forms.Panel pnl_search;
    private System.Windows.Forms.TextBox txt_searchProduct;
    
    private System.Windows.Forms.DataGridView dgv_cart;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_productName;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_serielNumber;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_quantity;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_unitPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_totalPrice;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_remove;
    
    private System.Windows.Forms.Panel pnl_details;
    private System.Windows.Forms.GroupBox grp_payment;
    private System.Windows.Forms.Label lbl_subTotal;
    private System.Windows.Forms.Label lbl_discount;
    private System.Windows.Forms.Label lbl_finalTotal;
    
    private System.Windows.Forms.GroupBox grp_paymentMethod;
    private System.Windows.Forms.ComboBox cbo_paymentMethod;
    private System.Windows.Forms.Button btn_confirmPayment;
    
    private System.Windows.Forms.Panel pnl_bottom;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_cancel;

    #endregion
}