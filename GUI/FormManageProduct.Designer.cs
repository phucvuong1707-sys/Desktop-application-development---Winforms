namespace GUI
{
    partial class FormManageProduct
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            grp_topBar = new GroupBox();
            btn_productRefresh = new Button();
            btn_category = new Button();
            btn_productDelete = new Button();
            btn_productEdit = new Button();
            btn_productAdd = new Button();
            grp_bottom = new GroupBox();
            lbl_inventoryWarning = new Label();
            lbl_statusSummary = new Label();
            grp_left = new GroupBox();
            dgv_categoryFilter = new DataGridView();
            lbl_categoryTitle = new Label();
            grp_main = new GroupBox();
            dgv_productList = new DataGridView();
            grp_mainTop = new GroupBox();
            cbb_statusFilter = new ComboBox();
            lbl_productstatus = new Label();
            grp_topBar.SuspendLayout();
            grp_bottom.SuspendLayout();
            grp_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_categoryFilter).BeginInit();
            grp_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            grp_mainTop.SuspendLayout();
            SuspendLayout();
            // 
            // grp_topBar
            // 
            grp_topBar.Controls.Add(btn_productRefresh);
            grp_topBar.Controls.Add(btn_category);
            grp_topBar.Controls.Add(btn_productDelete);
            grp_topBar.Controls.Add(btn_productEdit);
            grp_topBar.Controls.Add(btn_productAdd);
            grp_topBar.Dock = DockStyle.Top;
            grp_topBar.Location = new Point(0, 0);
            grp_topBar.Margin = new Padding(2, 3, 2, 3);
            grp_topBar.Name = "grp_topBar";
            grp_topBar.Padding = new Padding(1);
            grp_topBar.Size = new Size(861, 56);
            grp_topBar.TabIndex = 0;
            grp_topBar.TabStop = false;
            // 
            // btn_productRefresh
            // 
            btn_productRefresh.Location = new Point(385, 14);
            btn_productRefresh.Margin = new Padding(2, 3, 2, 3);
            btn_productRefresh.Name = "btn_productRefresh";
            btn_productRefresh.Size = new Size(87, 28);
            btn_productRefresh.TabIndex = 4;
            btn_productRefresh.Text = "Làm mới";
            btn_productRefresh.UseVisualStyleBackColor = true;
            btn_productRefresh.Click += btn_productRefresh_Click;
            // 
            // btn_category
            // 
            btn_category.Location = new Point(297, 14);
            btn_category.Margin = new Padding(2, 3, 2, 3);
            btn_category.Name = "btn_category";
            btn_category.Size = new Size(87, 28);
            btn_category.TabIndex = 3;
            btn_category.Text = "Danh mục";
            btn_category.UseVisualStyleBackColor = true;
            btn_category.Click += btn_category_Click;
            // 
            // btn_productDelete
            // 
            btn_productDelete.Location = new Point(210, 14);
            btn_productDelete.Margin = new Padding(2, 3, 2, 3);
            btn_productDelete.Name = "btn_productDelete";
            btn_productDelete.Size = new Size(87, 28);
            btn_productDelete.TabIndex = 2;
            btn_productDelete.Text = "Xóa";
            btn_productDelete.UseVisualStyleBackColor = true;
            btn_productDelete.Click += btn_productDelete_Click;
            // 
            // btn_productEdit
            // 
            btn_productEdit.Location = new Point(123, 14);
            btn_productEdit.Margin = new Padding(2, 3, 2, 3);
            btn_productEdit.Name = "btn_productEdit";
            btn_productEdit.Size = new Size(87, 28);
            btn_productEdit.TabIndex = 1;
            btn_productEdit.Text = "Sửa";
            btn_productEdit.UseVisualStyleBackColor = true;
            btn_productEdit.Click += btn_productEdit_Click;
            // 
            // btn_productAdd
            // 
            btn_productAdd.Location = new Point(17, 14);
            btn_productAdd.Margin = new Padding(2, 3, 2, 3);
            btn_productAdd.Name = "btn_productAdd";
            btn_productAdd.Size = new Size(105, 28);
            btn_productAdd.TabIndex = 0;
            btn_productAdd.Text = "Thêm SP";
            btn_productAdd.UseVisualStyleBackColor = true;
            btn_productAdd.Click += btn_productAdd_Click;
            // 
            // grp_bottom
            // 
            grp_bottom.Controls.Add(lbl_inventoryWarning);
            grp_bottom.Controls.Add(lbl_statusSummary);
            grp_bottom.Dock = DockStyle.Bottom;
            grp_bottom.Location = new Point(0, 493);
            grp_bottom.Margin = new Padding(2, 3, 2, 3);
            grp_bottom.Name = "grp_bottom";
            grp_bottom.Padding = new Padding(1);
            grp_bottom.Size = new Size(861, 27);
            grp_bottom.TabIndex = 1;
            grp_bottom.TabStop = false;
            // 
            // lbl_inventoryWarning
            // 
            lbl_inventoryWarning.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbl_inventoryWarning.AutoSize = true;
            lbl_inventoryWarning.ForeColor = Color.DimGray;
            lbl_inventoryWarning.Location = new Point(657, 5);
            lbl_inventoryWarning.Margin = new Padding(2, 0, 2, 0);
            lbl_inventoryWarning.Name = "lbl_inventoryWarning";
            lbl_inventoryWarning.Size = new Size(192, 15);
            lbl_inventoryWarning.TabIndex = 1;
            lbl_inventoryWarning.Text = "Tồn kho thấp: 0 SP | Hết hàng: 0 SP";
            lbl_inventoryWarning.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lbl_statusSummary
            // 
            lbl_statusSummary.AutoSize = true;
            lbl_statusSummary.Location = new Point(11, 5);
            lbl_statusSummary.Margin = new Padding(2, 0, 2, 0);
            lbl_statusSummary.Name = "lbl_statusSummary";
            lbl_statusSummary.Size = new Size(210, 15);
            lbl_statusSummary.TabIndex = 0;
            lbl_statusSummary.Text = "Tổng: 0 sản phẩm | Đang chọn: Không";
            // 
            // grp_left
            // 
            grp_left.BackColor = Color.White;
            grp_left.Controls.Add(dgv_categoryFilter);
            grp_left.Controls.Add(lbl_categoryTitle);
            grp_left.Dock = DockStyle.Left;
            grp_left.Location = new Point(0, 56);
            grp_left.Margin = new Padding(2, 3, 2, 3);
            grp_left.Name = "grp_left";
            grp_left.Padding = new Padding(1);
            grp_left.Size = new Size(191, 437);
            grp_left.TabIndex = 2;
            grp_left.TabStop = false;
            // 
            // dgv_categoryFilter
            // 
            dgv_categoryFilter.AllowUserToAddRows = false;
            dgv_categoryFilter.AllowUserToDeleteRows = false;
            dgv_categoryFilter.AllowUserToResizeColumns = false;
            dgv_categoryFilter.AllowUserToResizeRows = false;
            dgv_categoryFilter.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_categoryFilter.BackgroundColor = Color.White;
            dgv_categoryFilter.BorderStyle = BorderStyle.None;
            dgv_categoryFilter.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_categoryFilter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_categoryFilter.ColumnHeadersVisible = false;
            dgv_categoryFilter.Dock = DockStyle.Fill;
            dgv_categoryFilter.Location = new Point(1, 54);
            dgv_categoryFilter.Margin = new Padding(2, 3, 2, 3);
            dgv_categoryFilter.MultiSelect = false;
            dgv_categoryFilter.Name = "dgv_categoryFilter";
            dgv_categoryFilter.ReadOnly = true;
            dgv_categoryFilter.RowHeadersVisible = false;
            dgv_categoryFilter.RowHeadersWidth = 102;
            dgv_categoryFilter.RowTemplate.Height = 35;
            dgv_categoryFilter.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_categoryFilter.Size = new Size(189, 382);
            dgv_categoryFilter.TabIndex = 1;
            dgv_categoryFilter.CellClick += dgv_categoryFilter_CellClick;
            // 
            // lbl_categoryTitle
            // 
            lbl_categoryTitle.Dock = DockStyle.Top;
            lbl_categoryTitle.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_categoryTitle.Location = new Point(1, 17);
            lbl_categoryTitle.Margin = new Padding(2, 0, 2, 0);
            lbl_categoryTitle.Name = "lbl_categoryTitle";
            lbl_categoryTitle.Padding = new Padding(9, 0, 0, 0);
            lbl_categoryTitle.Size = new Size(189, 37);
            lbl_categoryTitle.TabIndex = 0;
            lbl_categoryTitle.Text = "Danh mục";
            lbl_categoryTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // grp_main
            // 
            grp_main.Controls.Add(lbl_productstatus);
            grp_main.Controls.Add(dgv_productList);
            grp_main.Controls.Add(grp_mainTop);
            grp_main.Dock = DockStyle.Fill;
            grp_main.Location = new Point(191, 56);
            grp_main.Margin = new Padding(2, 3, 2, 3);
            grp_main.Name = "grp_main";
            grp_main.Padding = new Padding(9, 10, 9, 10);
            grp_main.Size = new Size(670, 437);
            grp_main.TabIndex = 3;
            grp_main.TabStop = false;
            // 
            // dgv_productList
            // 
            dgv_productList.AllowUserToAddRows = false;
            dgv_productList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_productList.BackgroundColor = Color.White;
            dgv_productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Dock = DockStyle.Fill;
            dgv_productList.Location = new Point(9, 73);
            dgv_productList.Margin = new Padding(2, 3, 2, 3);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.ReadOnly = true;
            dgv_productList.RowHeadersWidth = 102;
            dgv_productList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_productList.Size = new Size(652, 354);
            dgv_productList.TabIndex = 1;
            dgv_productList.CellClick += dgv_productList_CellClick;
            dgv_productList.CellFormatting += dgv_productList_CellFormatting;
            // 
            // grp_mainTop
            // 
            grp_mainTop.Controls.Add(cbb_statusFilter);
            grp_mainTop.Dock = DockStyle.Top;
            grp_mainTop.Location = new Point(9, 26);
            grp_mainTop.Margin = new Padding(2, 3, 2, 3);
            grp_mainTop.Name = "grp_mainTop";
            grp_mainTop.Padding = new Padding(1);
            grp_mainTop.Size = new Size(652, 47);
            grp_mainTop.TabIndex = 0;
            grp_mainTop.TabStop = false;
            // 
            // cbb_statusFilter
            // 
            cbb_statusFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            cbb_statusFilter.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbb_statusFilter.FormattingEnabled = true;
            cbb_statusFilter.Items.AddRange(new object[] { "Tất cả trạng thái", "Còn hàng", "Sắp hết", "Hết hàng" });
            cbb_statusFilter.Location = new Point(0, 10);
            cbb_statusFilter.Margin = new Padding(2, 3, 2, 3);
            cbb_statusFilter.Name = "cbb_statusFilter";
            cbb_statusFilter.Size = new Size(266, 25);
            cbb_statusFilter.TabIndex = 0;
            cbb_statusFilter.SelectedIndexChanged += cbb_statusFilter_SelectedIndexChanged;
            // 
            // lbl_productstatus
            // 
            lbl_productstatus.AutoSize = true;
            lbl_productstatus.Location = new Point(19, 17);
            lbl_productstatus.Name = "lbl_productstatus";
            lbl_productstatus.Size = new Size(115, 15);
            lbl_productstatus.TabIndex = 2;
            lbl_productstatus.Text = "Trạng thái sản phẩm";
            // 
            // FormManageProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 520);
            Controls.Add(grp_main);
            Controls.Add(grp_left);
            Controls.Add(grp_bottom);
            Controls.Add(grp_topBar);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormManageProduct";
            Text = "Quản lý sản phẩm";
            Load += FormManageProduct_Load;
            grp_topBar.ResumeLayout(false);
            grp_bottom.ResumeLayout(false);
            grp_bottom.PerformLayout();
            grp_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_categoryFilter).EndInit();
            grp_main.ResumeLayout(false);
            grp_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            grp_mainTop.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_topBar;
        private System.Windows.Forms.Button btn_productAdd;
        private System.Windows.Forms.Button btn_productEdit;
        private System.Windows.Forms.Button btn_productDelete;
        private System.Windows.Forms.Button btn_category;
        private System.Windows.Forms.Button btn_productRefresh;
        private System.Windows.Forms.GroupBox grp_bottom;
        private System.Windows.Forms.Label lbl_statusSummary;
        private System.Windows.Forms.Label lbl_inventoryWarning;
        private System.Windows.Forms.GroupBox grp_left;
        private System.Windows.Forms.Label lbl_categoryTitle;
        private System.Windows.Forms.DataGridView dgv_categoryFilter;
        private System.Windows.Forms.GroupBox grp_main;
        private System.Windows.Forms.GroupBox grp_mainTop;
        private System.Windows.Forms.ComboBox cbb_statusFilter;
        private System.Windows.Forms.DataGridView dgv_productList;
        private Label lbl_productstatus;
    }
}