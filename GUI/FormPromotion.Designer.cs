namespace GUI
{
    partial class FormPromotion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            groupBox3 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            dtp_endDate = new System.Windows.Forms.DateTimePicker();
            dtp_startDate = new System.Windows.Forms.DateTimePicker();
            txt_promotionCode = new System.Windows.Forms.TextBox();
            txt_description = new System.Windows.Forms.TextBox();
            txt_discountValue = new System.Windows.Forms.TextBox();
            btn_save = new System.Windows.Forms.Button();
            btn_cancel = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            groupBox2 = new System.Windows.Forms.GroupBox();
            btn_createPromotion = new System.Windows.Forms.Button();
            dgv_guest = new System.Windows.Forms.DataGridView();
            col_promotionCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_discountPercentage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_discountAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_endDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            col_status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btn_refresh = new System.Windows.Forms.Button();
            btn_disablePromotion = new System.Windows.Forms.Button();
            btn_editPromotion = new System.Windows.Forms.Button();
            pnl_top = new System.Windows.Forms.Panel();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_guest).BeginInit();
            pnl_top.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(dtp_endDate);
            groupBox3.Controls.Add(dtp_startDate);
            groupBox3.Controls.Add(txt_promotionCode);
            groupBox3.Controls.Add(txt_description);
            groupBox3.Controls.Add(txt_discountValue);
            groupBox3.Controls.Add(btn_save);
            groupBox3.Controls.Add(btn_cancel);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new System.Drawing.Point(1016, 98);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new System.Drawing.Size(757, 907);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin KM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(15, 488);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(145, 41);
            label1.TabIndex = 13;
            label1.Text = "Đến ngày";
            // 
            // dtp_endDate
            // 
            dtp_endDate.Location = new System.Drawing.Point(15, 532);
            dtp_endDate.Name = "dtp_endDate";
            dtp_endDate.Size = new System.Drawing.Size(731, 47);
            dtp_endDate.TabIndex = 12;
            // 
            // dtp_startDate
            // 
            dtp_startDate.Location = new System.Drawing.Point(15, 415);
            dtp_startDate.Name = "dtp_startDate";
            dtp_startDate.Size = new System.Drawing.Size(731, 47);
            dtp_startDate.TabIndex = 11;
            // 
            // txt_promotionCode
            // 
            txt_promotionCode.Location = new System.Drawing.Point(15, 87);
            txt_promotionCode.Name = "txt_promotionCode";
            txt_promotionCode.Size = new System.Drawing.Size(731, 47);
            txt_promotionCode.TabIndex = 10;
            // 
            // txt_description
            // 
            txt_description.Location = new System.Drawing.Point(15, 192);
            txt_description.Name = "txt_description";
            txt_description.Size = new System.Drawing.Size(731, 47);
            txt_description.TabIndex = 9;
            // 
            // txt_discountValue
            // 
            txt_discountValue.Location = new System.Drawing.Point(15, 303);
            txt_discountValue.Name = "txt_discountValue";
            txt_discountValue.Size = new System.Drawing.Size(731, 47);
            txt_discountValue.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Location = new System.Drawing.Point(15, 644);
            btn_save.Name = "btn_save";
            btn_save.Size = new System.Drawing.Size(731, 54);
            btn_save.TabIndex = 6;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new System.Drawing.Point(15, 717);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new System.Drawing.Size(731, 54);
            btn_cancel.TabIndex = 7;
            btn_cancel.Text = "Hủy";
            btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(15, 371);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(125, 41);
            label6.TabIndex = 7;
            label6.Text = "Từ ngày";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(15, 259);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(275, 41);
            label5.TabIndex = 6;
            label5.Text = "Giảm % / Giảm tiền";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 148);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(96, 41);
            label4.TabIndex = 5;
            label4.Text = "Mô tả";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(15, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(242, 41);
            label3.TabIndex = 4;
            label3.Text = "Mã khuyến mãi *";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgv_guest);
            groupBox2.Location = new System.Drawing.Point(-2, 98);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new System.Drawing.Size(1012, 907);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            // 
            // btn_createPromotion
            // 
            btn_createPromotion.Location = new System.Drawing.Point(18, 13);
            btn_createPromotion.Name = "btn_createPromotion";
            btn_createPromotion.Size = new System.Drawing.Size(393, 54);
            btn_createPromotion.TabIndex = 2;
            btn_createPromotion.Text = "+ Tạo KM";
            btn_createPromotion.UseVisualStyleBackColor = true;
            // 
            // dgv_guest
            // 
            dgv_guest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_guest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { col_promotionCode, col_description, col_discountPercentage, col_discountAmount, col_startDate, col_endDate, col_status });
            dgv_guest.Location = new System.Drawing.Point(4, -2);
            dgv_guest.Margin = new System.Windows.Forms.Padding(1);
            dgv_guest.Name = "dgv_guest";
            dgv_guest.RowHeadersWidth = 51;
            dgv_guest.Size = new System.Drawing.Size(1004, 909);
            dgv_guest.TabIndex = 1;
            // 
            // col_promotionCode
            // 
            col_promotionCode.HeaderText = "Mã KM";
            col_promotionCode.MinimumWidth = 6;
            col_promotionCode.Name = "col_promotionCode";
            col_promotionCode.Width = 125;
            // 
            // col_description
            // 
            col_description.HeaderText = "Mô tả";
            col_description.MinimumWidth = 6;
            col_description.Name = "col_description";
            col_description.Width = 125;
            // 
            // col_discountPercentage
            // 
            col_discountPercentage.HeaderText = "Giảm %";
            col_discountPercentage.MinimumWidth = 6;
            col_discountPercentage.Name = "col_discountPercentage";
            col_discountPercentage.Width = 125;
            // 
            // col_discountAmount
            // 
            col_discountAmount.HeaderText = "Giảm tiền";
            col_discountAmount.MinimumWidth = 6;
            col_discountAmount.Name = "col_discountAmount";
            col_discountAmount.Width = 125;
            // 
            // col_startDate
            // 
            col_startDate.HeaderText = "Từ ngày";
            col_startDate.MinimumWidth = 6;
            col_startDate.Name = "col_startDate";
            col_startDate.Width = 125;
            // 
            // col_endDate
            // 
            col_endDate.HeaderText = "Đến ngày";
            col_endDate.MinimumWidth = 6;
            col_endDate.Name = "col_endDate";
            col_endDate.Width = 125;
            // 
            // col_status
            // 
            col_status.HeaderText = "Trạng thái";
            col_status.MinimumWidth = 6;
            col_status.Name = "col_status";
            col_status.Width = 125;
            // 
            // btn_refresh
            // 
            btn_refresh.Location = new System.Drawing.Point(1323, 13);
            btn_refresh.Name = "btn_refresh";
            btn_refresh.Size = new System.Drawing.Size(441, 54);
            btn_refresh.TabIndex = 5;
            btn_refresh.Text = "Làm mới";
            btn_refresh.UseVisualStyleBackColor = true;
            // 
            // btn_disablePromotion
            // 
            btn_disablePromotion.Location = new System.Drawing.Point(861, 13);
            btn_disablePromotion.Name = "btn_disablePromotion";
            btn_disablePromotion.Size = new System.Drawing.Size(456, 54);
            btn_disablePromotion.TabIndex = 4;
            btn_disablePromotion.Text = "Tắt KM";
            btn_disablePromotion.UseVisualStyleBackColor = true;
            // 
            // btn_editPromotion
            // 
            btn_editPromotion.Location = new System.Drawing.Point(417, 13);
            btn_editPromotion.Name = "btn_editPromotion";
            btn_editPromotion.Size = new System.Drawing.Size(438, 54);
            btn_editPromotion.TabIndex = 3;
            btn_editPromotion.Text = "Sửa";
            btn_editPromotion.UseVisualStyleBackColor = true;
            // 
            // pnl_top
            // 
            pnl_top.Controls.Add(btn_createPromotion);
            pnl_top.Controls.Add(btn_refresh);
            pnl_top.Controls.Add(btn_editPromotion);
            pnl_top.Controls.Add(btn_disablePromotion);
            pnl_top.Location = new System.Drawing.Point(-2, -1);
            pnl_top.Name = "pnl_top";
            pnl_top.Size = new System.Drawing.Size(1775, 93);
            pnl_top.TabIndex = 12;
            // 
            // FormPromotion
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1774, 1009);
            Controls.Add(pnl_top);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            Text = "FormPromotion";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_guest).EndInit();
            pnl_top.ResumeLayout(false);
            ResumeLayout(false);
        }

        private System.Windows.Forms.Panel pnl_top;

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_promotionCode;
        private System.Windows.Forms.TextBox txt_description;
        private System.Windows.Forms.TextBox txt_discountValue;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_createPromotion;
        private System.Windows.Forms.DataGridView dgv_guest;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_disablePromotion;
        private System.Windows.Forms.Button btn_editPromotion;
        private System.Windows.Forms.DateTimePicker dtp_startDate;
        private System.Windows.Forms.DateTimePicker dtp_endDate;
        private DataGridViewTextBoxColumn col_promotionCode;
        private DataGridViewTextBoxColumn col_description;
        private DataGridViewTextBoxColumn col_discountPercentage;
        private DataGridViewTextBoxColumn col_discountAmount;
        private DataGridViewTextBoxColumn col_startDate;
        private DataGridViewTextBoxColumn col_endDate;
        private DataGridViewTextBoxColumn col_status;
        private System.Windows.Forms.Label label1;
    }
}