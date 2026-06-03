using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class InboundReceiptsDAL
    {
        public int Insert(InboundReceiptsDTO receipt)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO InboundReceipts
                                 (InboundCode,SupplierID,UserID,TotalQuantity,TotalAmount,ReceiptDate,Note)
                                 VALUES (@InboundCode,@SupplierID,@UserID,@TotalQuantity,@TotalAmount,NOW(),@Note);
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, receipt);
            }
        }

        public List<InboundReceiptsDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<InboundReceiptsDTO>(
                    "SELECT * FROM InboundReceipts ORDER BY ReceiptDate DESC").AsList();
            }
        }
    }
}