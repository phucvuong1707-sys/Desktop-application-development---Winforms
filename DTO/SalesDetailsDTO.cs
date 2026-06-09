namespace DTO
{
    public class SalesDetailsDTO
    {
        // Các thuộc tính gốc của bạn (thường dùng để lưu xuống Database)
        public int InvoiceID { get; set; }
        public int ProductID { get; set; }
        public int? SerialID { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal CostPrice { get; set; }
        public string ItemCode { get; set; }
        public string ProductName { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}