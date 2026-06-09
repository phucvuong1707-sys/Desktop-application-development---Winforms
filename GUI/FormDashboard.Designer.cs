using System.ComponentModel;

namespace GUI;

partial class FormDashboard
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
        // ── Controls ─────────────────────────────────────────────────────────
        menuStrip   = new System.Windows.Forms.MenuStrip();
        toolStrip1  = new System.Windows.Forms.ToolStrip();
        statusStrip = new System.Windows.Forms.StatusStrip();

        // Menu items
        MI_sale          = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formSell    = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formGuest   = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formPromotion = new System.Windows.Forms.ToolStripMenuItem();

        MI_warehouse         = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formIntoWarehouse = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formInventory   = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formSupplier    = new System.Windows.Forms.ToolStripMenuItem();

        MI_guarantee      = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formWarranty = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formTradeIn  = new System.Windows.Forms.ToolStripMenuItem();

        MI_report           = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formReport     = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formManageShift = new System.Windows.Forms.ToolStripMenuItem();

        MI_system         = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formStaff    = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formProduct  = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formCategory = new System.Windows.Forms.ToolStripMenuItem();
        Menu_formLogout   = new System.Windows.Forms.ToolStripMenuItem();

        // ToolStrip buttons
        tsBtn_sell      = new System.Windows.Forms.ToolStripButton();
        tsBtn_guest     = new System.Windows.Forms.ToolStripButton();
        tsSep1          = new System.Windows.Forms.ToolStripSeparator();
        tsBtn_product   = new System.Windows.Forms.ToolStripButton();
        tsBtn_warehouse = new System.Windows.Forms.ToolStripButton();
        tsSep2          = new System.Windows.Forms.ToolStripSeparator();
        tsBtn_guarantee = new System.Windows.Forms.ToolStripButton();
        tsSep3          = new System.Windows.Forms.ToolStripSeparator();
        tsBtn_report    = new System.Windows.Forms.ToolStripButton();
        tsSep4          = new System.Windows.Forms.ToolStripSeparator();
        tsBtn_logout    = new System.Windows.Forms.ToolStripButton();

        // StatusStrip labels
        lbl_shift    = new System.Windows.Forms.ToolStripStatusLabel();
        lbl_revenue  = new System.Windows.Forms.ToolStripStatusLabel();
        lbl_userInfo = new System.Windows.Forms.ToolStripStatusLabel();
        lbl_dbStatus = new System.Windows.Forms.ToolStripStatusLabel();

        menuStrip.SuspendLayout();
        toolStrip1.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();

        // ── MenuStrip ─────────────────────────────────────────────────────────
        menuStrip.BackColor = System.Drawing.Color.FromArgb(43, 74, 122);
        menuStrip.ForeColor = System.Drawing.Color.White;
        menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
        menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            MI_sale, MI_warehouse, MI_guarantee, MI_report, MI_system });
        menuStrip.Location = new System.Drawing.Point(0, 0);
        menuStrip.Name = "menuStrip";
        menuStrip.Size = new System.Drawing.Size(1832, 30);
        menuStrip.TabIndex = 0;

        // MI_sale
        MI_sale.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Menu_formSell, Menu_formGuest, Menu_formPromotion });
        MI_sale.ForeColor = System.Drawing.Color.White;
        MI_sale.Name = "MI_sale";
        MI_sale.Text = "Bán hàng";

        Menu_formSell.Text = "Bán hàng";
        Menu_formSell.Name = "Menu_formSell";
        Menu_formSell.Click += Menu_formSell_Click;

        Menu_formGuest.Text = "Khách hàng";
        Menu_formGuest.Name = "Menu_formGuest";
        Menu_formGuest.Click += Menu_formGuest_Click;

        Menu_formPromotion.Text = "Khuyến mãi";
        Menu_formPromotion.Name = "Menu_formPromotion";
        Menu_formPromotion.Click += Menu_formPromotion_Click;

        // MI_warehouse
        MI_warehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Menu_formIntoWarehouse, Menu_formInventory, Menu_formSupplier });
        MI_warehouse.ForeColor = System.Drawing.Color.White;
        MI_warehouse.Name = "MI_warehouse";
        MI_warehouse.Text = "Kho hàng";

        Menu_formIntoWarehouse.Text = "Nhập kho";
        Menu_formIntoWarehouse.Name = "Menu_formIntoWarehouse";
        Menu_formIntoWarehouse.Click += Menu_formIntoWarehouse_Click;

        Menu_formInventory.Text = "Kiểm kê";
        Menu_formInventory.Name = "Menu_formInventory";
        Menu_formInventory.Click += Menu_formInventory_Click;

        Menu_formSupplier.Text = "Nhà cung cấp";
        Menu_formSupplier.Name = "Menu_formSupplier";
        Menu_formSupplier.Click += Menu_formSupplier_Click;

        // MI_guarantee
        MI_guarantee.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Menu_formWarranty, Menu_formTradeIn });
        MI_guarantee.ForeColor = System.Drawing.Color.White;
        MI_guarantee.Name = "MI_guarantee";
        MI_guarantee.Text = "Bảo hành";

        Menu_formWarranty.Text = "Tiếp nhận bảo hành";
        Menu_formWarranty.Name = "Menu_formWarranty";
        Menu_formWarranty.Click += Menu_formWarranty_Click;

        Menu_formTradeIn.Text = "Đổi trả";
        Menu_formTradeIn.Name = "Menu_formTradeIn";
        Menu_formTradeIn.Click += Menu_formTradeIn_Click;

        // MI_report
        MI_report.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Menu_formReport, Menu_formManageShift });
        MI_report.ForeColor = System.Drawing.Color.White;
        MI_report.Name = "MI_report";
        MI_report.Text = "Báo cáo";

        Menu_formReport.Text = "Báo cáo doanh thu";
        Menu_formReport.Name = "Menu_formReport";
        Menu_formReport.Click += Menu_formReport_Click;

        Menu_formManageShift.Text = "Ca làm việc";
        Menu_formManageShift.Name = "Menu_formManageShift";
        Menu_formManageShift.Click += Menu_formManageShift_Click;

        // MI_system
        MI_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            Menu_formStaff, Menu_formProduct, Menu_formCategory, Menu_formLogout });
        MI_system.ForeColor = System.Drawing.Color.White;
        MI_system.Name = "MI_system";
        MI_system.Text = "Hệ thống";

        Menu_formStaff.Text = "Nhân viên";
        Menu_formStaff.Name = "Menu_formStaff";
        Menu_formStaff.Click += Menu_formStaff_Click;

        Menu_formProduct.Text = "Sản phẩm";
        Menu_formProduct.Name = "Menu_formProduct";
        Menu_formProduct.Click += Menu_formProduct_Click;

        Menu_formCategory.Text = "Danh mục";
        Menu_formCategory.Name = "Menu_formCategory";
        Menu_formCategory.Click += Menu_formCategory_Click;

        Menu_formLogout.Text = "Đăng xuất";
        Menu_formLogout.Name = "Menu_formLogout";
        Menu_formLogout.ForeColor = System.Drawing.Color.OrangeRed;
        Menu_formLogout.Click += Menu_formLogout_Click;

        // ── ToolStrip (shortcut buttons) ──────────────────────────────────────
        toolStrip1.BackColor = System.Drawing.Color.FromArgb(240, 243, 248);
        toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
        toolStrip1.Location = new System.Drawing.Point(0, 30);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new System.Drawing.Size(1832, 55);
        toolStrip1.TabIndex = 1;
        toolStrip1.Padding = new System.Windows.Forms.Padding(4, 4, 0, 4);

        void SetBtn(System.Windows.Forms.ToolStripButton b, string text, EventHandler handler)
        {
            b.Text = text;
            b.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            b.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            b.AutoSize = true;
            b.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
            b.Click += handler;
        }

        SetBtn(tsBtn_sell,      "🛒 Bán hàng",   tsBtn_sell_Click);
        SetBtn(tsBtn_guest,     "👥 Khách hàng", tsBtn_guest_Click);
        SetBtn(tsBtn_product,   "📦 Sản phẩm",   tsBtn_product_Click);
        SetBtn(tsBtn_warehouse, "🏭 Nhập kho",    tsBtn_warehouse_Click);
        SetBtn(tsBtn_guarantee, "🔧 Bảo hành",   tsBtn_guarantee_Click);
        SetBtn(tsBtn_report,    "📊 Báo cáo",    tsBtn_report_Click);

        tsBtn_logout.Text = "🔴 Đăng xuất";
        tsBtn_logout.ForeColor = System.Drawing.Color.OrangeRed;
        tsBtn_logout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
        tsBtn_logout.AutoSize = true;
        tsBtn_logout.Padding = new System.Windows.Forms.Padding(10, 2, 10, 2);
        tsBtn_logout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
        tsBtn_logout.Click += tsBtn_logout_Click;

        toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            tsBtn_sell, tsBtn_guest, tsSep1,
            tsBtn_product, tsBtn_warehouse, tsSep2,
            tsBtn_guarantee, tsSep3,
            tsBtn_report, tsSep4,
            tsBtn_logout
        });

        // ── StatusStrip ───────────────────────────────────────────────────────
        statusStrip.BackColor = System.Drawing.Color.FromArgb(26, 43, 74);
        statusStrip.ForeColor = System.Drawing.Color.White;
        statusStrip.Location = new System.Drawing.Point(0, 1033);
        statusStrip.Name = "statusStrip";
        statusStrip.Size = new System.Drawing.Size(1832, 22);
        statusStrip.TabIndex = 2;

        lbl_shift.ForeColor  = System.Drawing.Color.White;
        lbl_shift.Name       = "lbl_shift";
        lbl_shift.Text       = "⏱ Ca: ...";

        lbl_revenue.ForeColor  = System.Drawing.Color.White;
        lbl_revenue.Name       = "lbl_revenue";
        lbl_revenue.Spring     = true;   // căn giữa
        lbl_revenue.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;
        lbl_revenue.Text       = "Doanh thu hôm nay: 0 đ";

        lbl_userInfo.ForeColor = System.Drawing.Color.White;
        lbl_userInfo.Name      = "lbl_userInfo";
        lbl_userInfo.Text      = "👤 ...";

        lbl_dbStatus.ForeColor = System.Drawing.Color.LightGreen;
        lbl_dbStatus.Name      = "lbl_dbStatus";
        lbl_dbStatus.Text      = "✅ CSDL";

        statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            lbl_shift, lbl_revenue, lbl_userInfo, lbl_dbStatus });

        // ── FormDashboard ─────────────────────────────────────────────────────
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1832, 1055);
        Controls.Add(statusStrip);
        Controls.Add(toolStrip1);
        Controls.Add(menuStrip);
        IsMdiContainer = true;
        MainMenuStrip = menuStrip;
        Text = "Quản lý Cửa hàng";
        WindowState = System.Windows.Forms.FormWindowState.Maximized;

        menuStrip.ResumeLayout(false);
        menuStrip.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    // Menu
    private System.Windows.Forms.MenuStrip menuStrip;
    private System.Windows.Forms.ToolStripMenuItem MI_sale, MI_warehouse, MI_guarantee, MI_report, MI_system;
    private System.Windows.Forms.ToolStripMenuItem Menu_formSell, Menu_formGuest, Menu_formPromotion;
    private System.Windows.Forms.ToolStripMenuItem Menu_formIntoWarehouse, Menu_formInventory, Menu_formSupplier;
    private System.Windows.Forms.ToolStripMenuItem Menu_formWarranty, Menu_formTradeIn;
    private System.Windows.Forms.ToolStripMenuItem Menu_formReport, Menu_formManageShift;
    private System.Windows.Forms.ToolStripMenuItem Menu_formStaff, Menu_formProduct, Menu_formCategory, Menu_formLogout;

    // ToolStrip
    private System.Windows.Forms.ToolStrip toolStrip1;
    private System.Windows.Forms.ToolStripButton tsBtn_sell, tsBtn_guest, tsBtn_product;
    private System.Windows.Forms.ToolStripButton tsBtn_warehouse, tsBtn_guarantee, tsBtn_report, tsBtn_logout;
    private System.Windows.Forms.ToolStripSeparator tsSep1, tsSep2, tsSep3, tsSep4;

    // StatusStrip
    private System.Windows.Forms.StatusStrip statusStrip;
    private System.Windows.Forms.ToolStripStatusLabel lbl_shift, lbl_revenue, lbl_userInfo, lbl_dbStatus;
}