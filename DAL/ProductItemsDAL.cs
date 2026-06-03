using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class ProductItemsDAL
    {
        /// <summary>Kiểm tra serial có đang "Trong kho" không (dùng khi bán hàng)</summary>
        public ProductItemsDTO GetByItemCode(string itemCode)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.QueryFirstOrDefault<ProductItemsDTO>(
                    "SELECT * FROM ProductItems WHERE ItemCode=@itemCode", new { itemCode });
            }
        }

        public List<ProductItemsDTO> GetByProduct(int productID)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<ProductItemsDTO>(
                    "SELECT * FROM ProductItems WHERE ProductID=@productID", new { productID }).AsList();
            }
        }

        public int Insert(ProductItemsDTO item)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO ProductItems (ProductID,ItemCode,Status,InboundID)
                                 VALUES (@ProductID,@ItemCode,@Status,@InboundID);
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, item);
            }
        }

        public bool UpdateStatus(int itemID, string status)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Execute(
                    "UPDATE ProductItems SET Status=@status WHERE ItemID=@itemID",
                    new { status, itemID }) > 0;
            }
        }
    }
}