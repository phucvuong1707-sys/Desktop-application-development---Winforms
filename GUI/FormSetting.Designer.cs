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

        private void InitializeComponent()
        {
            this.gb_DatabaseConfig = new System.Windows.Forms.GroupBox();
            this.lbl_Server = new System.Windows.Forms.Label();
            this.txt_Server = new System.Windows.Forms.TextBox();
            this.lbl_Database = new System.Windows.Forms.Label();
            this.txt_Database = new System.Windows.Forms.TextBox();
            this.lbl_User = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_TestConnection = new System.Windows.Forms.Button();
            this.btn_SaveDatabase = new System.Windows.Forms.Button();

            this.gb_PrinterConfig = new System.Windows.Forms.GroupBox();
            this.lbl_PrinterName = new System.Windows.Forms.Label();
            this.cb_PrinterList = new System.Windows.Forms.ComboBox();
            this.lbl_PaperSize = new System.Windows.Forms.Label();
            this.cb_PaperSize = new System.Windows.Forms.ComboBox();
            this.btn_PrintTest = new System.Windows.Forms.Button();
            this.btn_SavePrinter = new System.Windows.Forms.Button();

            this.gb_DatabaseConfig.SuspendLayout();
            this.gb_PrinterConfig.SuspendLayout();
            this.SuspendLayout();

            // 
            // gb_DatabaseConfig
            // 
            this.gb_DatabaseConfig.Controls.Add(this.btn_SaveDatabase);
            this.gb_DatabaseConfig.Controls.Add(this.btn_TestConnection);
            this.gb_DatabaseConfig.Controls.Add(this.txt_Password);
            this.gb_DatabaseConfig.Controls.Add(this.lbl_Password);
            this.gb_DatabaseConfig.Controls.Add(this.txt_User);
            this.gb_DatabaseConfig.Controls.Add(this.lbl_User);
            this.gb_DatabaseConfig.Controls.Add(this.txt_Database);
            this.gb_DatabaseConfig.Controls.Add(this.lbl_Database);
            this.gb_DatabaseConfig.Controls.Add(this.txt_Server);
            this.gb_DatabaseConfig.Controls.Add(this.lbl_Server);
            this.gb_DatabaseConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gb_DatabaseConfig.Location = new System.Drawing.Point(12, 12);
            this.gb_DatabaseConfig.Name = "gb_DatabaseConfig";
            this.gb_DatabaseConfig.Size = new System.Drawing.Size(360, 320);
            this.gb_DatabaseConfig.TabIndex = 0;
            this.gb_DatabaseConfig.TabStop = false;
            this.gb_DatabaseConfig.Text = "Cấu Hình Chuỗi Kết Nối Máy Chủ";
            // 
            // lbl_Server
            // 
            this.lbl_Server.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbl_Server.Location = new System.Drawing.Point(15, 35);
            this.lbl_Server.Name = "lbl_Server";
            this.lbl_Server.Size = new System.Drawing.Size(100, 25);
            this.lbl_Server.Text = "Tên máy chủ:";
            // 
            // txt_Server
            // 
            this.txt_Server.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Server.Location = new System.Drawing.Point(120, 32);
            this.txt_Server.Name = "txt_Server";
            this.txt_Server.Size = new System.Drawing.Size(220, 29);
            this.txt_Server.TabIndex = 1;
            // 
            // lbl_Database
            // 
            this.lbl_Database.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbl_Database.Location = new System.Drawing.Point(15, 80);
            this.lbl_Database.Name = "lbl_Database";
            this.lbl_Database.Size = new System.Drawing.Size(100, 25);
            this.lbl_Database.Text = "Cơ sở dữ liệu:";
            // 
            // txt_Database
            // 
            this.txt_Database.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Database.Location = new System.Drawing.Point(120, 77);
            this.txt_Database.Name = "txt_Database";
            this.txt_Database.Size = new System.Drawing.Size(220, 29);
            this.txt_Database.TabIndex = 2;
            // 
            // lbl_User
            // 
            this.lbl_User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbl_User.Location = new System.Drawing.Point(15, 125);
            this.lbl_User.Name = "lbl_User";
            this.lbl_User.Size = new System.Drawing.Size(100, 25);
            this.lbl_User.Text = "Tài khoản:";
            // 
            // txt_User
            // 
            this.txt_User.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_User.Location = new System.Drawing.Point(120, 122);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(220, 29);
            this.txt_User.TabIndex = 3;
            // 
            // lbl_Password
            // 
            this.lbl_Password.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbl_Password.Location = new System.Drawing.Point(15, 170);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(100, 25);
            this.lbl_Password.Text = "Mật khẩu:";
            // 
            // txt_Password
            // 
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Password.Location = new System.Drawing.Point(120, 167);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(220, 29);
            this.txt_Password.TabIndex = 4;
            // 
            // btn_TestConnection
            // 
            this.btn_TestConnection.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_TestConnection.Location = new System.Drawing.Point(20, 240);
            this.btn_TestConnection.Name = "btn_TestConnection";
            this.btn_TestConnection.Size = new System.Drawing.Size(140, 40);
            this.btn_TestConnection.TabIndex = 5;
            this.btn_TestConnection.Text = "Kiểm Tra Kết Nối";
            this.btn_TestConnection.UseVisualStyleBackColor = true;
            this.btn_TestConnection.Click += new System.EventHandler(this.btn_TestConnection_Click);
            // 
            // btn_SaveDatabase
            // 
            this.btn_SaveDatabase.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_SaveDatabase.Location = new System.Drawing.Point(200, 240);
            this.btn_SaveDatabase.Name = "btn_SaveDatabase";
            this.btn_SaveDatabase.Size = new System.Drawing.Size(140, 40);
            this.btn_SaveDatabase.TabIndex = 6;
            this.btn_SaveDatabase.Text = "Lưu Cấu Hình";
            this.btn_SaveDatabase.UseVisualStyleBackColor = true;
            this.btn_SaveDatabase.Click += new System.EventHandler(this.btn_SaveDatabase_Click);
            // 
            // gb_PrinterConfig
            // 
            this.gb_PrinterConfig.Controls.Add(this.btn_SavePrinter);
            this.gb_PrinterConfig.Controls.Add(this.btn_PrintTest);
            this.gb_PrinterConfig.Controls.Add(this.cb_PaperSize);
            this.gb_PrinterConfig.Controls.Add(this.lbl_PaperSize);
            this.gb_PrinterConfig.Controls.Add(this.cb_PrinterList);
            this.gb_PrinterConfig.Controls.Add(this.lbl_PrinterName);
            this.gb_PrinterConfig.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.gb_PrinterConfig.Location = new System.Drawing.Point(390, 12);
            this.gb_PrinterConfig.Name = "gb_PrinterConfig";
            this.gb_PrinterConfig.Size = new System.Drawing.Size(360, 320);
            this.gb_PrinterConfig.TabIndex = 7;
            this.gb_PrinterConfig.TabStop = false;
            this.gb_PrinterConfig.Text = "Cấu Hình Máy In Hóa Đơn";
            // 
            // lbl_PrinterName
            // 
            this.lbl_PrinterName.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbl_PrinterName.Location = new System.Drawing.Point(15, 35);
            this.lbl_PrinterName.Name = "lbl_PrinterName";
            this.lbl_PrinterName.Size = new System.Drawing.Size(100, 25);
            this.lbl_PrinterName.Text = "Chọn máy in:";
            // 
            // cb_PrinterList
            // 
            this.cb_PrinterList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PrinterList.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cb_PrinterList.Location = new System.Drawing.Point(120, 32);
            this.cb_PrinterList.Name = "cb_PrinterList";
            this.cb_PrinterList.Size = new System.Drawing.Size(220, 29);
            this.cb_PrinterList.TabIndex = 8;
            // 
            // lbl_PaperSize
            // 
            this.lbl_PaperSize.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lbl_PaperSize.Location = new System.Drawing.Point(15, 80);
            this.lbl_PaperSize.Name = "lbl_PaperSize";
            this.lbl_PaperSize.Size = new System.Drawing.Size(100, 25);
            this.lbl_PaperSize.Text = "Khổ giấy:";
            // 
            // cb_PaperSize
            // 
            this.cb_PaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PaperSize.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cb_PaperSize.Location = new System.Drawing.Point(120, 77);
            this.cb_PaperSize.Name = "cb_PaperSize";
            this.cb_PaperSize.Size = new System.Drawing.Size(220, 29);
            this.cb_PaperSize.TabIndex = 9;
            // 
            // btn_PrintTest
            // 
            this.btn_PrintTest.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btn_PrintTest.Location = new System.Drawing.Point(20, 240);
            this.btn_PrintTest.Name = "btn_PrintTest";
            this.btn_PrintTest.Size = new System.Drawing.Size(140, 40);
            this.btn_PrintTest.TabIndex = 10;
            this.btn_PrintTest.Text = "In Thử (Test)";
            this.btn_PrintTest.UseVisualStyleBackColor = true;
            this.btn_PrintTest.Click += new System.EventHandler(this.btn_PrintTest_Click);
            // 
            // btn_SavePrinter
            // 
            this.btn_SavePrinter.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_SavePrinter.Location = new System.Drawing.Point(200, 240);
            this.btn_SavePrinter.Name = "btn_SavePrinter";
            this.btn_SavePrinter.Size = new System.Drawing.Size(140, 40);
            this.btn_SavePrinter.TabIndex = 11;
            this.btn_SavePrinter.Text = "Lưu Máy In";
            this.btn_SavePrinter.UseVisualStyleBackColor = true;
            this.btn_SavePrinter.Click += new System.EventHandler(this.btn_SavePrinter_Click);
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 351);
            this.Controls.Add(this.gb_PrinterConfig);
            this.Controls.Add(this.gb_DatabaseConfig);
            this.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phân Hệ Cấu Hình Hệ Thống - Quyền Admin (IT)";
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.gb_DatabaseConfig.ResumeLayout(false);
            this.gb_DatabaseConfig.PerformLayout();
            this.gb_PrinterConfig.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox gb_DatabaseConfig;
        private System.Windows.Forms.Label lbl_Server;
        private System.Windows.Forms.TextBox txt_Server;
        private System.Windows.Forms.Label lbl_Database;
        private System.Windows.Forms.TextBox txt_Database;
        private System.Windows.Forms.Label lbl_User;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_TestConnection;
        private System.Windows.Forms.Button btn_SaveDatabase;

        private System.Windows.Forms.GroupBox gb_PrinterConfig;
        private System.Windows.Forms.Label lbl_PrinterName;
        private System.Windows.Forms.ComboBox cb_PrinterList;
        private System.Windows.Forms.Label lbl_PaperSize;
        private System.Windows.Forms.ComboBox cb_PaperSize;
        private System.Windows.Forms.Button btn_PrintTest;
        private System.Windows.Forms.Button btn_SavePrinter;
    }
}