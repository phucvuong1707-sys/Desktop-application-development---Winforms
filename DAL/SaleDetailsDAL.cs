using System.Collections.Generic;
using System.Data;
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
    }
}