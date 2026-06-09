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

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        dgv_cart = new System.Windows.Forms.DataGridView();
        col_productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_serielNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_unitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_remove = new System.Windows.Forms.DataGridViewTextBoxColumn();
        backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        grp_Action = new System.Windows.Forms.GroupBox();
        btn_promotion = new System.Windows.Forms.Button();
        btn_customer = new System.Windows.Forms.Button();
        txt_searchProduct = new System.Windows.Forms.TextBox();
        pnl_top = new System.Windows.Forms.Panel();
        btn_todayInvoice = new System.Windows.Forms.Button();
        btn_payment = new System.Windows.Forms.Button();
        btn_cancelInvoice = new System.Windows.Forms.Button();
        btn_print = new System.Windows.Forms.Button();
        groupBox3 = new System.Windows.Forms.GroupBox();
        lbl_subTotal = new System.Windows.Forms.Label();
        lbl_discount = new System.Windows.Forms.Label();
        lbl_finalTotal = new System.Windows.Forms.Label();
        groupBox4 = new System.Windows.Forms.GroupBox();
        cbo_paymentMethod = new System.Windows.Forms.ComboBox();
        btn_confirmPayment = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)dgv_cart).BeginInit();
        grp_Action.SuspendLayout();
        pnl_top.SuspendLayout();
        groupBox3.SuspendLayout();
        groupBox4.SuspendLayout();
        SuspendLayout();
        // 
        // dgv_cart
        // 
        dgv_cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_cart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_productName, col_serielNumber, col_quantity, col_unitPrice, col_totalPrice, col_remove });
        dgv_cart.Location = new System.Drawing.Point(0, 93);
        dgv_cart.Margin = new System.Windows.Forms.Padding(1);
        dgv_cart.Name = "dgv_cart";
        dgv_cart.RowHeadersWidth = 51;
        dgv_cart.Size = new System.Drawing.Size(776, 170);
        dgv_cart.TabIndex = 4;
        dgv_cart.CellContentClick += dgv_Cart_CellContentClick;
        // 
        // col_productName
        // 
        col_productName.HeaderText = "Tên SP";
        col_productName.MinimumWidth = 12;
        col_productName.Name = "col_productName";
        col_productName.Width = 250;
        // 
        // col_serielNumber
        // 
        col_serielNumber.HeaderText = "Serial";
        col_serielNumber.MinimumWidth = 12;
        col_serielNumber.Name = "col_serielNumber";
        col_serielNumber.Width = 200;
        // 
        // col_quantity
        // 
        col_quantity.HeaderText = "SL";
        col_quantity.MinimumWidth = 12;
        col_quantity.Name = "col_quantity";
        col_quantity.Width = 80;
        // 
        // col_unitPrice
        // 
        col_unitPrice.HeaderText = "Đơn giá";
        col_unitPrice.MinimumWidth = 12;
        col_unitPrice.Name = "col_unitPrice";
        col_unitPrice.Width = 150;
        // 
        // col_totalPrice
        // 
        col_totalPrice.HeaderText = "Thành tiền";
        col_totalPrice.MinimumWidth = 12;
        col_totalPrice.Name = "col_totalPrice";
        col_totalPrice.Width = 150;
        // 
        // col_remove
        // 
        col_remove.HeaderText = "Xóa";
        col_remove.MinimumWidth = 12;
        col_remove.Name = "col_remove";
        col_remove.Width = 70;
        // 
        // grp_Action
        // 
        grp_Action.Controls.Add(btn_promotion);
        grp_Action.Controls.Add(btn_customer);
        grp_Action.Controls.Add(txt_searchProduct);
        grp_Action.Location = new System.Drawing.Point(0, 41);
        grp_Action.Margin = new System.Windows.Forms.Padding(1);
        grp_Action.Name = "grp_Action";
        grp_Action.Padding = new System.Windows.Forms.Padding(1);
        grp_Action.Size = new System.Drawing.Size(776, 49);
        grp_Action.TabIndex = 5;
        grp_Action.TabStop = false;
        grp_Action.Enter += grp_Action_Enter;
        // 
        // btn_promotion
        // 
        btn_promotion.Location = new System.Drawing.Point(572, 14);
        btn_promotion.Margin = new System.Windows.Forms.Padding(1);
        btn_promotion.Name = "btn_promotion";
        btn_promotion.Size = new System.Drawing.Size(196, 24);
        btn_promotion.TabIndex = 2;
        btn_promotion.Text = "Mã KM";
        btn_promotion.UseVisualStyleBackColor = true;
        btn_promotion.Click += btn_Promotion_Click;
        // 
        // btn_customer
        // 
        btn_customer.Location = new System.Drawing.Point(367, 14);
        btn_customer.Margin = new System.Windows.Forms.Padding(1);
        btn_customer.Name = "btn_customer";
        btn_customer.Size = new System.Drawing.Size(202, 24);
        btn_customer.TabIndex = 1;
        btn_customer.Text = "SĐT Khách Hàng";
        btn_customer.UseVisualStyleBackColor = true;
        btn_customer.Click += btn_Customer_Click;
        // 
        // txt_searchProduct
        // 
        txt_searchProduct.Location = new System.Drawing.Point(6, 14);
        txt_searchProduct.Margin = new System.Windows.Forms.Padding(1);
        txt_searchProduct.Name = "txt_searchProduct";
        txt_searchProduct.PlaceholderText = "Quét mã SP / Serial...";
        txt_searchProduct.Size = new System.Drawing.Size(360, 47);
        txt_searchProduct.TabIndex = 0;
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_todayInvoice);
        pnl_top.Controls.Add(btn_payment);
        pnl_top.Controls.Add(btn_cancelInvoice);
        pnl_top.Controls.Add(btn_print);
        pnl_top.Location = new System.Drawing.Point(0, -1);
        pnl_top.Margin = new System.Windows.Forms.Padding(1);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new System.Drawing.Size(776, 40);
        pnl_top.TabIndex = 9;
        // 
        // btn_todayInvoice
        // 
        btn_todayInvoice.Location = new System.Drawing.Point(572, 7);
        btn_todayInvoice.Margin = new System.Windows.Forms.Padding(1);
        btn_todayInvoice.Name = "btn_todayInvoice";
        btn_todayInvoice.Size = new System.Drawing.Size(196, 28);
        btn_todayInvoice.TabIndex = 13;
        btn_todayInvoice.Text = "Hóa Đơn Hôm Nay";
        btn_todayInvoice.UseVisualStyleBackColor = true;
        btn_todayInvoice.Click += btnTodayInvoice_Click;
        // 
        // btn_payment
        // 
        btn_payment.Location = new System.Drawing.Point(6, 7);
        btn_payment.Margin = new System.Windows.Forms.Padding(1);
        btn_payment.Name = "btn_payment";
        btn_payment.Size = new System.Drawing.Size(171, 28);
        btn_payment.TabIndex = 10;
        btn_payment.Text = "Thanh Toán";
        btn_payment.UseVisualStyleBackColor = true;
        btn_payment.Click += btn_Payment_Click;
        // 
        // btn_cancelInvoice
        // 
        btn_cancelInvoice.Location = new System.Drawing.Point(367, 7);
        btn_cancelInvoice.Margin = new System.Windows.Forms.Padding(1);
        btn_cancelInvoice.Name = "btn_cancelInvoice";
        btn_cancelInvoice.Size = new System.Drawing.Size(202, 28);
        btn_cancelInvoice.TabIndex = 12;
        btn_cancelInvoice.Text = "Hủy Hóa Đơn";
        btn_cancelInvoice.UseVisualStyleBackColor = true;
        btn_cancelInvoice.Click += btn_CancelInvoice_Click;
        // 
        // btn_print
        // 
        btn_print.Location = new System.Drawing.Point(180, 7);
        btn_print.Margin = new System.Windows.Forms.Padding(1);
        btn_print.Name = "btn_print";
        btn_print.Size = new System.Drawing.Size(184, 28);
        btn_print.TabIndex = 11;
        btn_print.Text = "In Hóa Đơn";
        btn_print.UseVisualStyleBackColor = true;
        btn_print.Click += btn_Print_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(lbl_subTotal);
        groupBox3.Controls.Add(lbl_discount);
        groupBox3.Controls.Add(lbl_finalTotal);
        groupBox3.Location = new System.Drawing.Point(0, 266);
        groupBox3.Margin = new System.Windows.Forms.Padding(1);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new System.Windows.Forms.Padding(1);
        groupBox3.Size = new System.Drawing.Size(776, 80);
        groupBox3.TabIndex = 7;
        groupBox3.TabStop = false;
        // 
        // lbl_subTotal
        // 
        lbl_subTotal.AutoSize = true;
        lbl_subTotal.Location = new System.Drawing.Point(6, 9);
        lbl_subTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
        lbl_subTotal.Name = "lbl_subTotal";
        lbl_subTotal.Size = new System.Drawing.Size(141, 41);
        lbl_subTotal.TabIndex = 2;
        lbl_subTotal.Text = "Tạm tính:";
        // 
        // lbl_discount
        // 
        lbl_discount.AutoSize = true;
        lbl_discount.ForeColor = System.Drawing.Color.OrangeRed;
        lbl_discount.Location = new System.Drawing.Point(6, 34);
        lbl_discount.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
        lbl_discount.Name = "lbl_discount";
        lbl_discount.Size = new System.Drawing.Size(142, 41);
        lbl_discount.TabIndex = 4;
        lbl_discount.Text = "Giảm giá:";
        // 
        // lbl_finalTotal
        // 
        lbl_finalTotal.AutoSize = true;
        lbl_finalTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
        lbl_finalTotal.ForeColor = System.Drawing.Color.DarkGreen;
        lbl_finalTotal.Location = new System.Drawing.Point(3, 56);
        lbl_finalTotal.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
        lbl_finalTotal.Name = "lbl_finalTotal";
        lbl_finalTotal.Size = new System.Drawing.Size(233, 54);
        lbl_finalTotal.TabIndex = 6;
        lbl_finalTotal.Text = "Tổng cộng:";
        // 
        // groupBox4
        // 
        groupBox4.Controls.Add(cbo_paymentMethod);
        groupBox4.Controls.Add(btn_confirmPayment);
        groupBox4.Location = new System.Drawing.Point(0, 350);
        groupBox4.Margin = new System.Windows.Forms.Padding(1);
        groupBox4.Name = "groupBox4";
        groupBox4.Padding = new System.Windows.Forms.Padding(1);
        groupBox4.Size = new System.Drawing.Size(777, 80);
        groupBox4.TabIndex = 8;
        groupBox4.TabStop = false;
        // 
        // cbo_paymentMethod
        // 
        cbo_paymentMethod.FormattingEnabled = true;
        cbo_paymentMethod.Items.AddRange(new object[] { "Tiền mặt", "Chuyển khoản", "MoMo", "ZaloPay", "Thẻ tín dụng" });
        cbo_paymentMethod.Location = new System.Drawing.Point(6, 17);
        cbo_paymentMethod.Margin = new System.Windows.Forms.Padding(1);
        cbo_paymentMethod.Name = "cbo_paymentMethod";
        cbo_paymentMethod.Size = new System.Drawing.Size(764, 49);
        cbo_paymentMethod.TabIndex = 0;
        // 
        // btn_confirmPayment
        // 
        btn_confirmPayment.Location = new System.Drawing.Point(6, 43);
        btn_confirmPayment.Margin = new System.Windows.Forms.Padding(1);
        btn_confirmPayment.Name = "btn_confirmPayment";
        btn_confirmPayment.Size = new System.Drawing.Size(762, 28);
        btn_confirmPayment.TabIndex = 3;
        btn_confirmPayment.Text = "Xác Nhận Thanh Toán";
        btn_confirmPayment.UseVisualStyleBackColor = true;
        btn_confirmPayment.Click += btn_ConfirmPayment_Click;
        // 
        // FormSell
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(926, 505);
        Controls.Add(pnl_top);
        Controls.Add(grp_Action);
        Controls.Add(dgv_cart);
        Controls.Add(groupBox3);
        Controls.Add(groupBox4);
        Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
        Text = "Bán hàng";
        ((System.ComponentModel.ISupportInitialize)dgv_cart).EndInit();
        grp_Action.ResumeLayout(false);
        grp_Action.PerformLayout();
        pnl_top.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        groupBox4.ResumeLayout(false);
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.DataGridView dgv_cart;
    private System.ComponentModel.BackgroundWorker backgroundWorker1;
    private System.Windows.Forms.GroupBox grp_Action;
    private System.Windows.Forms.Button btn_promotion;
    private System.Windows.Forms.Button btn_customer;
    private System.Windows.Forms.TextBox txt_searchProduct;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Button btn_todayInvoice;
    private System.Windows.Forms.Button btn_cancelInvoice;
    private System.Windows.Forms.Button btn_print;
    private System.Windows.Forms.Button btn_payment;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label lbl_subTotal;
    private System.Windows.Forms.Label lbl_discount;
    private System.Windows.Forms.Label lbl_finalTotal;
    private System.Windows.Forms.GroupBox groupBox4;
    private System.Windows.Forms.ComboBox cbo_paymentMethod;
    private System.Windows.Forms.Button btn_confirmPayment;
    private DataGridViewTextBoxColumn col_productName;
    private DataGridViewTextBoxColumn col_serielNumber;
    private DataGridViewTextBoxColumn col_quantity;
    private DataGridViewTextBoxColumn col_unitPrice;
    private DataGridViewTextBoxColumn col_totalPrice;
    private DataGridViewTextBoxColumn col_remove;
}