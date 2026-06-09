namespace GUI
{
    partial class FormCategory
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
            this.grp_actions = new System.Windows.Forms.GroupBox();
            this.btn_categoryRefresh = new System.Windows.Forms.Button();
            this.btn_categoryDelete = new System.Windows.Forms.Button();
            this.btn_categoryEdit = new System.Windows.Forms.Button();
            this.btn_categoryAdd = new System.Windows.Forms.Button();
            this.grp_status = new System.Windows.Forms.GroupBox();
            this.lbl_statusSummary = new System.Windows.Forms.Label();
            this.grp_categoryDetails = new System.Windows.Forms.GroupBox();
            this.btn_categoryCancel = new System.Windows.Forms.Button();
            this.btn_categorySave = new System.Windows.Forms.Button();
            this.cbb_categoryStatus = new System.Windows.Forms.ComboBox();
            this.lbl_categoryStatus = new System.Windows.Forms.Label();
            this.txt_categoryDesc = new System.Windows.Forms.TextBox();
            this.lbl_categoryDesc = new System.Windows.Forms.Label();
            this.txt_categoryName = new System.Windows.Forms.TextBox();
            this.lbl_categoryName = new System.Windows.Forms.Label();
            this.grp_categoryList = new System.Windows.Forms.GroupBox();
            this.dgv_listCategory = new System.Windows.Forms.DataGridView();
            this.txt_categorySearch = new System.Windows.Forms.TextBox();
            this.lbl_searchTitle = new System.Windows.Forms.Label();
            this.grp_actions.SuspendLayout();
            this.grp_status.SuspendLayout();
            this.grp_categoryDetails.SuspendLayout();
            this.grp_categoryList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // grp_actions
            // 
            this.grp_actions.Controls.Add(this.btn_categoryRefresh);
            this.grp_actions.Controls.Add(this.btn_categoryDelete);
            this.grp_actions.Controls.Add(this.btn_categoryEdit);
            this.grp_actions.Controls.Add(this.btn_categoryAdd);
            this.grp_actions.Dock = System.Windows.Forms.DockStyle.Top;
            this.grp_actions.Location = new System.Drawing.Point(0, 0);
            this.grp_actions.Name = "grp_actions";
            this.grp_actions.Size = new System.Drawing.Size(900, 60);
            this.grp_actions.TabIndex = 0;
            this.grp_actions.TabStop = false;
            // 
            // btn_categoryRefresh
            // 
            this.btn_categoryRefresh.Location = new System.Drawing.Point(312, 20);
            this.btn_categoryRefresh.Name = "btn_categoryRefresh";
            this.btn_categoryRefresh.Size = new System.Drawing.Size(90, 30);
            this.btn_categoryRefresh.TabIndex = 3;
            this.btn_categoryRefresh.Text = "Làm mới";
            this.btn_categoryRefresh.UseVisualStyleBackColor = true;
            this.btn_categoryRefresh.Click += new System.EventHandler(this.btn_categoryRefresh_Click);
            // 
            // btn_categoryDelete
            // 
            this.btn_categoryDelete.Location = new System.Drawing.Point(216, 20);
            this.btn_categoryDelete.Name = "btn_categoryDelete";
            this.btn_categoryDelete.Size = new System.Drawing.Size(90, 30);
            this.btn_categoryDelete.TabIndex = 2;
            this.btn_categoryDelete.Text = "Xóa";
            this.btn_categoryDelete.UseVisualStyleBackColor = true;
            this.btn_categoryDelete.Click += new System.EventHandler(this.btn_categoryDelete_Click);
            // 
            // btn_categoryEdit
            // 
            this.btn_categoryEdit.Location = new System.Drawing.Point(120, 20);
            this.btn_categoryEdit.Name = "btn_categoryEdit";
            this.btn_categoryEdit.Size = new System.Drawing.Size(90, 30);
            this.btn_categoryEdit.TabIndex = 1;
            this.btn_categoryEdit.Text = "Sửa";
            this.btn_categoryEdit.UseVisualStyleBackColor = true;
            this.btn_categoryEdit.Click += new System.EventHandler(this.btn_categoryEdit_Click);
            // 
            // btn_categoryAdd
            // 
            this.btn_categoryAdd.Location = new System.Drawing.Point(24, 20);
            this.btn_categoryAdd.Name = "btn_categoryAdd";
            this.btn_categoryAdd.Size = new System.Drawing.Size(90, 30);
            this.btn_categoryAdd.TabIndex = 0;
            this.btn_categoryAdd.Text = "+ Thêm";
            this.btn_categoryAdd.UseVisualStyleBackColor = true;
            this.btn_categoryAdd.Click += new System.EventHandler(this.btn_categoryAdd_Click);
            // 
            // grp_status
            // 
            this.grp_status.Controls.Add(this.lbl_statusSummary);
            this.grp_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.grp_status.Location = new System.Drawing.Point(0, 460);
            this.grp_status.Name = "grp_status";
            this.grp_status.Size = new System.Drawing.Size(900, 40);
            this.grp_status.TabIndex = 1;
            this.grp_status.TabStop = false;
            // 
            // lbl_statusSummary
            // 
            this.lbl_statusSummary.AutoSize = true;
            this.lbl_statusSummary.Location = new System.Drawing.Point(12, 16);
            this.lbl_statusSummary.Name = "lbl_statusSummary";
            this.lbl_statusSummary.Size = new System.Drawing.Size(209, 15);
            this.lbl_statusSummary.TabIndex = 0;
            this.lbl_statusSummary.Text = "Tổng: 0 danh mục | Đang chọn: Không";
            // 
            // grp_categoryDetails
            // 
            this.grp_categoryDetails.Controls.Add(this.btn_categoryCancel);
            this.grp_categoryDetails.Controls.Add(this.btn_categorySave);
            this.grp_categoryDetails.Controls.Add(this.cbb_categoryStatus);
            this.grp_categoryDetails.Controls.Add(this.lbl_categoryStatus);
            this.grp_categoryDetails.Controls.Add(this.txt_categoryDesc);
            this.grp_categoryDetails.Controls.Add(this.lbl_categoryDesc);
            this.grp_categoryDetails.Controls.Add(this.txt_categoryName);
            this.grp_categoryDetails.Controls.Add(this.lbl_categoryName);
            this.grp_categoryDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.grp_categoryDetails.Location = new System.Drawing.Point(600, 60);
            this.grp_categoryDetails.Name = "grp_categoryDetails";
            this.grp_categoryDetails.Size = new System.Drawing.Size(300, 400);
            this.grp_categoryDetails.TabIndex = 2;
            this.grp_categoryDetails.TabStop = false;
            this.grp_categoryDetails.Text = "Thông tin danh mục";
            // 
            // btn_categoryCancel
            // 
            this.btn_categoryCancel.Location = new System.Drawing.Point(160, 240);
            this.btn_categoryCancel.Name = "btn_categoryCancel";
            this.btn_categoryCancel.Size = new System.Drawing.Size(100, 30);
            this.btn_categoryCancel.TabIndex = 7;
            this.btn_categoryCancel.Text = "Hủy";
            this.btn_categoryCancel.UseVisualStyleBackColor = true;
            this.btn_categoryCancel.Click += new System.EventHandler(this.btn_categoryCancel_Click);
            // 
            // btn_categorySave
            // 
            this.btn_categorySave.Location = new System.Drawing.Point(40, 240);
            this.btn_categorySave.Name = "btn_categorySave";
            this.btn_categorySave.Size = new System.Drawing.Size(100, 30);
            this.btn_categorySave.TabIndex = 6;
            this.btn_categorySave.Text = "Lưu";
            this.btn_categorySave.UseVisualStyleBackColor = true;
            this.btn_categorySave.Click += new System.EventHandler(this.btn_categorySave_Click);
            // 
            // cbb_categoryStatus
            // 
            this.cbb_categoryStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_categoryStatus.FormattingEnabled = true;
            this.cbb_categoryStatus.Location = new System.Drawing.Point(20, 180);
            this.cbb_categoryStatus.Name = "cbb_categoryStatus";
            this.cbb_categoryStatus.Size = new System.Drawing.Size(260, 23);
            this.cbb_categoryStatus.TabIndex = 5;
            // 
            // lbl_categoryStatus
            // 
            this.lbl_categoryStatus.AutoSize = true;
            this.lbl_categoryStatus.Location = new System.Drawing.Point(17, 162);
            this.lbl_categoryStatus.Name = "lbl_categoryStatus";
            this.lbl_categoryStatus.Size = new System.Drawing.Size(62, 15);
            this.lbl_categoryStatus.TabIndex = 4;
            this.lbl_categoryStatus.Text = "Trạng thái:";
            // 
            // txt_categoryDesc
            // 
            this.txt_categoryDesc.Location = new System.Drawing.Point(20, 100);
            this.txt_categoryDesc.Multiline = true;
            this.txt_categoryDesc.Name = "txt_categoryDesc";
            this.txt_categoryDesc.Size = new System.Drawing.Size(260, 50);
            this.txt_categoryDesc.TabIndex = 3;
            // 
            // lbl_categoryDesc
            // 
            this.lbl_categoryDesc.AutoSize = true;
            this.lbl_categoryDesc.Location = new System.Drawing.Point(17, 82);
            this.lbl_categoryDesc.Name = "lbl_categoryDesc";
            this.lbl_categoryDesc.Size = new System.Drawing.Size(41, 15);
            this.lbl_categoryDesc.TabIndex = 2;
            this.lbl_categoryDesc.Text = "Mô tả:";
            // 
            // txt_categoryName
            // 
            this.txt_categoryName.Location = new System.Drawing.Point(20, 48);
            this.txt_categoryName.Name = "txt_categoryName";
            this.txt_categoryName.Size = new System.Drawing.Size(260, 23);
            this.txt_categoryName.TabIndex = 1;
            // 
            // lbl_categoryName
            // 
            this.lbl_categoryName.AutoSize = true;
            this.lbl_categoryName.Location = new System.Drawing.Point(17, 30);
            this.lbl_categoryName.Name = "lbl_categoryName";
            this.lbl_categoryName.Size = new System.Drawing.Size(92, 15);
            this.lbl_categoryName.TabIndex = 0;
            this.lbl_categoryName.Text = "Tên danh mục *:";
            // 
            // grp_categoryList
            // 
            this.grp_categoryList.Controls.Add(this.dgv_listCategory);
            this.grp_categoryList.Controls.Add(this.txt_categorySearch);
            this.grp_categoryList.Controls.Add(this.lbl_searchTitle);
            this.grp_categoryList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_categoryList.Location = new System.Drawing.Point(0, 60);
            this.grp_categoryList.Name = "grp_categoryList";
            this.grp_categoryList.Padding = new System.Windows.Forms.Padding(10);
            this.grp_categoryList.Size = new System.Drawing.Size(600, 400);
            this.grp_categoryList.TabIndex = 3;
            this.grp_categoryList.TabStop = false;
            this.grp_categoryList.Text = "Danh sách danh mục";
            // 
            // dgv_listCategory
            // 
            this.dgv_listCategory.AllowUserToAddRows = false;
            this.dgv_listCategory.AllowUserToDeleteRows = false;
            this.dgv_listCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_listCategory.BackgroundColor = System.Drawing.Color.White;
            this.dgv_listCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_listCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_listCategory.Location = new System.Drawing.Point(10, 68);
            this.dgv_listCategory.Name = "dgv_listCategory";
            this.dgv_listCategory.ReadOnly = true;
            this.dgv_listCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_listCategory.Size = new System.Drawing.Size(580, 322);
            this.dgv_listCategory.TabIndex = 2;
            this.dgv_listCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_listCategory_CellClick);
            this.dgv_listCategory.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_listCategory_CellFormatting);
            // 
            // txt_categorySearch
            // 
            this.txt_categorySearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_categorySearch.Location = new System.Drawing.Point(10, 45);
            this.txt_categorySearch.Name = "txt_categorySearch";
            this.txt_categorySearch.Size = new System.Drawing.Size(580, 23);
            this.txt_categorySearch.TabIndex = 1;
            this.txt_categorySearch.TextChanged += new System.EventHandler(this.txt_categorySearch_TextChanged);
            this.txt_categorySearch.Enter += new System.EventHandler(this.txt_categorySearch_Enter);
            this.txt_categorySearch.Leave += new System.EventHandler(this.txt_categorySearch_Leave);
            // 
            // lbl_searchTitle
            // 
            this.lbl_searchTitle.AutoSize = true;
            this.lbl_searchTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_searchTitle.Location = new System.Drawing.Point(10, 26);
            this.lbl_searchTitle.Name = "lbl_searchTitle";
            this.lbl_searchTitle.Padding = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lbl_searchTitle.Size = new System.Drawing.Size(115, 19);
            this.lbl_searchTitle.TabIndex = 0;
            this.lbl_searchTitle.Text = "Tìm kiếm danh mục:";
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.grp_categoryList);
            this.Controls.Add(this.grp_categoryDetails);
            this.Controls.Add(this.grp_status);
            this.Controls.Add(this.grp_actions);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCategory";
            this.Text = "Quản lý danh mục sản phẩm";
            this.Load += new System.EventHandler(this.FormCategory_Load);
            this.grp_actions.ResumeLayout(false);
            this.grp_status.ResumeLayout(false);
            this.grp_status.PerformLayout();
            this.grp_categoryDetails.ResumeLayout(false);
            this.grp_categoryDetails.PerformLayout();
            this.grp_categoryList.ResumeLayout(false);
            this.grp_categoryList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_listCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_actions;
        private System.Windows.Forms.Button btn_categoryRefresh;
        private System.Windows.Forms.Button btn_categoryDelete;
        private System.Windows.Forms.Button btn_categoryEdit;
        private System.Windows.Forms.Button btn_categoryAdd;
        private System.Windows.Forms.GroupBox grp_status;
        private System.Windows.Forms.Label lbl_statusSummary;
        private System.Windows.Forms.GroupBox grp_categoryDetails;
        private System.Windows.Forms.GroupBox grp_categoryList;
        private System.Windows.Forms.TextBox txt_categoryName;
        private System.Windows.Forms.Label lbl_categoryName;
        private System.Windows.Forms.TextBox txt_categoryDesc;
        private System.Windows.Forms.Label lbl_categoryDesc;
        private System.Windows.Forms.ComboBox cbb_categoryStatus;
        private System.Windows.Forms.Label lbl_categoryStatus;
        private System.Windows.Forms.Button btn_categoryCancel;
        private System.Windows.Forms.Button btn_categorySave;
        private System.Windows.Forms.Label lbl_searchTitle;
        private System.Windows.Forms.TextBox txt_categorySearch;
        private System.Windows.Forms.DataGridView dgv_listCategory;
    }
}