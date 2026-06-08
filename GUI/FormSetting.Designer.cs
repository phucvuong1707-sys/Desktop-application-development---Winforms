namespace GUI
{
    partial class FormSetting
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
            gb_DatabaseConfig = new System.Windows.Forms.GroupBox();
            btn_saveDatabase = new System.Windows.Forms.Button();
            btn_testConnection = new System.Windows.Forms.Button();
            txt_password = new System.Windows.Forms.TextBox();
            lbl_Password = new System.Windows.Forms.Label();
            txt_user = new System.Windows.Forms.TextBox();
            lbl_User = new System.Windows.Forms.Label();
            txt_database = new System.Windows.Forms.TextBox();
            lbl_Database = new System.Windows.Forms.Label();
            txt_server = new System.Windows.Forms.TextBox();
            lbl_Server = new System.Windows.Forms.Label();
            gb_PrinterConfig = new System.Windows.Forms.GroupBox();
            btn_savePrinter = new System.Windows.Forms.Button();
            btn_printTest = new System.Windows.Forms.Button();
            cbb_paperSize = new System.Windows.Forms.ComboBox();
            lbl_PaperSize = new System.Windows.Forms.Label();
            cbb_printerList = new System.Windows.Forms.ComboBox();
            lbl_PrinterName = new System.Windows.Forms.Label();
            gb_DatabaseConfig.SuspendLayout();
            gb_PrinterConfig.SuspendLayout();
            SuspendLayout();
            // 
            // gb_DatabaseConfig
            // 
            gb_DatabaseConfig.Controls.Add(btn_saveDatabase);
            gb_DatabaseConfig.Controls.Add(btn_testConnection);
            gb_DatabaseConfig.Controls.Add(txt_password);
            gb_DatabaseConfig.Controls.Add(lbl_Password);
            gb_DatabaseConfig.Controls.Add(txt_user);
            gb_DatabaseConfig.Controls.Add(lbl_User);
            gb_DatabaseConfig.Controls.Add(txt_database);
            gb_DatabaseConfig.Controls.Add(lbl_Database);
            gb_DatabaseConfig.Controls.Add(txt_server);
            gb_DatabaseConfig.Controls.Add(lbl_Server);
            gb_DatabaseConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            gb_DatabaseConfig.Location = new System.Drawing.Point(12, 12);
            gb_DatabaseConfig.Name = "gb_DatabaseConfig";
            gb_DatabaseConfig.Size = new System.Drawing.Size(790, 789);
            gb_DatabaseConfig.TabIndex = 0;
            gb_DatabaseConfig.TabStop = false;
            gb_DatabaseConfig.Text = "Cấu Hình Chuỗi Kết Nối Máy Chủ";
            // 
            // btn_saveDatabase
            // 
            btn_saveDatabase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btn_saveDatabase.Location = new System.Drawing.Point(0, 660);
            btn_saveDatabase.Name = "btn_saveDatabase";
            btn_saveDatabase.Size = new System.Drawing.Size(778, 54);
            btn_saveDatabase.TabIndex = 6;
            btn_saveDatabase.Text = "Lưu Cấu Hình";
            btn_saveDatabase.UseVisualStyleBackColor = true;
            btn_saveDatabase.Click += btn_SaveDatabase_Click;
            // 
            // btn_testConnection
            // 
            btn_testConnection.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btn_testConnection.Location = new System.Drawing.Point(0, 553);
            btn_testConnection.Name = "btn_testConnection";
            btn_testConnection.Size = new System.Drawing.Size(778, 57);
            btn_testConnection.TabIndex = 5;
            btn_testConnection.Text = "Kiểm Tra Kết Nối";
            btn_testConnection.UseVisualStyleBackColor = true;
            btn_testConnection.Click += btn_TestConnection_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_password.Location = new System.Drawing.Point(235, 266);
            txt_password.Name = "txt_password";
            txt_password.PasswordChar = '*';
            txt_password.Size = new System.Drawing.Size(549, 50);
            txt_password.TabIndex = 4;
            // 
            // lbl_Password
            // 
            lbl_Password.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_Password.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_Password.Location = new System.Drawing.Point(6, 266);
            lbl_Password.Name = "lbl_Password";
            lbl_Password.Size = new System.Drawing.Size(212, 50);
            lbl_Password.TabIndex = 7;
            lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_user
            // 
            txt_user.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_user.Location = new System.Drawing.Point(235, 196);
            txt_user.Name = "txt_user";
            txt_user.Size = new System.Drawing.Size(549, 50);
            txt_user.TabIndex = 3;
            // 
            // lbl_User
            // 
            lbl_User.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_User.Location = new System.Drawing.Point(6, 196);
            lbl_User.Name = "lbl_User";
            lbl_User.Size = new System.Drawing.Size(223, 50);
            lbl_User.TabIndex = 8;
            lbl_User.Text = "Tài khoản:";
            // 
            // txt_database
            // 
            txt_database.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_database.Location = new System.Drawing.Point(235, 121);
            txt_database.Name = "txt_database";
            txt_database.Size = new System.Drawing.Size(549, 50);
            txt_database.TabIndex = 2;
            // 
            // lbl_Database
            // 
            lbl_Database.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_Database.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_Database.Location = new System.Drawing.Point(6, 121);
            lbl_Database.Name = "lbl_Database";
            lbl_Database.Size = new System.Drawing.Size(223, 50);
            lbl_Database.TabIndex = 9;
            lbl_Database.Text = "Cơ sở dữ liệu:";
            // 
            // txt_server
            // 
            txt_server.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            txt_server.Location = new System.Drawing.Point(238, 51);
            txt_server.Name = "txt_server";
            txt_server.Size = new System.Drawing.Size(546, 50);
            txt_server.TabIndex = 1;
            // 
            // lbl_Server
            // 
            lbl_Server.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_Server.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_Server.Location = new System.Drawing.Point(6, 48);
            lbl_Server.Name = "lbl_Server";
            lbl_Server.Size = new System.Drawing.Size(212, 51);
            lbl_Server.TabIndex = 10;
            lbl_Server.Text = "Tên máy chủ:";
            // 
            // gb_PrinterConfig
            // 
            gb_PrinterConfig.Controls.Add(btn_savePrinter);
            gb_PrinterConfig.Controls.Add(btn_printTest);
            gb_PrinterConfig.Controls.Add(cbb_paperSize);
            gb_PrinterConfig.Controls.Add(lbl_PaperSize);
            gb_PrinterConfig.Controls.Add(cbb_printerList);
            gb_PrinterConfig.Controls.Add(lbl_PrinterName);
            gb_PrinterConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            gb_PrinterConfig.Location = new System.Drawing.Point(808, 12);
            gb_PrinterConfig.Name = "gb_PrinterConfig";
            gb_PrinterConfig.Size = new System.Drawing.Size(752, 789);
            gb_PrinterConfig.TabIndex = 7;
            gb_PrinterConfig.TabStop = false;
            gb_PrinterConfig.Text = "Cấu Hình Máy In Hóa Đơn";
            // 
            // btn_savePrinter
            // 
            btn_savePrinter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            btn_savePrinter.Location = new System.Drawing.Point(6, 660);
            btn_savePrinter.Name = "btn_savePrinter";
            btn_savePrinter.Size = new System.Drawing.Size(740, 54);
            btn_savePrinter.TabIndex = 11;
            btn_savePrinter.Text = "Lưu Máy In";
            btn_savePrinter.UseVisualStyleBackColor = true;
            btn_savePrinter.Click += btn_SavePrinter_Click;
            // 
            // btn_printTest
            // 
            btn_printTest.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            btn_printTest.Location = new System.Drawing.Point(6, 553);
            btn_printTest.Name = "btn_printTest";
            btn_printTest.Size = new System.Drawing.Size(740, 57);
            btn_printTest.TabIndex = 10;
            btn_printTest.Text = "In Thử (Test)";
            btn_printTest.UseVisualStyleBackColor = true;
            btn_printTest.Click += btn_PrintTest_Click;
            // 
            // cbb_paperSize
            // 
            cbb_paperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_paperSize.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cbb_paperSize.Location = new System.Drawing.Point(6, 266);
            cbb_paperSize.Name = "cbb_paperSize";
            cbb_paperSize.Size = new System.Drawing.Size(740, 53);
            cbb_paperSize.TabIndex = 9;
            // 
            // lbl_PaperSize
            // 
            lbl_PaperSize.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_PaperSize.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_PaperSize.Location = new System.Drawing.Point(6, 199);
            lbl_PaperSize.Name = "lbl_PaperSize";
            lbl_PaperSize.Size = new System.Drawing.Size(220, 50);
            lbl_PaperSize.TabIndex = 12;
            lbl_PaperSize.Text = "Khổ giấy:";
            // 
            // cbb_printerList
            // 
            cbb_printerList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cbb_printerList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            cbb_printerList.Location = new System.Drawing.Point(6, 121);
            cbb_printerList.Name = "cbb_printerList";
            cbb_printerList.Size = new System.Drawing.Size(740, 53);
            cbb_printerList.TabIndex = 8;
            // 
            // lbl_PrinterName
            // 
            lbl_PrinterName.BackColor = System.Drawing.SystemColors.ControlLight;
            lbl_PrinterName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            lbl_PrinterName.Location = new System.Drawing.Point(6, 54);
            lbl_PrinterName.Name = "lbl_PrinterName";
            lbl_PrinterName.Size = new System.Drawing.Size(220, 50);
            lbl_PrinterName.TabIndex = 13;
            lbl_PrinterName.Text = "Chọn máy in:";
            // 
            // FormSetting
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(18F, 45F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1572, 813);
            Controls.Add(gb_PrinterConfig);
            Controls.Add(gb_DatabaseConfig);
            Font = new System.Drawing.Font("Segoe UI", 9.5F);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Phân Hệ Cấu Hình Hệ Thống - Quyền Admin (IT)";
            Load += FormSetting_Load;
            gb_DatabaseConfig.ResumeLayout(false);
            gb_DatabaseConfig.PerformLayout();
            gb_PrinterConfig.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DatabaseConfig;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.TextBox txt_server;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TextBox txt_database;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_testConnection;
        private System.Windows.Forms.Button btn_saveDatabase;

        private System.Windows.Forms.GroupBox gb_PrinterConfig;
        private System.Windows.Forms.Label lbl_PrinterName;
        private System.Windows.Forms.ComboBox cbb_printerList;
        private System.Windows.Forms.Label lbl_PaperSize;
        private System.Windows.Forms.ComboBox cbb_paperSize;
        private System.Windows.Forms.Button btn_printTest;
        private System.Windows.Forms.Button btn_savePrinter;
    }
}