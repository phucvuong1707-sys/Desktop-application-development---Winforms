namespace GUI
{
    partial class FormInventory
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
            dgvInventory = new System.Windows.Forms.DataGridView();
            txtProductCode = new System.Windows.Forms.TextBox();
            txtProductName = new System.Windows.Forms.TextBox();
            txtSystemQty = new System.Windows.Forms.TextBox();
            nudActualQty = new System.Windows.Forms.NumericUpDown();
            txtDifference = new System.Windows.Forms.TextBox();
            txtNote = new System.Windows.Forms.TextBox();
            btnUpdateRecord = new System.Windows.Forms.Button();
            btnSaveInventory = new System.Windows.Forms.Button();
            lbl1 = new System.Windows.Forms.Label();
            lbl2 = new System.Windows.Forms.Label();
            lbl3 = new System.Windows.Forms.Label();
            lbl4 = new System.Windows.Forms.Label();
            lbl5 = new System.Windows.Forms.Label();
            lbl6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dgvInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudActualQty).BeginInit();
            SuspendLayout();
            // 
            // dgvInventory
            // 
            dgvInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvInventory.Location = new System.Drawing.Point(12, 175);
            dgvInventory.Name = "dgvInventory";
            dgvInventory.RowHeadersWidth = 51;
            dgvInventory.Size = new System.Drawing.Size(760, 215);
            dgvInventory.TabIndex = 0;
            dgvInventory.CellClick += dgvInventory_CellClick;
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new System.Drawing.Point(119, 20);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.ReadOnly = true;
            txtProductCode.Size = new System.Drawing.Size(180, 47);
            txtProductCode.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new System.Drawing.Point(119, 55);
            txtProductName.Name = "txtProductName";
            txtProductName.ReadOnly = true;
            txtProductName.Size = new System.Drawing.Size(180, 47);
            txtProductName.TabIndex = 2;
            txtProductName.TextChanged += txtProductName_TextChanged;
            // 
            // txtSystemQty
            // 
            txtSystemQty.Location = new System.Drawing.Point(119, 90);
            txtSystemQty.Name = "txtSystemQty";
            txtSystemQty.ReadOnly = true;
            txtSystemQty.Size = new System.Drawing.Size(180, 47);
            txtSystemQty.TabIndex = 3;
            // 
            // nudActualQty
            // 
            nudActualQty.Location = new System.Drawing.Point(430, 20);
            nudActualQty.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            nudActualQty.Name = "nudActualQty";
            nudActualQty.Size = new System.Drawing.Size(180, 47);
            nudActualQty.TabIndex = 4;
            nudActualQty.ValueChanged += nudActualQty_ValueChanged;
            // 
            // txtDifference
            // 
            txtDifference.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            txtDifference.Location = new System.Drawing.Point(430, 57);
            txtDifference.Name = "txtDifference";
            txtDifference.ReadOnly = true;
            txtDifference.Size = new System.Drawing.Size(180, 39);
            txtDifference.TabIndex = 5;
            // 
            // txtNote
            // 
            txtNote.Location = new System.Drawing.Point(430, 92);
            txtNote.Name = "txtNote";
            txtNote.Size = new System.Drawing.Size(180, 47);
            txtNote.TabIndex = 6;
            txtNote.TextChanged += txtNote_TextChanged;
            // 
            // btnUpdateRecord
            // 
            btnUpdateRecord.Location = new System.Drawing.Point(420, 125);
            btnUpdateRecord.Name = "btnUpdateRecord";
            btnUpdateRecord.Size = new System.Drawing.Size(137, 30);
            btnUpdateRecord.TabIndex = 7;
            btnUpdateRecord.Text = "Xác nhận số kiểm";
            btnUpdateRecord.Click += btnUpdateRecord_Click;
            // 
            // btnSaveInventory
            // 
            btnSaveInventory.Location = new System.Drawing.Point(12, 400);
            btnSaveInventory.Name = "btnSaveInventory";
            btnSaveInventory.Size = new System.Drawing.Size(160, 30);
            btnSaveInventory.TabIndex = 8;
            btnSaveInventory.Text = "Lưu biên bản kiểm kê";
            btnSaveInventory.Click += btnSaveInventory_Click;
            // 
            // lbl1
            // 
            lbl1.Location = new System.Drawing.Point(20, 23);
            lbl1.Name = "lbl1";
            lbl1.Size = new System.Drawing.Size(102, 24);
            lbl1.TabIndex = 5;
            lbl1.Text = "Mã sản phẩm:";
            // 
            // lbl2
            // 
            lbl2.Location = new System.Drawing.Point(20, 58);
            lbl2.Name = "lbl2";
            lbl2.Size = new System.Drawing.Size(112, 20);
            lbl2.TabIndex = 4;
            lbl2.Text = "Tên sản phẩm:";
            // 
            // lbl3
            // 
            lbl3.Location = new System.Drawing.Point(20, 93);
            lbl3.Name = "lbl3";
            lbl3.Size = new System.Drawing.Size(102, 24);
            lbl3.TabIndex = 3;
            lbl3.Text = "Tồn hệ thống:";
            // 
            // lbl4
            // 
            lbl4.Location = new System.Drawing.Point(330, 23);
            lbl4.Name = "lbl4";
            lbl4.Size = new System.Drawing.Size(94, 24);
            lbl4.TabIndex = 2;
            lbl4.Text = "Tồn thực tế:";
            // 
            // lbl5
            // 
            lbl5.Location = new System.Drawing.Point(330, 58);
            lbl5.Name = "lbl5";
            lbl5.Size = new System.Drawing.Size(85, 24);
            lbl5.TabIndex = 1;
            lbl5.Text = "Chênh lệch:";
            // 
            // lbl6
            // 
            lbl6.Location = new System.Drawing.Point(330, 93);
            lbl6.Name = "lbl6";
            lbl6.Size = new System.Drawing.Size(103, 24);
            lbl6.TabIndex = 0;
            lbl6.Text = "Ghi chú xử lý:";
            // 
            // FormInventory
            // 
            ClientSize = new System.Drawing.Size(1175, 773);
            Controls.Add(lbl6);
            Controls.Add(lbl5);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnSaveInventory);
            Controls.Add(btnUpdateRecord);
            Controls.Add(txtNote);
            Controls.Add(txtDifference);
            Controls.Add(nudActualQty);
            Controls.Add(txtSystemQty);
            Controls.Add(txtProductName);
            Controls.Add(txtProductCode);
            Controls.Add(dgvInventory);
            Text = "Kiểm kê kho hàng";
            Load += FormInventory_Load;
            ((System.ComponentModel.ISupportInitialize)dgvInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudActualQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtSystemQty;
        private System.Windows.Forms.NumericUpDown nudActualQty;
        private System.Windows.Forms.TextBox txtDifference;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.Button btnUpdateRecord;
        private System.Windows.Forms.Button btnSaveInventory;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
    }
}