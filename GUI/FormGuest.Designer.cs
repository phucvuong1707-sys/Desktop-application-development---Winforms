using System.ComponentModel;

namespace GUI;

partial class FormGuest
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
        mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
        dgv_guest = new System.Windows.Forms.DataGridView();
        col_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Point = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
        col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
        btn_addCustomer = new System.Windows.Forms.Button();
        btn_edit = new System.Windows.Forms.Button();
        btn_purchaseHistory = new System.Windows.Forms.Button();
        btn_refresh = new System.Windows.Forms.Button();
        groupBox2 = new System.Windows.Forms.GroupBox();
        txt_search = new System.Windows.Forms.TextBox();
        groupBox3 = new System.Windows.Forms.GroupBox();
        txt_phoneNumber = new System.Windows.Forms.TextBox();
        txt_fullName = new System.Windows.Forms.TextBox();
        txt_address = new System.Windows.Forms.TextBox();
        cbo_customerType = new System.Windows.Forms.ComboBox();
        btn_save = new System.Windows.Forms.Button();
        btn_cancel = new System.Windows.Forms.Button();
        pnl_top = new System.Windows.Forms.Panel();
        groupBox1 = new System.Windows.Forms.GroupBox();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        label7 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)dgv_guest).BeginInit();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        pnl_top.SuspendLayout();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // mySqlCommand1
        // 
        mySqlCommand1.CacheAge = 0;
        mySqlCommand1.Connection = null;
        mySqlCommand1.EnableCaching = false;
        mySqlCommand1.Transaction = null;
        // 
        // dgv_guest
        // 
        dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_guest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_Phone, col_Name, col_Type, col_Point, col_Total, col_Date });
        dgv_guest.Location = new System.Drawing.Point(11, 26);
        dgv_guest.Margin = new System.Windows.Forms.Padding(1);
        dgv_guest.Name = "dgv_guest";
        dgv_guest.RowHeadersWidth = 51;
        dgv_guest.Size = new System.Drawing.Size(1049, 775);
        dgv_guest.TabIndex = 1;
        dgv_guest.CellContentClick += dgv_guest_CellContentClick;
        // 
        // col_Phone
        // 
        col_Phone.HeaderText = "SĐT";
        col_Phone.MinimumWidth = 6;
        col_Phone.Name = "col_Phone";
        col_Phone.Width = 125;
        // 
        // col_Name
        // 
        col_Name.HeaderText = "Họ tên";
        col_Name.MinimumWidth = 6;
        col_Name.Name = "col_Name";
        col_Name.Width = 125;
        // 
        // col_Type
        // 
        col_Type.HeaderText = "Loại KH";
        col_Type.MinimumWidth = 6;
        col_Type.Name = "col_Type";
        col_Type.Width = 125;
        // 
        // col_Point
        // 
        col_Point.HeaderText = "Điểm tích lũy";
        col_Point.MinimumWidth = 6;
        col_Point.Name = "col_Point";
        col_Point.Width = 125;
        // 
        // col_Total
        // 
        col_Total.HeaderText = "Tổng mua";
        col_Total.MinimumWidth = 6;
        col_Total.Name = "col_Total";
        col_Total.Width = 125;
        // 
        // col_Date
        // 
        col_Date.HeaderText = "Ngày tạo";
        col_Date.MinimumWidth = 6;
        col_Date.Name = "col_Date";
        col_Date.Width = 125;
        // 
        // btn_addCustomer
        // 
        btn_addCustomer.Location = new System.Drawing.Point(11, 17);
        btn_addCustomer.Name = "btn_addCustomer";
        btn_addCustomer.Size = new System.Drawing.Size(455, 54);
        btn_addCustomer.TabIndex = 2;
        btn_addCustomer.Text = "Thêm KH";
        btn_addCustomer.UseVisualStyleBackColor = true;
        // 
        // btn_edit
        // 
        btn_edit.Location = new System.Drawing.Point(472, 17);
        btn_edit.Name = "btn_edit";
        btn_edit.Size = new System.Drawing.Size(428, 54);
        btn_edit.TabIndex = 3;
        btn_edit.Text = "Sửa";
        btn_edit.UseVisualStyleBackColor = true;
        btn_edit.Click += btn_Edit_Click;
        // 
        // btn_purchaseHistory
        // 
        btn_purchaseHistory.Location = new System.Drawing.Point(906, 17);
        btn_purchaseHistory.Name = "btn_purchaseHistory";
        btn_purchaseHistory.Size = new System.Drawing.Size(412, 54);
        btn_purchaseHistory.TabIndex = 4;
        btn_purchaseHistory.Text = "Lịch sử mua";
        btn_purchaseHistory.UseVisualStyleBackColor = true;
        // 
        // btn_refresh
        // 
        btn_refresh.Location = new System.Drawing.Point(1324, 17);
        btn_refresh.Name = "btn_refresh";
        btn_refresh.Size = new System.Drawing.Size(420, 54);
        btn_refresh.TabIndex = 5;
        btn_refresh.Text = "Làm mới";
        btn_refresh.UseVisualStyleBackColor = true;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(dgv_guest);
        groupBox2.Location = new System.Drawing.Point(1, 161);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(1064, 808);
        groupBox2.TabIndex = 7;
        groupBox2.TabStop = false;
        // 
        // txt_search
        // 
        txt_search.Location = new System.Drawing.Point(11, 23);
        txt_search.Name = "txt_search";
        txt_search.Size = new System.Drawing.Size(1733, 47);
        txt_search.TabIndex = 2;
        txt_search.Text = "🔍 Tìm theo SĐT, tên khách hàng...";
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label7);
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(label2);
        groupBox3.Controls.Add(label1);
        groupBox3.Controls.Add(txt_phoneNumber);
        groupBox3.Controls.Add(txt_fullName);
        groupBox3.Controls.Add(txt_address);
        groupBox3.Controls.Add(cbo_customerType);
        groupBox3.Controls.Add(btn_save);
        groupBox3.Controls.Add(btn_cancel);
        groupBox3.Location = new System.Drawing.Point(1071, 187);
        groupBox3.Name = "groupBox3";
        groupBox3.Size = new System.Drawing.Size(688, 782);
        groupBox3.TabIndex = 8;
        groupBox3.TabStop = false;
        groupBox3.Text = "THÔNG TIN KHÁCH HÀNG";
        // 
        // txt_phoneNumber
        // 
        txt_phoneNumber.Location = new System.Drawing.Point(20, 98);
        txt_phoneNumber.Name = "txt_phoneNumber";
        txt_phoneNumber.Size = new System.Drawing.Size(654, 47);
        txt_phoneNumber.TabIndex = 10;
        // 
        // txt_fullName
        // 
        txt_fullName.Location = new System.Drawing.Point(20, 213);
        txt_fullName.Name = "txt_fullName";
        txt_fullName.Size = new System.Drawing.Size(654, 47);
        txt_fullName.TabIndex = 9;
        // 
        // txt_address
        // 
        txt_address.Location = new System.Drawing.Point(20, 334);
        txt_address.Name = "txt_address";
        txt_address.Size = new System.Drawing.Size(654, 47);
        txt_address.TabIndex = 3;
        // 
        // cbo_customerType
        // 
        cbo_customerType.FormattingEnabled = true;
        cbo_customerType.Items.AddRange(new object[] { "Thường", "Thân thiết", "VIP" });
        cbo_customerType.Location = new System.Drawing.Point(20, 456);
        cbo_customerType.Name = "cbo_customerType";
        cbo_customerType.Size = new System.Drawing.Size(654, 49);
        cbo_customerType.TabIndex = 8;
        // 
        // btn_save
        // 
        btn_save.Location = new System.Drawing.Point(20, 557);
        btn_save.Name = "btn_save";
        btn_save.Size = new System.Drawing.Size(654, 54);
        btn_save.TabIndex = 6;
        btn_save.Text = "Lưu";
        btn_save.UseVisualStyleBackColor = true;
        // 
        // btn_cancel
        // 
        btn_cancel.Location = new System.Drawing.Point(20, 633);
        btn_cancel.Name = "btn_cancel";
        btn_cancel.Size = new System.Drawing.Size(654, 54);
        btn_cancel.TabIndex = 7;
        btn_cancel.Text = "Hủy";
        btn_cancel.UseVisualStyleBackColor = true;
        // 
        // pnl_top
        // 
        pnl_top.Controls.Add(btn_refresh);
        pnl_top.Controls.Add(btn_addCustomer);
        pnl_top.Controls.Add(btn_purchaseHistory);
        pnl_top.Controls.Add(btn_edit);
        pnl_top.Location = new System.Drawing.Point(1, -5);
        pnl_top.Name = "pnl_top";
        pnl_top.Size = new System.Drawing.Size(1758, 84);
        pnl_top.TabIndex = 9;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(txt_search);
        groupBox1.Location = new System.Drawing.Point(1, 85);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(1758, 76);
        groupBox1.TabIndex = 10;
        groupBox1.TabStop = false;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(20, 52);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(117, 43);
        label1.TabIndex = 11;
        label1.Text = "SĐT:";
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(20, 405);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(246, 48);
        label2.TabIndex = 12;
        label2.Text = "Loại Khách:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(20, 285);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(177, 46);
        label3.TabIndex = 13;
        label3.Text = "Địa Chỉ:";
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(20, 164);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(152, 46);
        label7.TabIndex = 14;
        label7.Text = "Họ Tên:";
        // 
        // FormGuest
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(1757, 972);
        Controls.Add(groupBox1);
        Controls.Add(pnl_top);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Margin = new System.Windows.Forms.Padding(6);
        Text = "FormGuest";
        Load += FormGuest_Load;
        ((System.ComponentModel.ISupportInitialize)dgv_guest).EndInit();
        groupBox2.ResumeLayout(false);
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        pnl_top.ResumeLayout(false);
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.GroupBox groupBox1;

    private System.Windows.Forms.Panel pnl_top;

    #endregion
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private System.Windows.Forms.DataGridView dgv_guest;
    private System.Windows.Forms.Button btn_addCustomer;
    private System.Windows.Forms.Button btn_edit;
    private System.Windows.Forms.Button btn_purchaseHistory;
    private System.Windows.Forms.Button btn_refresh;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private DataGridViewTextBoxColumn col_Phone;
    private DataGridViewTextBoxColumn col_Name;
    private DataGridViewTextBoxColumn col_Type;
    private DataGridViewTextBoxColumn col_Point;
    private DataGridViewTextBoxColumn col_Total;
    private DataGridViewTextBoxColumn col_Date;
    private System.Windows.Forms.TextBox txt_search;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_phoneNumber;
    private System.Windows.Forms.TextBox txt_fullName;
    private System.Windows.Forms.TextBox txt_address;
    private System.Windows.Forms.ComboBox cbo_customerType;
    private System.Windows.Forms.Button btn_save;
    private System.Windows.Forms.Button btn_cancel;
}