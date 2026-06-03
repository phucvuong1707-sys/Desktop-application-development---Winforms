using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class InboundDetailsDAL
    {
        public bool Insert(InboundDetailsDTO detail)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO InboundDetails (InboundID,ProductID,Quantity,UnitCost,TotalCost)
                                 VALUES (@InboundID,@ProductID,@Quantity,@UnitCost,@TotalCost)";
                return db.Execute(query, detail) > 0;
            }
        }

        public List<InboundDetailsDTO> GetByInbound(int inboundID)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<InboundDetailsDTO>(
                    "SELECT * FROM InboundDetails WHERE InboundID=@inboundID", new { inboundID }).AsList();
            }
        }
    }
}