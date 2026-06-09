using System.Collections.Generic;
using System.Data;
using System.Linq; // Thêm thư viện này để dùng .ToList()
using Dapper;
using DTO;

namespace DAL
{
    public class SalesDetailsDAL
    {
        public bool Insert(SalesDetailsDTO detail)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO SalesDetails
                                 (InvoiceID,ProductID,SerialID,Quantity,UnitPrice,CostPrice)
                                 VALUES (@InvoiceID,@ProductID,@SerialID,@Quantity,@UnitPrice,@CostPrice)";
                return db.Execute(query, detail) > 0;
            }
        }

        public List<SalesDetailsDTO> GetByInvoice(int invoiceID)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<SalesDetailsDTO>(
                    "SELECT * FROM SalesDetails WHERE InvoiceID=@invoiceID", new { invoiceID }).AsList();
            }
        }

        // ===================================================================================
        // Hàm GetByInvoiceID dùng JOIN để lấy đầy đủ Mã Serial, Tên SP, Màu, Size
        // ===================================================================================
        public List<SalesDetailsDTO> GetByInvoiceID(int invoiceID)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                // Câu lệnh JOIN sang bảng Products và ProductItems để lấy đủ dữ liệu cho DTO
                string query = @"
                    SELECT 
                        sd.InvoiceID, 
                        sd.ProductID, 
                        sd.SerialID, 
                        sd.Quantity, 
                        sd.UnitPrice, 
                        sd.CostPrice,
                        pi.ItemCode,          -- Lấy Mã Serial
                        p.ProductName,        -- Lấy Tên SP
                        p.Color,              -- Lấy Màu
                        p.Size                -- Lấy Size
                    FROM SalesDetails sd
                    LEFT JOIN ProductItems pi ON sd.SerialID = pi.SerialID
                    LEFT JOIN Products p ON sd.ProductID = p.ProductID
                    WHERE sd.InvoiceID = @InvoiceID";

                return db.Query<SalesDetailsDTO>(query, new { InvoiceID = invoiceID }).ToList();
            }
        }
    }
}