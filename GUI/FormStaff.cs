using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class FormStaff : Form
    {
        private readonly UsersBUS _userBUS = new UsersBUS();
        private int _selectedUserID = -1;
        private bool _isAdding = false;

        public FormStaff()
        {
            InitializeComponent();
            dgv_staffList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void FormStaff_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
                SetInputState(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load FormStaff: {ex.Message}\n\n{ex.StackTrace}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                List<UsersDTO> list = _userBUS.GetAll();
                
                if (list == null || list.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu nhân viên trong cơ sở dữ liệu.", 
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgv_staffList.DataSource = null;
                    return;
                }

                dgv_staffList.DataSource = list;

                // Ẩn các cột không cần thiết
                if (dgv_staffList.Columns["Password"] != null)
                    dgv_staffList.Columns["Password"].Visible = false;
                if (dgv_staffList.Columns["CreatedAt"] != null)
                    dgv_staffList.Columns["CreatedAt"].Visible = false;

                // Đổi tên cột hiển thị
                if (dgv_staffList.Columns["UserID"] != null) 
                    dgv_staffList.Columns["UserID"].HeaderText = "Mã NV";
                if (dgv_staffList.Columns["FullName"] != null) 
                    dgv_staffList.Columns["FullName"].HeaderText = "Họ tên";
                if (dgv_staffList.Columns["Username"] != null) 
                    dgv_staffList.Columns["Username"].HeaderText = "Tài khoản";
                if (dgv_staffList.Columns["Phone"] != null) 
                    dgv_staffList.Columns["Phone"].HeaderText = "SĐT";
                if (dgv_staffList.Columns["RoleID"] != null)
                    dgv_staffList.Columns["RoleID"].HeaderText = "Chức vụ";
                if (dgv_staffList.Columns["IsActive"] != null)
                    dgv_staffList.Columns["IsActive"].HeaderText = "Trạng thái";

                dgv_staffList.ClearSelection();
                _selectedUserID = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load dữ liệu: {ex.Message}", 
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_staffList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null) return;

            try
            {
                if (dgv_staffList.Columns[e.ColumnIndex].Name == "IsActive")
                {
                    bool isActive = (bool)e.Value;
                    e.Value = isActive ? "Hoạt động" : "Vô hiệu";
                    e.CellStyle.ForeColor = isActive ? Color.Green : Color.Red;
                    e.FormattingApplied = true;
                }
                else if (dgv_staffList.Columns[e.ColumnIndex].Name == "RoleID")
                {
                    int roleId = (int)e.Value;
                    e.Value = GetRoleName(roleId);
                    e.FormattingApplied = true;
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error in CellFormatting: {ex.Message}");
                // Không throw exception, chỉ log để tránh crash
            }
        }

        private void dgv_staffList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && !_isAdding)
            {
                DataGridViewRow row = dgv_staffList.Rows[e.RowIndex];

                _selectedUserID = Convert.ToInt32(row.Cells["UserID"].Value);
                txt_fullName.Text = row.Cells["FullName"].Value?.ToString();
                txt_username.Text = row.Cells["Username"].Value?.ToString();
                txt_phone.Text = row.Cells["Phone"].Value?.ToString();
                txt_password.Text = "******";

                int roleId = Convert.ToInt32(row.Cells["RoleID"].Value);
                cbb_role.Text = GetRoleName(roleId);
            }
        }

        private void SetInputState(bool isEnabled)
        {
            if (grp_StaffDetails != null)
            {
                grp_StaffDetails.Enabled = isEnabled;
            }
        }

        private string GetRoleName(int roleID) => roleID switch
        {
            1 => "Quản lý",
            2 => "Thu ngân",
            3 => "Kho",
            4 => "Kỹ thuật",
            _ => "Nhân viên"
        };
    }
}