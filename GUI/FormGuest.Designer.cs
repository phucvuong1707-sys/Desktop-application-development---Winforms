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
        groupBox1 = new GroupBox();
        btn_search = new Button();
        btn_delete = new Button();
        btn_update = new Button();
        btn_add = new Button();
        cbo_Rank = new ComboBox();
        txt_Phone = new TextBox();
        txt_GuestName = new TextBox();
        txt_GuestID = new TextBox();
        label4 = new Label();
        label3 = new Label();
        label2 = new Label();
        label1 = new Label();
        mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
        dgv_Guest = new DataGridView();
        col_CustomerID = new DataGridViewTextBoxColumn();
        col_customer_name = new DataGridViewTextBoxColumn();
        col_PhoneNumber = new DataGridViewTextBoxColumn();
        col_RewardPoints = new DataGridViewTextBoxColumn();
        col_MembershipTier = new DataGridViewTextBoxColumn();
        groupBox1.SuspendLayout();
        ((ISupportInitialize)dgv_Guest).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(btn_search);
        groupBox1.Controls.Add(btn_delete);
        groupBox1.Controls.Add(btn_update);
        groupBox1.Controls.Add(btn_add);
        groupBox1.Controls.Add(cbo_Rank);
        groupBox1.Controls.Add(txt_Phone);
        groupBox1.Controls.Add(txt_GuestName);
        groupBox1.Controls.Add(txt_GuestID);
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new Point(13, 17);
        groupBox1.Margin = new Padding(1, 1, 1, 1);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(1, 1, 1, 1);
        groupBox1.Size = new Size(713, 177);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "groupBox1";
        // 
        // btn_search
        // 
        btn_search.Location = new Point(252, 120);
        btn_search.Margin = new Padding(1, 1, 1, 1);
        btn_search.Name = "btn_search";
        btn_search.Size = new Size(55, 20);
        btn_search.TabIndex = 12;
        btn_search.Text = "Tìm Kiếm";
        btn_search.UseVisualStyleBackColor = true;
        // 
        // btn_delete
        // 
        btn_delete.Location = new Point(174, 120);
        btn_delete.Margin = new Padding(1, 1, 1, 1);
        btn_delete.Name = "btn_delete";
        btn_delete.Size = new Size(55, 20);
        btn_delete.TabIndex = 10;
        btn_delete.Text = "Xóa";
        btn_delete.UseVisualStyleBackColor = true;
        // 
        // btn_update
        // 
        btn_update.Location = new Point(93, 120);
        btn_update.Margin = new Padding(1, 1, 1, 1);
        btn_update.Name = "btn_update";
        btn_update.Size = new Size(55, 20);
        btn_update.TabIndex = 9;
        btn_update.Text = "Sửa";
        btn_update.UseVisualStyleBackColor = true;
        // 
        // btn_add
        // 
        btn_add.Location = new Point(17, 120);
        btn_add.Margin = new Padding(1, 1, 1, 1);
        btn_add.Name = "btn_add";
        btn_add.Size = new Size(55, 20);
        btn_add.TabIndex = 8;
        btn_add.Text = "Thêm";
        btn_add.UseVisualStyleBackColor = true;
        // 
        // cbo_Rank
        // 
        cbo_Rank.FormattingEnabled = true;
        cbo_Rank.Location = new Point(62, 90);
        cbo_Rank.Margin = new Padding(1, 1, 1, 1);
        cbo_Rank.Name = "cbo_Rank";
        cbo_Rank.Size = new Size(73, 28);
        cbo_Rank.TabIndex = 7;
        // 
        // txt_Phone
        // 
        txt_Phone.Location = new Point(62, 61);
        txt_Phone.Margin = new Padding(1, 1, 1, 1);
        txt_Phone.Name = "txt_Phone";
        txt_Phone.Size = new Size(61, 27);
        txt_Phone.TabIndex = 6;
        // 
        // txt_GuestName
        // 
        txt_GuestName.Location = new Point(62, 40);
        txt_GuestName.Margin = new Padding(1, 1, 1, 1);
        txt_GuestName.Name = "txt_GuestName";
        txt_GuestName.Size = new Size(61, 27);
        txt_GuestName.TabIndex = 5;
        // 
        // txt_GuestID
        // 
        txt_GuestID.Location = new Point(62, 22);
        txt_GuestID.Margin = new Padding(1, 1, 1, 1);
        txt_GuestID.Name = "txt_GuestID";
        txt_GuestID.Size = new Size(61, 27);
        txt_GuestID.TabIndex = 4;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(17, 90);
        label4.Margin = new Padding(1, 0, 1, 0);
        label4.Name = "label4";
        label4.Size = new Size(51, 20);
        label4.TabIndex = 3;
        label4.Text = "HẠNG";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(17, 62);
        label3.Margin = new Padding(1, 0, 1, 0);
        label3.Name = "label3";
        label3.Size = new Size(36, 20);
        label3.TabIndex = 2;
        label3.Text = "SĐT";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(17, 40);
        label2.Margin = new Padding(1, 0, 1, 0);
        label2.Name = "label2";
        label2.Size = new Size(56, 20);
        label2.TabIndex = 1;
        label2.Text = "Tên KH";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(17, 22);
        label1.Margin = new Padding(1, 0, 1, 0);
        label1.Name = "label1";
        label1.Size = new Size(54, 20);
        label1.TabIndex = 0;
        label1.Text = "Mã KH";
        // 
        // mySqlCommand1
        // 
        mySqlCommand1.CacheAge = 0;
        mySqlCommand1.Connection = null;
        mySqlCommand1.EnableCaching = false;
        mySqlCommand1.Transaction = null;
        // 
        // dgv_Guest
        // 
        dgv_Guest.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgv_Guest.Columns.AddRange(new DataGridViewColumn[] { col_CustomerID, col_customer_name, col_PhoneNumber, col_RewardPoints, col_MembershipTier });
        dgv_Guest.Location = new Point(30, 217);
        dgv_Guest.Margin = new Padding(1, 1, 1, 1);
        dgv_Guest.Name = "dgv_Guest";
        dgv_Guest.RowHeadersWidth = 51;
        dgv_Guest.Size = new Size(696, 300);
        dgv_Guest.TabIndex = 1;
        // 
        // col_CustomerID
        // 
        col_CustomerID.HeaderText = "Mã KH";
        col_CustomerID.MinimumWidth = 6;
        col_CustomerID.Name = "col_CustomerID";
        col_CustomerID.Width = 125;
        // 
        // col_customer_name
        // 
        col_customer_name.HeaderText = "Tên KH\n\n";
        col_customer_name.MinimumWidth = 6;
        col_customer_name.Name = "col_customer_name";
        col_customer_name.Width = 125;
        // 
        // col_PhoneNumber
        // 
        col_PhoneNumber.HeaderText = "SĐT";
        col_PhoneNumber.MinimumWidth = 6;
        col_PhoneNumber.Name = "col_PhoneNumber";
        col_PhoneNumber.Width = 125;
        // 
        // col_RewardPoints
        // 
        col_RewardPoints.HeaderText = "Điểm tích lũy";
        col_RewardPoints.MinimumWidth = 6;
        col_RewardPoints.Name = "col_RewardPoints";
        col_RewardPoints.Width = 125;
        // 
        // col_MembershipTier
        // 
        col_MembershipTier.HeaderText = "Hạng";
        col_MembershipTier.MinimumWidth = 6;
        col_MembershipTier.Name = "col_MembershipTier";
        col_MembershipTier.Width = 125;
        // 
        // FormGuest
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1320, 647);
        Controls.Add(dgv_Guest);
        Controls.Add(groupBox1);
        Name = "FormGuest";
        Text = "FormGuest";
        Load += FormGuest_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ((ISupportInitialize)dgv_Guest).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private GroupBox groupBox1;
    private Button btn_search;
    private Button btn_delete;
    private Button btn_update;
    private Button btn_add;
    private ComboBox cbo_Rank;
    private TextBox txt_Phone;
    private TextBox txt_GuestName;
    private TextBox txt_GuestID;
    private Label label4;
    private Label label3;
    private Label label2;
    private Label label1;
    private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
    private DataGridView dgv_Guest;
    private DataGridViewTextBoxColumn col_CustomerID;
    private DataGridViewTextBoxColumn col_customer_name;
    private DataGridViewTextBoxColumn col_PhoneNumber;
    private DataGridViewTextBoxColumn col_RewardPoints;
    private DataGridViewTextBoxColumn col_MembershipTier;
}