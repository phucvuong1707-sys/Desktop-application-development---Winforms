# TechStore Management System - Hệ thống Quản lý Cửa hàng Điện tử

[cite_start]Dự án xây dựng ứng dụng máy tính (Desktop Application) toàn diện hỗ trợ quản lý chuỗi quy trình kinh doanh, vận hành kho, bán hàng và chăm sóc khách hàng chuyên biệt cho các cửa hàng thiết bị công nghệ điện tử[cite: 1, 2]. [cite_start]Hệ thống ưu tiên tối ưu hóa hiệu năng, độ chính xác cao và trải nghiệm thao tác thuận tiện cho người sử dụng[cite: 12].

---

## 🛠️ Công nghệ Sử dụng & Môi trường Phát triển

* [cite_start]**Nền tảng & Ngôn ngữ:** Windows Forms (WinForms) dựa trên nền tảng .NET 9.0 và ngôn ngữ C#[cite: 2].
* [cite_start]**Môi trường Phát triển (IDE):** JetBrains Rider[cite: 3].
* [cite_start]**Cơ sở Dữ liệu (Database):** MariaDB [cite: 4] [cite_start]kết hợp với Micro-ORM **Dapper** gọn nhẹ, tối ưu hóa tốc độ truy vấn data[cite: 35, 36].
* [cite_start]**Kiến trúc Thiết kế:** Mô hình Kiến trúc 3 lớp phân tách rõ ràng trách nhiệm (Separation of Concerns) bao gồm: GUI - BUS - DAL kết hợp vật chứa DTO[cite: 5].

---

## 📐 Kiến trúc Hệ thống (3-Layer Architecture)

[cite_start]Dự án được phân bổ mô-đun hóa thành 4 cụm thư mục/dự án thành phần nhằm bảo trì và mở rộng mã nguồn dễ dàng[cite: 5]:
1. [cite_start]**GUI Layer (Presentation):** Lớp giao diện người dùng hiển thị các biểu mẫu, tiếp nhận sự kiện click/gõ và phản hồi kết quả trực quan[cite: 32].
2. **BUS Layer (Business Logic):** Khối đầu não xử lý toàn bộ các quy tắc nghiệp vụ, ràng buộc logic, tính toán dòng tiền, mã hóa băm mật khẩu bảo mật và điều hướng dữ liệu.
3. [cite_start]**DAL Layer (Data Access):** Lớp tương tác tầng dữ liệu vật lý, quản lý trạng thái đóng/mở kết nối thông qua `DatabaseHelper` và truy vấn tự động mapping dữ liệu bằng Dapper[cite: 35, 36].
4. [cite_start]**DTO Layer (Data Transfer Object):** Định nghĩa các lớp thực thể (Entities/Models) đại diện cho các bảng dữ liệu, đóng vai trò làm vật chứa trung chuyển thông tin xuyên suốt giữa các tầng kiến trúc[cite: 5].

---

## ✨ Các Tính năng Nghiệp vụ Cốt lõi

[cite_start]Hệ thống đáp ứng trọn vẹn chu trình vận hành thực thực tế của một trung tâm bán lẻ thiết bị công nghệ điện tử lớn[cite: 1]:

### 1. Nghiệp vụ Nhập hàng & Quản lý Kho (Inbound & Inventory)
* [cite_start]**Phân loại hàng hóa thông minh:** Tách biệt rõ ràng phương thức quản lý giữa hàng theo Lô/Số lượng (Phụ kiện, cáp sạc) [cite: 8] [cite_start]và hàng quản lý đích danh theo ID định danh duy nhất (Serial/IMEI của Laptop, Điện thoại, CPU)[cite: 9].
* [cite_start]**Ràng buộc quy trình chặt chẽ:** Khi nhập thiết bị có ID, nhân viên bắt buộc phải quét mã vạch hoặc nhập đủ số lượng mã định danh Serial tương ứng[cite: 9].
* [cite_start]**Theo dõi vòng đời sản phẩm:** Quản lý cập nhật liên tục trạng thái thiết bị: *Trong kho*, *Đã bán*, *Đang bảo hành*, *Lỗi*[cite: 10].

### 2. Nghiệp vụ Bán hàng tốc độ cao (Sales / POS)
* [cite_start]**Tối ưu thao tác:** Giao diện quầy thu ngân ưu tiên tốc độ, hỗ trợ thực hiện hóa đơn nhanh hoàn toàn bằng phím tắt và máy quét vạch[cite: 12, 13].
* [cite_start]**Kiểm tra thời gian thực (Real-time):** Hệ thống tự động truy vấn DB để xác thực trạng thái máy "Trong kho" trước khi cho phép thanh toán, ngăn ngừa xuất nhầm mã Serial[cite: 15, 16].
* [cite_start]**Quản lý thông tin & Tích điểm:** Liên kết hóa đơn với số điện thoại khách hàng phục vụ tích lũy điểm thưởng và truy xuất bảo hành[cite: 17, 18].

### 3. Nghiệp vụ Tiếp nhận Bảo hành & Đổi trả (Warranty & Returns)
* [cite_start]**Tra cứu thần tốc:** Chỉ cần nhập SĐT khách hàng hoặc quét mã Serial máy, hệ thống tự động trả về toàn bộ thông tin ngày mua, nhân viên xử lý, hạn bảo hành và NCC gốc[cite: 22, 23].
* [cite_start]**Theo dõi quy trình (Work-flow):** Ghi nhận phiếu nhận máy lỗi và cập nhật trạng thái xử lý minh bạch (*Đang kiểm tra -> Đã gửi hãng -> Đã sửa xong -> Đã trả khách*)[cite: 24, 25].

### 4. Quản lý Ca làm việc & Kiểm soát Dòng tiền
* [cite_start]**Minh bạch tài chính:** Bắt buộc nhân viên khai báo số tiền mặt có sẵn đầu ca và đối chiếu kiểm đếm tiền mặt thực tế cuối ca để ghi nhận chênh lệch dòng tiền[cite: 28, 29, 30].
* [cite_start]**Báo cáo lợi nhuận chính xác:** Tự động tính toán Lợi nhuận gộp bằng thuật toán Nhập trước xuất trước (FIFO) hoặc Đích danh dựa theo Serial[cite: 31].

---

## 🖥️ Danh sách các Giao diện Hệ thống (GUI)

[cite_start]Hệ thống bao gồm 15 màn hình chức năng điều phối dòng việc chặt chẽ[cite: 33]:

| STT | Tên Form (C#) | Chức năng chi tiết | Phân quyền truy cập |
| :--- | :--- | :--- | :--- |
| 1 | **FormLogin** | [cite_start]Xác thực tài khoản người dùng, phân quyền hệ thống[cite: 34]. | [cite_start]Tất cả [cite: 34] |
| 2 | **FormDashboard** | [cite_start]Giao diện trang chủ (MDI Container) điều hướng hệ thống[cite: 34]. | [cite_start]Tất cả [cite: 34] |
| 3 | **FormSell** | [cite_start]Giao diện POS bán hàng, quét ID, tính tiền và in hóa đơn[cite: 34]. | [cite_start]Thu ngân, Quản lý [cite: 34] |
| 4 | **FormManageShift** | [cite_start]Khai báo đầu ca, kiểm chốt tiền mặt bàn giao ca[cite: 34]. | [cite_start]Thu ngân, Quản lý [cite: 34] |
| 5 | **FormGuest** | [cite_start]Quản lý tệp khách hàng, phân hạng thành viên VIP, tích điểm[cite: 34]. | [cite_start]Thu ngân, Quản lý [cite: 34] |
| 6 | **FormTradeIn** | [cite_start]Tiếp nhận thu cũ đổi mới, định giá thu mua máy lỗi/cũ[cite: 34]. | [cite_start]Kỹ thuật, Quản lý [cite: 34] |
| 7 | **FormGuarantee** | [cite_start]Tra cứu lịch sử mua hàng, tiếp nhận bảo hành thiết bị[cite: 34]. | [cite_start]Kỹ thuật, Quản lý [cite: 34] |
| 8 | **FormManageProduct**| [cite_start]Thêm/Sửa/Xóa thông tin cấu hình, danh mục, giá gốc sản phẩm[cite: 34].| [cite_start]Kho, Quản lý [cite: 34] |
| 9 | **FormIntoWarehouse**| [cite_start]Tạo phiếu nhập kho từ nhà cung cấp, tít mã ID sản phẩm vào kho[cite: 34].| [cite_start]Kho, Quản lý [cite: 34] |
| 10 | **FormCheckInventory**| [cite_start]Lập phiếu kiểm kê, đối chiếu số lượng thực tế với phần mềm[cite: 34].| [cite_start]Kho, Quản lý [cite: 34] |
| 11 | **FormPromotion** | [cite_start]Thiết lập chiến dịch khuyến mãi, mã Voucher, cấu hình giảm giá[cite: 34].| [cite_start]Quản lý [cite: 34] |
| 12 | **FormSupplier** | [cite_start]Lưu trữ danh bạ nhà cung cấp, theo dõi công nợ nhập hàng[cite: 34].| [cite_start]Quản lý [cite: 34] |
| 13 | **FormStaff** | [cite_start]Quản lý hồ sơ nhân viên, reset mật khẩu, theo dõi doanh số[cite: 34].| [cite_start]Quản lý [cite: 34] |
| 14 | **FormReport** | [cite_start]Biểu đồ doanh thu, thống kê hàng tồn, phân tích lợi nhuận[cite: 34].| [cite_start]Quản lý [cite: 34] |
| 15 | **FormSetting** | [cite_start]Cấu hình máy in hóa đơn, chuỗi kết nối máy chủ dữ liệu[cite: 34].| [cite_start]Admin (IT) [cite: 34] |

---

## 🗄️ Cấu trúc Cơ sở Dữ liệu (MariaDB Relational Schema)

[cite_start]Hệ thống lưu trữ cấu trúc liên kết chuẩn hóa dữ liệu thông qua 14 bảng quan hệ[cite: 35, 37]:

1. [cite_start]**Roles:** Lưu danh mục vai trò phân quyền người dùng (`Admin`, `QuanLy`, `ThuNgan`...)[cite: 37].
2. [cite_start]**Users:** Thông tin tài khoản nhân sự và liên kết quyền hạn `RoleID`[cite: 37].
3. [cite_start]**Customers:** Dữ liệu khách hàng, số điện thoại định danh, phân hạng loại và điểm số[cite: 37].
4. [cite_start]**Suppliers:** Danh sách nhà cung cấp và số dư công nợ lũy kế[cite: 37].
5. [cite_start]**ProductCategories:** Danh mục phân loại các nhóm hàng hóa[cite: 37].
6. [cite_start]**Products:** Định nghĩa thông số gốc của mặt hàng (Tên, Mã vạch, loại hàng có Serial hay không)[cite: 37].
7. [cite_start]**ProductItems:** Quản lý thực tế từng máy đích danh trong kho dựa theo số Serial/IMEI cụ thể[cite: 37].
8. [cite_start]**InboundReceipts:** Hóa đơn chứng từ gốc mỗi đợt nhập hàng từ phía đối tác[cite: 37].
9. [cite_start]**InboundDetails:** Chi tiết danh sách số lượng, đơn giá nhập của từng sản phẩm trong phiếu nhập[cite: 37].
10. [cite_start]**SalesInvoices:** Hóa đơn bán lẻ xuất cho khách hàng tại quầy[cite: 37].
11. [cite_start]**SalesDetails:** Chi tiết các mặt hàng hoặc mã Serial đích danh xuất bán trong hóa đơn[cite: 37].
12. [cite_start]**Shifts:** Nhật ký theo dõi ca làm việc, dòng tiền mặt bàn giao khớp ca[cite: 37].
13. [cite_start]**WarrantyClaims:** Hồ sơ lịch sử các ca tiếp nhận sửa chữa bảo hành sản phẩm lỗi[cite: 37].
14. [cite_start]**Promotions:** Lưu trữ các sự kiện giảm giá, thời hạn áp dụng của các chiến dịch ưu đãi[cite: 37].

---

## 🚀 Hướng dẫn Cài đặt & Khởi chạy Dự án

Để chạy ứng dụng ở môi trường máy bộ cục bộ (Local), vui lòng làm theo các bước sau:

### 1. Chuẩn bị Cơ sở Dữ liệu
1. Đảm bảo máy tính của bạn đã cài đặt dịch vụ **MariaDB Server** (Port mặc định: `3306`).
2. Sử dụng một công cụ quản lý cơ sở dữ liệu (Database Client) hoặc dùng trực tiếp tab **Database** tích hợp trong Rider để kết nối vào MariaDB.
3. Tạo một cơ sở dữ liệu trống tên là: `techstore`.
4. Mở cửa sổ **Query Console**, dán toàn bộ mã kịch bản SQL khởi tạo bảng cùng dữ liệu mẫu hệ thống và thực thi (`Execute`).

### 2. Cấu hình Ứng dụng trong JetBrains Rider
1. Tải dự án này về máy tính và khởi tạo bằng **JetBrains Rider**.
2. Định vị mở file `DatabaseHelper.cs` nằm bên trong thư mục dự án lớp **`DAL`**.
3. Cập nhật lại thuộc tính chuỗi cấu hình `ConnectionString` sao cho khớp thông tin tài khoản truy cập cơ sở dữ liệu cục bộ của bạn:
   ```csharp
   private static readonly string ConnectionString = "Server=localhost;Port=3306;Database=techstore;Uid=Tên_User;Pwd=Mật_Khẩu_Của_Bạn;Charset=utf8mb4;";
