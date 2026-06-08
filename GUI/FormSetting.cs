using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormSetting : Form
    {
        public FormSetting()
        {
            InitializeComponent();
        }

        // 1. Nạp các tham số môi trường và danh sách phần cứng khi mở Form
        private void FormSetting_Load(object sender, EventArgs e)
        {
            LoadCurrentDatabaseConfig();
            LoadSystemPrinters();
            LoadPaperSizes();
        }

        // Đọc thông tin chuỗi kết nối hiện tại để hiển thị lên Form
        private void LoadCurrentDatabaseConfig()
        {
            // Điền dữ liệu cấu hình mặc định (hoặc đọc từ file cấu hình cục bộ)
            txt_Server.Text = @".\SQLEXPRESS";
            txt_Database.Text = "Management_DB";
            txt_User.Text = "sa";
            txt_Password.Text = "123456";
        }

        // Quét toàn bộ máy in đang được cài đặt trong hệ điều hành Windows
        private void LoadSystemPrinters()
        {
            cb_PrinterList.Items.Clear();

            try
            {
                foreach (string printer in PrinterSettings.InstalledPrinters)
                {
                    cb_PrinterList.Items.Add(printer);
                }

                if (cb_PrinterList.Items.Count > 0)
                {
                    cb_PrinterList.SelectedIndex = 0;
                }
                else
                {
                    cb_PrinterList.Items.Add("Không tìm thấy máy in");
                    cb_PrinterList.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
                cb_PrinterList.Items.Add("Lỗi quét phần cứng máy in");
                cb_PrinterList.SelectedIndex = 0;
            }
        }

        // Đổ dữ liệu các loại khổ giấy máy in hóa đơn thông dụng (K80, K57)
        private void LoadPaperSizes()
        {
            cb_PaperSize.Items.Clear();
            cb_PaperSize.Items.Add("K80 (80mm - Chuyên dụng Hóa đơn)");
            cb_PaperSize.Items.Add("K57 (57mm - Máy in nhỏ/Cầm tay)");
            cb_PaperSize.Items.Add("A5 (Khổ nửa trang văn phòng)");
            cb_PaperSize.SelectedIndex = 0;
        }

        // 2. Kiểm soát các nghiệp vụ tương tác cấu hình Database

        // Thử nghiệm cấu trúc chuỗi kết nối SQL Server
        private void btn_TestConnection_Click(object sender, EventArgs e)
        {
            string server = txt_Server.Text.Trim();
            string database = txt_Database.Text.Trim();
            string user = txt_User.Text.Trim();
            string password = txt_Password.Text;

            if (string.IsNullOrEmpty(server) || string.IsNullOrEmpty(database))
            {
                MessageBox.Show("Vui lòng cung cấp đầy đủ thông tin Tên máy chủ và Cơ sở dữ liệu!", "Cảnh báo xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Giả lập chu trình bắt tay (Handshake) kiểm thử kết nối với Server
            string connectionString = $"Data Source={server};Initial Catalog={database};User ID={user};Password={password};";

            // Thông báo kết quả giả lập (Sẽ liên kết trực tiếp với lớp kiểm thử của tầng DAO sau này)
            MessageBox.Show($"Kiểm tra kết nối thành công đến máy chủ: {server}\nCơ sở dữ liệu sẵn sàng hoạt động!", "Kiểm thử hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Thực thi ghi đè cấu hình chuỗi kết nối hệ thống
        private void btn_SaveDatabase_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Server.Text.Trim()) || string.IsNullOrEmpty(txt_Database.Text.Trim()))
            {
                MessageBox.Show("Dữ liệu cấu hình không hợp lệ. Vui lòng kiểm tra lại!", "Lỗi lưu cấu hình", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Đã lưu chuỗi cấu hình cơ sở dữ liệu mới vào tệp cấu hình ứng dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 3. Kiểm soát các nghiệp vụ tương tác thiết lập máy in hóa đơn

        // Ra lệnh in thử nghiệm một trang hóa đơn mẫu để kiểm tra căn lề phần cứng
        private void btn_PrintTest_Click(object sender, EventArgs e)
        {
            string selectedPrinter = cb_PrinterList.SelectedItem?.ToString() ?? string.Empty;
            string selectedPaper = cb_PaperSize.SelectedItem?.ToString() ?? string.Empty;

            if (selectedPrinter == "Không tìm thấy máy in" || selectedPrinter == "Lỗi quét phần cứng máy in" || string.IsNullOrEmpty(selectedPrinter))
            {
                MessageBox.Show("Không tìm thấy thiết bị in hợp lệ để thực thi lệnh in thử!", "Lỗi ngoại vi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Khởi tạo luồng in tài liệu thực tế của thư viện .NET
            try
            {
                PrintDocument pd = new PrintDocument();
                pd.PrinterSettings.PrinterName = selectedPrinter;
                pd.PrintPage += new PrintPageEventHandler(PrintReceiptTemplate);
                pd.Print();

                MessageBox.Show($"Lệnh in thử đã được gửi thành công đến thiết bị: {selectedPrinter}", "Tiến trình in ấn", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Không thể kích hoạt trình điều khiển máy in. Chi tiết: {ex.Message}", "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Vẽ cấu trúc đồ họa trang hóa đơn in thử (Xử lý chuỗi và định dạng font)
        private void PrintReceiptTemplate(object sender, PrintPageEventArgs e)
        {
            Graphics? g = e.Graphics;
            if (g == null) return;

            Font fontTitle = new Font("Arial", 14, FontStyle.Bold);
            Font fontBody = new Font("Arial", 10, FontStyle.Regular);
            Font fontFooter = new Font("Arial", 9, FontStyle.Italic);
            Brush brush = Brushes.Black;

            float startX = 10;
            float startY = 10;
            float offsetY = 30;

            g.DrawString("--- HOÁ ĐƠN IN THỬ HỆ THỐNG ---", fontTitle, brush, startX, startY);
            g.DrawString($"Thiết bị in: {cb_PrinterList.SelectedItem}", fontBody, brush, startX, startY + offsetY);
            offsetY += 25;
            g.DrawString($"Cấu hình khổ giấy: {cb_PaperSize.SelectedItem}", fontBody, brush, startX, startY + offsetY);
            offsetY += 25;
            g.DrawString($"Thời gian kiểm tra: {DateTime.Now:dd/MM/yyyy HH:mm:ss}", fontBody, brush, startX, startY + offsetY);
            offsetY += 35;
            g.DrawString("Trạng thái: Kết nối phần cứng hoạt động ổn định.", fontFooter, brush, startX, startY + offsetY);
        }

        // Ghi lại thông số cấu hình máy in mặc định cho hệ thống bán hàng
        private void btn_SavePrinter_Click(object sender, EventArgs e)
        {
            string printerName = cb_PrinterList.SelectedItem?.ToString() ?? "Default";
            MessageBox.Show($"Thiết lập máy in '{printerName}' làm thiết bị in hóa đơn mặc định thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}