namespace GUI
{
    partial class FormStaff
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grp_Actions = new GroupBox();
            btn_staffRefresh = new Button();
            btn_staffResetPass = new Button();
            btn_staffDisable = new Button();
            btn_staffEdit = new Button();
            btn_staffAdd = new Button();
            grp_StaffList = new GroupBox();
            dgv_staffList = new DataGridView();
            grp_StaffDetails = new GroupBox();
            btn_staffCancel = new Button();
            btn_staffSave = new Button();
            cbb_role = new ComboBox();
            lbl_Role = new Label();
            txt_phone = new TextBox();
            lbl_Phone = new Label();
            txt_password = new TextBox();
            lbl_Password = new Label();
            txt_username = new TextBox();
            lbl_Username = new Label();
            txt_fullName = new TextBox();
            lbl_FullName = new Label();
            lbl_SectionTitle = new Label();
            grp_Actions.SuspendLayout();
            grp_StaffList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_staffList).BeginInit();
            grp_StaffDetails.SuspendLayout();
            SuspendLayout();
            // 
            // grp_Actions
            // 
            grp_Actions.Controls.Add(btn_staffRefresh);
            grp_Actions.Controls.Add(btn_staffResetPass);
            grp_Actions.Controls.Add(btn_staffDisable);
            grp_Actions.Controls.Add(btn_staffEdit);
            grp_Actions.Controls.Add(btn_staffAdd);
            grp_Actions.Dock = DockStyle.Top;
            grp_Actions.Location = new Point(0, 0);
            grp_Actions.Margin = new Padding(7, 5, 7, 5);
            grp_Actions.Name = "grp_Actions";
            grp_Actions.Padding = new Padding(7, 5, 7, 5);
            grp_Actions.Size = new Size(2497, 142);
            grp_Actions.TabIndex = 0;
            grp_Actions.TabStop = false;
            grp_Actions.Text = "Thao tác nghiệp vụ";
            // 
            // btn_staffRefresh
            // 
            btn_staffRefresh.Location = new Point(957, 52);
            btn_staffRefresh.Margin = new Padding(7, 5, 7, 5);
            btn_staffRefresh.Name = "btn_staffRefresh";
            btn_staffRefresh.Size = new Size(214, 71);
            btn_staffRefresh.TabIndex = 0;
            btn_staffRefresh.Text = "Làm mới";
            btn_staffRefresh.UseVisualStyleBackColor = true;
            // 
            // btn_staffResetPass
            // 
            btn_staffResetPass.Location = new Point(724, 52);
            btn_staffResetPass.Margin = new Padding(7, 5, 7, 5);
            btn_staffResetPass.Name = "btn_staffResetPass";
            btn_staffResetPass.Size = new Size(214, 71);
            btn_staffResetPass.TabIndex = 1;
            btn_staffResetPass.Text = "Cấp lại MK";
            btn_staffResetPass.UseVisualStyleBackColor = true;
            // 
            // btn_staffDisable
            // 
            btn_staffDisable.Location = new Point(488, 52);
            btn_staffDisable.Margin = new Padding(7, 5, 7, 5);
            btn_staffDisable.Name = "btn_staffDisable";
            btn_staffDisable.Size = new Size(214, 71);
            btn_staffDisable.TabIndex = 2;
            btn_staffDisable.Text = "Khóa";
            btn_staffDisable.UseVisualStyleBackColor = true;
            // 
            // btn_staffEdit
            // 
            btn_staffEdit.Location = new Point(255, 52);
            btn_staffEdit.Margin = new Padding(7, 5, 7, 5);
            btn_staffEdit.Name = "btn_staffEdit";
            btn_staffEdit.Size = new Size(214, 71);
            btn_staffEdit.TabIndex = 3;
            btn_staffEdit.Text = "Sửa";
            btn_staffEdit.UseVisualStyleBackColor = true;
            // 
            // btn_staffAdd
            // 
            btn_staffAdd.Location = new Point(22, 52);
            btn_staffAdd.Margin = new Padding(7, 5, 7, 5);
            btn_staffAdd.Name = "btn_staffAdd";
            btn_staffAdd.Size = new Size(214, 71);
            btn_staffAdd.TabIndex = 4;
            btn_staffAdd.Text = "Thêm";
            btn_staffAdd.UseVisualStyleBackColor = true;
            // 
            // grp_StaffList
            // 
            grp_StaffList.Controls.Add(dgv_staffList);
            grp_StaffList.Dock = DockStyle.Left;
            grp_StaffList.Location = new Point(0, 142);
            grp_StaffList.Margin = new Padding(7, 5, 7, 5);
            grp_StaffList.Name = "grp_StaffList";
            grp_StaffList.Padding = new Padding(7, 5, 7, 5);
            grp_StaffList.Size = new Size(1486, 1293);
            grp_StaffList.TabIndex = 1;
            grp_StaffList.TabStop = false;
            grp_StaffList.Text = "Danh sách nhân sự";
            // 
            // dgv_staffList
            // 
            dgv_staffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_staffList.Dock = DockStyle.Fill;
            dgv_staffList.Location = new Point(7, 45);
            dgv_staffList.Margin = new Padding(7, 5, 7, 5);
            dgv_staffList.Name = "dgv_staffList";
            dgv_staffList.RowHeadersWidth = 102;
            dgv_staffList.Size = new Size(1472, 1243);
            dgv_staffList.TabIndex = 0;
            dgv_staffList.CellClick += dgv_staffList_CellClick;
            // 
            // grp_StaffDetails
            // 
            grp_StaffDetails.Controls.Add(btn_staffCancel);
            grp_StaffDetails.Controls.Add(btn_staffSave);
            grp_StaffDetails.Controls.Add(cbb_role);
            grp_StaffDetails.Controls.Add(lbl_Role);
            grp_StaffDetails.Controls.Add(txt_phone);
            grp_StaffDetails.Controls.Add(lbl_Phone);
            grp_StaffDetails.Controls.Add(txt_password);
            grp_StaffDetails.Controls.Add(lbl_Password);
            grp_StaffDetails.Controls.Add(txt_username);
            grp_StaffDetails.Controls.Add(lbl_Username);
            grp_StaffDetails.Controls.Add(txt_fullName);
            grp_StaffDetails.Controls.Add(lbl_FullName);
            grp_StaffDetails.Controls.Add(lbl_SectionTitle);
            grp_StaffDetails.Dock = DockStyle.Fill;
            grp_StaffDetails.Location = new Point(1486, 142);
            grp_StaffDetails.Margin = new Padding(7, 5, 7, 5);
            grp_StaffDetails.Name = "grp_StaffDetails";
            grp_StaffDetails.Padding = new Padding(7, 5, 7, 5);
            grp_StaffDetails.Size = new Size(1011, 1293);
            grp_StaffDetails.TabIndex = 2;
            grp_StaffDetails.TabStop = false;
            // 
            // btn_staffCancel
            // 
            btn_staffCancel.Location = new Point(787, 924);
            btn_staffCancel.Margin = new Padding(7, 5, 7, 5);
            btn_staffCancel.Name = "btn_staffCancel";
            btn_staffCancel.Size = new Size(214, 82);
            btn_staffCancel.TabIndex = 0;
            btn_staffCancel.Text = "Hủy";
            btn_staffCancel.UseVisualStyleBackColor = true;
            // 
            // btn_staffSave
            // 
            btn_staffSave.Location = new Point(554, 924);
            btn_staffSave.Margin = new Padding(7, 5, 7, 5);
            btn_staffSave.Name = "btn_staffSave";
            btn_staffSave.Size = new Size(214, 82);
            btn_staffSave.TabIndex = 1;
            btn_staffSave.Text = "Lưu";
            btn_staffSave.UseVisualStyleBackColor = true;
            // 
            // cbb_role
            // 
            cbb_role.FormattingEnabled = true;
            cbb_role.Items.AddRange(new object[] { "Admin", "Quản lý", "Thu ngân", "Kho", "Kỹ thuật", "Nhân viên" });
            cbb_role.Location = new Point(44, 790);
            cbb_role.Margin = new Padding(7, 5, 7, 5);
            cbb_role.Name = "cbb_role";
            cbb_role.Size = new Size(951, 49);
            cbb_role.TabIndex = 2;
            // 
            // lbl_Role
            // 
            lbl_Role.AutoSize = true;
            lbl_Role.Location = new Point(44, 738);
            lbl_Role.Margin = new Padding(7, 0, 7, 0);
            lbl_Role.Name = "lbl_Role";
            lbl_Role.Size = new Size(246, 41);
            lbl_Role.TabIndex = 3;
            lbl_Role.Text = "Chức vụ (Quyền):";
            // 
            // txt_phone
            // 
            txt_phone.Location = new Point(44, 645);
            txt_phone.Margin = new Padding(7, 5, 7, 5);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(951, 47);
            txt_phone.TabIndex = 4;
            // 
            // lbl_Phone
            // 
            lbl_Phone.AutoSize = true;
            lbl_Phone.Location = new Point(44, 596);
            lbl_Phone.Margin = new Padding(7, 0, 7, 0);
            lbl_Phone.Name = "lbl_Phone";
            lbl_Phone.Size = new Size(200, 41);
            lbl_Phone.TabIndex = 5;
            lbl_Phone.Text = "Số điện thoại:";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(44, 503);
            txt_password.Margin = new Padding(7, 5, 7, 5);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(951, 47);
            txt_password.TabIndex = 6;
            txt_password.UseSystemPasswordChar = true;
            // 
            // lbl_Password
            // 
            lbl_Password.AutoSize = true;
            lbl_Password.Location = new Point(44, 451);
            lbl_Password.Margin = new Padding(7, 0, 7, 0);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new Size(149, 41);
            lbl_Password.TabIndex = 7;
            lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(44, 358);
            txt_username.Margin = new Padding(7, 5, 7, 5);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(951, 47);
            txt_username.TabIndex = 8;
            // 
            // lbl_Username
            // 
            lbl_Username.AutoSize = true;
            lbl_Username.Location = new Point(44, 306);
            lbl_Username.Margin = new Padding(7, 0, 7, 0);
            lbl_Username.Name = "lbl_Username";
            lbl_Username.Size = new Size(222, 41);
            lbl_Username.TabIndex = 9;
            lbl_Username.Text = "Tên đăng nhập:";
            // 
            // txt_fullName
            // 
            txt_fullName.Location = new Point(44, 216);
            txt_fullName.Margin = new Padding(7, 5, 7, 5);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(951, 47);
            txt_fullName.TabIndex = 10;
            // 
            // lbl_FullName
            // 
            lbl_FullName.AutoSize = true;
            lbl_FullName.Location = new Point(44, 164);
            lbl_FullName.Margin = new Padding(7, 0, 7, 0);
            lbl_FullName.Name = "lbl_FullName";
            lbl_FullName.Size = new Size(152, 41);
            lbl_FullName.TabIndex = 11;
            lbl_FullName.Text = "Họ và tên:";
            // 
            // lbl_SectionTitle
            // 
            lbl_SectionTitle.AutoSize = true;
            lbl_SectionTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lbl_SectionTitle.Location = new Point(44, 60);
            lbl_SectionTitle.Margin = new Padding(7, 0, 7, 0);
            lbl_SectionTitle.Name = "lbl_SectionTitle";
            lbl_SectionTitle.Size = new Size(484, 54);
            lbl_SectionTitle.TabIndex = 12;
            lbl_SectionTitle.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // FormStaff
            //
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2497, 1435);
            Controls.Add(grp_StaffDetails);
            Controls.Add(grp_StaffList);
            Controls.Add(grp_Actions);
            Margin = new Padding(7, 5, 7, 5);
            Name = "FormStaff";
            Text = "Quản lý nhân sự";
            Load += FormStaff_Load;
            grp_Actions.ResumeLayout(false);
            grp_StaffList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_staffList).EndInit();
            grp_StaffDetails.ResumeLayout(false);
            grp_StaffDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grp_Actions;
        private System.Windows.Forms.Button btn_staffAdd;
        private System.Windows.Forms.Button btn_staffEdit;
        private System.Windows.Forms.Button btn_staffDisable;
        private System.Windows.Forms.Button btn_staffResetPass;
        private System.Windows.Forms.Button btn_staffRefresh;

        private System.Windows.Forms.GroupBox grp_StaffList;
        private System.Windows.Forms.DataGridView dgv_staffList;

        private System.Windows.Forms.GroupBox grp_StaffDetails;
        private System.Windows.Forms.Label lbl_SectionTitle;
        private System.Windows.Forms.Label lbl_FullName;
        private System.Windows.Forms.TextBox txt_fullName;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Label lbl_Phone;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.ComboBox cbb_role;
        private System.Windows.Forms.Button btn_staffSave;
        private System.Windows.Forms.Button btn_staffCancel;
    }
}