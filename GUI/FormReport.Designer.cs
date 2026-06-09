using System.ComponentModel;

namespace GUI;

partial class FormReport
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        components = new Container();
        DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
        DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
        pnl_top = new Panel();
        btn_excelOut = new Button();
        btn_showReport = new Button();
        panel2 = new Panel();
        button3 = new Button();
        button4 = new Button();
        dgv_listInvoices = new DataGridView();
        col_maHD = new DataGridViewTextBoxColumn();
        col_thoiGian = new DataGridViewTextBoxColumn();
        col_khachHang = new DataGridViewTextBoxColumn();
        col_sanPham = new DataGridViewTextBoxColumn();
        col_doanhThu = new DataGridViewTextBoxColumn();
        col_loiNhuan = new DataGridViewTextBoxColumn();
        col_thanhToan = new DataGridViewTextBoxColumn();
        imageList1 = new ImageList(components);
        cbb_dayFill = new ComboBox();
        dtp_from = new DateTimePicker();
        label1 = new Label();
        dtp_to = new DateTimePicker();
        panel3 = new Panel();
        lbl_warranty = new Label();
        lbl_invoiceNum = new Label();
        lbl_productSold = new Label();
        lbl_grossProfit = new Label();
        lbl_outCome = new Label();
        pnl_footer = new Panel();
        lbl_footerRight = new Label();
        lbl_footerLeft = new Label();
        groupBox1 = new GroupBox();
        pnl_top.SuspendLayout();
        panel2.SuspendLayout();
        ((ISupportInitialize)dgv_listInvoices).BeginInit();
        panel3.SuspendLayout();
        pnl_footer.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // pnl_top
        // 
        pnl_top.BackColor = Color.WhiteSmoke;
        pnl_top.Controls.Add(btn_excelOut);
        pnl_top.Controls.Add(btn_showReport);
        pnl_top.Dock = DockStyle.Top;
        pnl_top.ForeColor = Color.White;
        pnl_top.Location = new Point(0, 0);
        pnl_top.Margin = new Padding(6, 6, 6, 6);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new Size(2006, 102);
        pnl_top.TabIndex = 1;
        pnl_top.Paint += pnl_Top_Paint;
        // 
        // btn_excelOut
        // 
        btn_excelOut.ForeColor = Color.Black;
        btn_excelOut.Location = new Point(382, 20);
        btn_excelOut.Margin = new Padding(6, 6, 6, 6);
        btn_excelOut.Name = "btn_excelOut";
        btn_excelOut.Size = new Size(255, 62);
        btn_excelOut.TabIndex = 1;
        btn_excelOut.Text = "📤Xuất Excel";
        btn_excelOut.UseVisualStyleBackColor = true;
        btn_excelOut.Click += btn_xuatExcel_Click;
        // 
        // btn_showReport
        // 
        btn_showReport.ForeColor = Color.Black;
        btn_showReport.Location = new Point(51, 20);
        btn_showReport.Margin = new Padding(6, 6, 6, 6);
        btn_showReport.Name = "btn_showReport";
        btn_showReport.Size = new Size(319, 62);
        btn_showReport.TabIndex = 0;
        btn_showReport.Text = "📊Xem báo cáo";
        btn_showReport.UseVisualStyleBackColor = true;
        btn_showReport.Click += btn_xemBaocao_Click;
        // 
        // panel2
        // 
        panel2.Controls.Add(button3);
        panel2.Controls.Add(button4);
        panel2.Location = new Point(36, 48);
        panel2.Name = "panel2";
        panel2.Size = new Size(731, 75);
        panel2.TabIndex = 3;
        // 
        // button3
        // 
        button3.Location = new Point(589, 16);
        button3.Name = "button3";
        button3.Size = new Size(116, 42);
        button3.TabIndex = 1;
        button3.Text = "button2";
        button3.UseVisualStyleBackColor = true;
        // 
        // button4
        // 
        button4.Location = new Point(457, 16);
        button4.Name = "button4";
        button4.Size = new Size(116, 42);
        button4.TabIndex = 0;
        button4.Text = "button1";
        button4.UseVisualStyleBackColor = true;
        // 
        // dgv_listInvoices
        // 
        dataGridViewCellStyle1.BackColor = Color.Honeydew;
        dgv_listInvoices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
        dgv_listInvoices.BackgroundColor = SystemColors.ButtonHighlight;
        dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
        dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
        dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
        dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
        dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
        dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
        dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
        dgv_listInvoices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
        dgv_listInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_listInvoices.Columns.AddRange(new DataGridViewColumn[] { col_maHD, col_thoiGian, col_khachHang, col_sanPham, col_doanhThu, col_loiNhuan, col_thanhToan });
        dgv_listInvoices.Dock = DockStyle.Fill;
        dgv_listInvoices.GridColor = SystemColors.GrayText;
        dgv_listInvoices.Location = new Point(0, 447);
        dgv_listInvoices.Margin = new Padding(6, 6, 6, 6);
        dgv_listInvoices.Name = "dgv_listInvoices";
        dgv_listInvoices.RowHeadersWidth = 51;
        dgv_listInvoices.Size = new Size(2006, 306);
        dgv_listInvoices.TabIndex = 2;
        dgv_listInvoices.Text = "dataGridView1";
        // 
        // col_maHD
        // 
        col_maHD.HeaderText = "Mã HĐ";
        col_maHD.MinimumWidth = 6;
        col_maHD.Name = "col_maHD";
        col_maHD.Width = 150;
        // 
        // col_thoiGian
        // 
        col_thoiGian.HeaderText = "Thời gian";
        col_thoiGian.MinimumWidth = 6;
        col_thoiGian.Name = "col_thoiGian";
        col_thoiGian.Width = 150;
        // 
        // col_khachHang
        // 
        col_khachHang.HeaderText = "Khách Hàng";
        col_khachHang.MinimumWidth = 6;
        col_khachHang.Name = "col_khachHang";
        col_khachHang.Width = 150;
        // 
        // col_sanPham
        // 
        col_sanPham.HeaderText = "Sản Phẩm";
        col_sanPham.MinimumWidth = 6;
        col_sanPham.Name = "col_sanPham";
        col_sanPham.Width = 150;
        // 
        // col_doanhThu
        // 
        col_doanhThu.HeaderText = "Doanh Thu";
        col_doanhThu.MinimumWidth = 6;
        col_doanhThu.Name = "col_doanhThu";
        col_doanhThu.Width = 150;
        // 
        // col_loiNhuan
        // 
        col_loiNhuan.HeaderText = "Lợi nhuân";
        col_loiNhuan.MinimumWidth = 6;
        col_loiNhuan.Name = "col_loiNhuan";
        col_loiNhuan.Width = 150;
        // 
        // col_thanhToan
        // 
        col_thanhToan.HeaderText = "Thanh toán";
        col_thanhToan.MinimumWidth = 6;
        col_thanhToan.Name = "col_thanhToan";
        col_thanhToan.Width = 150;
        // 
        // imageList1
        // 
        imageList1.ColorDepth = ColorDepth.Depth32Bit;
        imageList1.ImageSize = new Size(16, 16);
        imageList1.TransparentColor = Color.Transparent;
        // 
        // cbb_dayFill
        // 
        cbb_dayFill.FormattingEnabled = true;
        cbb_dayFill.Items.AddRange(new object[] { "Hôm nay", "Hôm qua", "7 ngày qua", "Tháng này", "Tùy chỉnh" });
        cbb_dayFill.Location = new Point(19, 39);
        cbb_dayFill.Margin = new Padding(6, 6, 6, 6);
        cbb_dayFill.Name = "cbb_dayFill";
        cbb_dayFill.Size = new Size(314, 49);
        cbb_dayFill.TabIndex = 3;
        // 
        // dtp_from
        // 
        dtp_from.Format = DateTimePickerFormat.Short;
        dtp_from.Location = new Point(361, 41);
        dtp_from.Margin = new Padding(6, 6, 6, 6);
        dtp_from.Name = "dtp_from";
        dtp_from.Size = new Size(229, 47);
        dtp_from.TabIndex = 4;
        // 
        // label1
        // 
        label1.Location = new Point(606, 47);
        label1.Margin = new Padding(6, 0, 6, 0);
        label1.Name = "label1";
        label1.Size = new Size(85, 47);
        label1.TabIndex = 5;
        label1.Text = "Đến:";
        label1.Click += label1_Click;
        // 
        // dtp_to
        // 
        dtp_to.Format = DateTimePickerFormat.Short;
        dtp_to.Location = new Point(701, 41);
        dtp_to.Margin = new Padding(6, 6, 6, 6);
        dtp_to.Name = "dtp_to";
        dtp_to.Size = new Size(229, 47);
        dtp_to.TabIndex = 6;
        // 
        // panel3
        // 
        panel3.BorderStyle = BorderStyle.FixedSingle;
        panel3.Controls.Add(lbl_warranty);
        panel3.Controls.Add(lbl_invoiceNum);
        panel3.Controls.Add(lbl_productSold);
        panel3.Controls.Add(lbl_grossProfit);
        panel3.Controls.Add(lbl_outCome);
        panel3.Dock = DockStyle.Bottom;
        panel3.Location = new Point(6, 116);
        panel3.Margin = new Padding(6, 6, 6, 6);
        panel3.Name = "panel3";
        panel3.Size = new Size(1994, 223);
        panel3.TabIndex = 7;
        // 
        // lbl_warranty
        // 
        lbl_warranty.BackColor = Color.White;
        lbl_warranty.BorderStyle = BorderStyle.FixedSingle;
        lbl_warranty.ForeColor = Color.FromArgb(255, 128, 0);
        lbl_warranty.Location = new Point(1318, 10);
        lbl_warranty.Margin = new Padding(6, 0, 6, 0);
        lbl_warranty.Name = "lbl_warranty";
        lbl_warranty.Size = new Size(316, 203);
        lbl_warranty.TabIndex = 4;
        lbl_warranty.Text = "Bảo hành";
        lbl_warranty.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_invoiceNum
        // 
        lbl_invoiceNum.BackColor = Color.White;
        lbl_invoiceNum.BorderStyle = BorderStyle.FixedSingle;
        lbl_invoiceNum.ForeColor = SystemColors.HotTrack;
        lbl_invoiceNum.Location = new Point(988, 10);
        lbl_invoiceNum.Margin = new Padding(6, 0, 6, 0);
        lbl_invoiceNum.Name = "lbl_invoiceNum";
        lbl_invoiceNum.Size = new Size(316, 203);
        lbl_invoiceNum.TabIndex = 3;
        lbl_invoiceNum.Text = "Số hóa đơn";
        lbl_invoiceNum.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_productSold
        // 
        lbl_productSold.BackColor = Color.White;
        lbl_productSold.BorderStyle = BorderStyle.FixedSingle;
        lbl_productSold.ForeColor = SystemColors.MenuHighlight;
        lbl_productSold.Location = new Point(659, 10);
        lbl_productSold.Margin = new Padding(6, 0, 6, 0);
        lbl_productSold.Name = "lbl_productSold";
        lbl_productSold.Size = new Size(316, 203);
        lbl_productSold.TabIndex = 2;
        lbl_productSold.Text = "Sản phẩm";
        lbl_productSold.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_grossProfit
        // 
        lbl_grossProfit.BackColor = Color.White;
        lbl_grossProfit.BorderStyle = BorderStyle.FixedSingle;
        lbl_grossProfit.ForeColor = Color.ForestGreen;
        lbl_grossProfit.Location = new Point(329, 10);
        lbl_grossProfit.Margin = new Padding(6, 0, 6, 0);
        lbl_grossProfit.Name = "lbl_grossProfit";
        lbl_grossProfit.Size = new Size(316, 203);
        lbl_grossProfit.TabIndex = 1;
        lbl_grossProfit.Text = "Lợi nhuận gộp";
        lbl_grossProfit.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // lbl_outCome
        // 
        lbl_outCome.BackColor = SystemColors.ButtonHighlight;
        lbl_outCome.BorderStyle = BorderStyle.FixedSingle;
        lbl_outCome.ForeColor = SystemColors.Highlight;
        lbl_outCome.Location = new Point(11, 10);
        lbl_outCome.Margin = new Padding(6, 0, 6, 0);
        lbl_outCome.Name = "lbl_outCome";
        lbl_outCome.Size = new Size(306, 203);
        lbl_outCome.TabIndex = 0;
        lbl_outCome.Text = "Doanh thu";
        lbl_outCome.TextAlign = ContentAlignment.MiddleCenter;
        // 
        // pnl_footer
        // 
        pnl_footer.BackColor = Color.WhiteSmoke;
        pnl_footer.BorderStyle = BorderStyle.Fixed3D;
        pnl_footer.Controls.Add(lbl_footerRight);
        pnl_footer.Controls.Add(lbl_footerLeft);
        pnl_footer.Dock = DockStyle.Bottom;
        pnl_footer.Location = new Point(0, 753);
        pnl_footer.Margin = new Padding(6, 6, 6, 6);
        pnl_footer.Name = "pnl_footer";
        pnl_footer.Size = new Size(2006, 98);
        pnl_footer.TabIndex = 8;
        // 
        // lbl_footerRight
        // 
        lbl_footerRight.BackColor = Color.LightGray;
        lbl_footerRight.Location = new Point(833, 0);
        lbl_footerRight.Margin = new Padding(6, 0, 6, 0);
        lbl_footerRight.Name = "lbl_footerRight";
        lbl_footerRight.Size = new Size(824, 94);
        lbl_footerRight.TabIndex = 1;
        lbl_footerRight.Text = "Tỉ lệ lợi nhuân";
        lbl_footerRight.TextAlign = ContentAlignment.MiddleRight;
        // 
        // lbl_footerLeft
        // 
        lbl_footerLeft.BackColor = Color.Gainsboro;
        lbl_footerLeft.Location = new Point(-4, 0);
        lbl_footerLeft.Margin = new Padding(6, 0, 6, 0);
        lbl_footerLeft.Name = "lbl_footerLeft";
        lbl_footerLeft.Size = new Size(842, 94);
        lbl_footerLeft.TabIndex = 0;
        lbl_footerLeft.Text = "Báo cáo ngày:";
        lbl_footerLeft.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // groupBox1
        // 
        groupBox1.BackColor = Color.WhiteSmoke;
        groupBox1.Controls.Add(cbb_dayFill);
        groupBox1.Controls.Add(dtp_from);
        groupBox1.Controls.Add(panel3);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(dtp_to);
        groupBox1.Dock = DockStyle.Top;
        groupBox1.Location = new Point(0, 102);
        groupBox1.Margin = new Padding(6, 6, 6, 6);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(6, 6, 6, 6);
        groupBox1.Size = new Size(2006, 345);
        groupBox1.TabIndex = 9;
        groupBox1.TabStop = false;
        // 
        // FormReport
        // 
        AutoScaleDimensions = new SizeF(17F, 41F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.White;
        ClientSize = new Size(2006, 851);
        Controls.Add(dgv_listInvoices);
        Controls.Add(groupBox1);
        Controls.Add(pnl_footer);
        Controls.Add(pnl_top);
        ForeColor = SystemColors.ActiveCaptionText;
        Margin = new Padding(13, 12, 13, 12);
        Name = "FormReport";
        Text = "Báo cáo doanh thu";
        Load += FormReport_Load;
        pnl_top.ResumeLayout(false);
        panel2.ResumeLayout(false);
        ((ISupportInitialize)dgv_listInvoices).EndInit();
        panel3.ResumeLayout(false);
        pnl_footer.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        ResumeLayout(false);
    }

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label lbl_footerLeft;
    private System.Windows.Forms.Label lbl_footerRight;

    private System.Windows.Forms.Panel pnl_footer;

    private System.Windows.Forms.DataGridViewTextBoxColumn col_maHD;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_thoiGian;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_khachHang;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_sanPham;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_doanhThu;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_loiNhuan;
    private System.Windows.Forms.DataGridViewTextBoxColumn col_thanhToan;

    private System.Windows.Forms.Label lbl_invoiceNum;
    private System.Windows.Forms.Label lbl_warranty;

    private System.Windows.Forms.Label lbl_productSold;

    private System.Windows.Forms.Label lbl_grossProfit;

    private System.Windows.Forms.Label lbl_doanhThu;

    private System.Windows.Forms.Panel panel3;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DateTimePicker dtp_to;

    private System.Windows.Forms.DateTimePicker dtp_from;

    private System.Windows.Forms.ComboBox cbb_dayFill;

    private System.Windows.Forms.ImageList imageList1;

    private System.Windows.Forms.Button btn_showReport;
    private System.Windows.Forms.Button btn_excelOut;

    private System.Windows.Forms.DataGridView dgv_listInvoices;
    private System.Windows.Forms.Panel pnl_top;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    #endregion

    private Label lbl_outCome;
}