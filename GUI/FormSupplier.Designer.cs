namespace GUI
{
    partial class FormSupplier
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            pnl_header = new System.Windows.Forms.Panel();
            btn_refresh = new System.Windows.Forms.Button();
            btn_delete = new System.Windows.Forms.Button();
            btn_edit = new System.Windows.Forms.Button();
            btn_add = new System.Windows.Forms.Button();
            pnl_status = new System.Windows.Forms.Panel();
            lbl_totalSuppliers = new System.Windows.Forms.Label();
            lbl_totalDebt = new System.Windows.Forms.Label();
            pnl_left = new System.Windows.Forms.Panel();
            dgv_suppliers = new System.Windows.Forms.DataGridView();
            pnl_details = new System.Windows.Forms.Panel();
            btn_cancel = new System.Windows.Forms.Button();
            btn_save = new System.Windows.Forms.Button();
            txt_debt = new System.Windows.Forms.TextBox();
            lbl_debt = new System.Windows.Forms.Label();
            txt_address = new System.Windows.Forms.TextBox();
            lbl_address = new System.Windows.Forms.Label();
            txt_phone = new System.Windows.Forms.TextBox();
            lbl_phone = new System.Windows.Forms.Label();
            txt_supplierName = new System.Windows.Forms.TextBox();
            lbl_supplierName = new System.Windows.Forms.Label();
            lbl_infoTitle = new System.Windows.Forms.Label();

            pnl_header.SuspendLayout();
            pnl_status.SuspendLayout();
            pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).BeginInit();
            pnl_details.SuspendLayout();
            SuspendLayout();

            // 
            // pnl_header
            // 
            pnl_header.Controls.Add(btn_refresh);
            pnl_header.Controls.Add(btn_delete);
            pnl_header.Controls.Add(btn_edit);
            pnl_header.Controls.Add(btn_add);
            pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            pnl_header.Location = new System.Drawing.Point(0, 0);
            pnl_header.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_header.Name = "pnl_header";
            pnl_header.Size = new System.Drawing.Size(1587, 102);
            pnl_header.TabIndex = 0;
            // 
            // btn_add
            // 
            btn_add.Location = new System.Drawing.Point(12, 12);
            btn_add.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_add.Name = "btn_add";
            btn_add.Size = new System.Drawing.Size(375, 63);
            btn_add.TabIndex = 0;
            btn_add.Text = "➕ Thêm NCC";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_edit
            // 
            btn_edit.Location = new System.Drawing.Point(393, 12);
            btn_edit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_edit.Name = "btn_edit";
            btn_edit.Size = new System.Drawing.Size(402, 63);
            btn_edit.TabIndex = 1;
            btn_edit.Text = "✏️ Sửa";
            btn_edit.UseVisualStyleBackColor = true;
            btn_edit.Click += btn_edit_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new System.Drawing.Point(801, 12);
            btn_delete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new System.Drawing.Size(421, 63);
            btn_delete.TabIndex = 2;
            btn_delete.Text = "🗑️ Xóa";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new System.Drawing.Point(1228, 12);
            btn_refresh.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new System.Drawing.Size(347, 63);
            btn_refresh.TabIndex = 3;
            btn_refresh.Text = "🔄 Làm mới";
            btn_refresh.UseVisualStyleBackColor = true;
            btn_refresh.Click += btn_refresh_Click;
            // 
            // pnl_status
            // 
            pnl_status.Controls.Add(lbl_totalDebt);
            pnl_status.Controls.Add(lbl_totalSuppliers);
            pnl_status.Dock = System.Windows.Forms.DockStyle.Bottom;
            pnl_status.Location = new System.Drawing.Point(0, 848);
            pnl_status.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_status.Name = "pnl_status";
            pnl_status.Size = new System.Drawing.Size(1587, 102);
            pnl_status.TabIndex = 1;
            // 
            // lbl_totalSuppliers
            // 
            lbl_totalSuppliers.AutoSize = true;
            lbl_totalSuppliers.Location = new System.Drawing.Point(26, 30);
            lbl_totalSuppliers.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_totalSuppliers.Name = "lbl_totalSuppliers";
            lbl_totalSuppliers.Size = new System.Drawing.Size(300, 41);
            lbl_totalSuppliers.TabIndex = 0;
            lbl_totalSuppliers.Text = "Tổng NCC: 0";
            // 
            // lbl_totalDebt
            // 
            lbl_totalDebt.AutoSize = true;
            lbl_totalDebt.Location = new System.Drawing.Point(750, 30);
            lbl_totalDebt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            lbl_totalDebt.Name = "lbl_totalDebt";
            lbl_totalDebt.Size = new System.Drawing.Size(300, 41);
            lbl_totalDebt.TabIndex = 1;
            lbl_totalDebt.Text = "Tổng công nợ: 0đ";
            // 
            // pnl_left
            // 
            pnl_left.Controls.Add(dgv_suppliers);
            pnl_left.Dock = System.Windows.Forms.DockStyle.Left;
            pnl_left.Location = new System.Drawing.Point(0, 102);
            pnl_left.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_left.Name = "pnl_left";
            pnl_left.Size = new System.Drawing.Size(640, 746);
            pnl_left.TabIndex = 2;
            // 
            // dgv_suppliers
            // 
            dgv_suppliers.ColumnHeadersHeight = 58;
            dgv_suppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv_suppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            dgv_suppliers.Location = new System.Drawing.Point(0, 0);
            dgv_suppliers.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            dgv_suppliers.Name = "dgv_suppliers";
            dgv_suppliers.RowHeadersWidth = 102;
            dgv_suppliers.Size = new System.Drawing.Size(640, 746);
            dgv_suppliers.TabIndex = 0;
            dgv_suppliers.CellClick += dgv_suppliers_CellClick;
            // 
            // pnl_details
            // 
            pnl_details.Controls.Add(btn_cancel);
            pnl_details.Controls.Add(btn_save);
            pnl_details.Controls.Add(txt_debt);
            pnl_details.Controls.Add(lbl_debt);
            pnl_details.Controls.Add(txt_address);
            pnl_details.Controls.Add(lbl_address);
            pnl_details.Controls.Add(txt_phone);
            pnl_details.Controls.Add(lbl_phone);
            pnl_details.Controls.Add(txt_supplierName);
            pnl_details.Controls.Add(lbl_supplierName);
            pnl_details.Controls.Add(lbl_infoTitle);
            pnl_details.Dock = System.Windows.Forms.DockStyle.Fill;
            pnl_details.Location = new System.Drawing.Point(640, 102);
            pnl_details.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            pnl_details.Name = "pnl_details";
            pnl_details.Padding = new System.Windows.Forms.Padding(6);
            pnl_details.Size = new System.Drawing.Size(947, 746);
            pnl_details.TabIndex = 3;
            // 
            // lbl_infoTitle
            // 
            lbl_infoTitle.Location = new System.Drawing.Point(6, 12);
            lbl_infoTitle.Name = "lbl_infoTitle";
            lbl_infoTitle.Size = new System.Drawing.Size(935, 46);
            lbl_infoTitle.TabIndex = 0;
            lbl_infoTitle.Text = "📋 Thông tin nhà cung cấp";
            lbl_infoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            // 
            // lbl_supplierName
            // 
            lbl_supplierName.Location = new System.Drawing.Point(6, 73);
            lbl_supplierName.Name = "lbl_supplierName";
            lbl_supplierName.Size = new System.Drawing.Size(314, 46);
            lbl_supplierName.TabIndex = 1;
            lbl_supplierName.Text = "Tên NCC *:";
            // 
            // txt_supplierName
            // 
            txt_supplierName.Location = new System.Drawing.Point(6, 122);
            txt_supplierName.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_supplierName.Name = "txt_supplierName";
            txt_supplierName.Size = new System.Drawing.Size(929, 47);
            txt_supplierName.TabIndex = 2;
            // 
            // lbl_phone
            // 
            lbl_phone.Location = new System.Drawing.Point(6, 184);
            lbl_phone.Name = "lbl_phone";
            lbl_phone.Size = new System.Drawing.Size(314, 46);
            lbl_phone.TabIndex = 3;
            lbl_phone.Text = "Số điện thoại *:";
            // 
            // txt_phone
            // 
            txt_phone.Location = new System.Drawing.Point(6, 233);
            txt_phone.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new System.Drawing.Size(929, 47);
            txt_phone.TabIndex = 4;
            // 
            // lbl_address
            // 
            lbl_address.Location = new System.Drawing.Point(6, 295);
            lbl_address.Name = "lbl_address";
            lbl_address.Size = new System.Drawing.Size(314, 46);
            lbl_address.TabIndex = 5;
            lbl_address.Text = "Địa chỉ:";
            // 
            // txt_address
            // 
            txt_address.Location = new System.Drawing.Point(6, 344);
            txt_address.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_address.Name = "txt_address";
            txt_address.Size = new System.Drawing.Size(929, 47);
            txt_address.TabIndex = 6;
            // 
            // lbl_debt
            // 
            lbl_debt.Location = new System.Drawing.Point(6, 406);
            lbl_debt.Name = "lbl_debt";
            lbl_debt.Size = new System.Drawing.Size(314, 46);
            lbl_debt.TabIndex = 7;
            lbl_debt.Text = "Công nợ (đ):";
            // 
            // txt_debt
            // 
            txt_debt.Location = new System.Drawing.Point(6, 455);
            txt_debt.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            txt_debt.Name = "txt_debt";
            txt_debt.Size = new System.Drawing.Size(929, 47);
            txt_debt.TabIndex = 8;
            // 
            // btn_save
            // 
            btn_save.Location = new System.Drawing.Point(6, 635);
            btn_save.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_save.Name = "btn_save";
            btn_save.Size = new System.Drawing.Size(466, 64);
            btn_save.TabIndex = 9;
            btn_save.Text = "💾 Lưu";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new System.Drawing.Point(478, 635);
            btn_cancel.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(457, 64);
            btn_cancel.TabIndex = 10;
            btn_cancel.Text = "❌ Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // FormSupplier
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1587, 950);
            Controls.Add(pnl_details);
            Controls.Add(pnl_left);
            Controls.Add(pnl_status);
            Controls.Add(pnl_header);
            Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            Name = "FormSupplier";
            Text = "Quản lý nhà cung cấp";
            Load += FormSupplier_Load;

            pnl_header.ResumeLayout(false);
            pnl_status.ResumeLayout(false);
            pnl_status.PerformLayout();
            pnl_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_suppliers).EndInit();
            pnl_details.ResumeLayout(false);
            pnl_details.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Panel pnl_status;
        private System.Windows.Forms.Label lbl_totalSuppliers;
        private System.Windows.Forms.Label lbl_totalDebt;
        private System.Windows.Forms.Panel pnl_left;
        private System.Windows.Forms.DataGridView dgv_suppliers;
        private System.Windows.Forms.Panel pnl_details;
        private System.Windows.Forms.Label lbl_infoTitle;
        private System.Windows.Forms.Label lbl_supplierName;
        private System.Windows.Forms.TextBox txt_supplierName;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Label lbl_debt;
        private System.Windows.Forms.TextBox txt_debt;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}