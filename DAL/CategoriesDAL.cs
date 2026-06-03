using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class CategoriesDAL
    {
        public List<CategoriesDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<CategoriesDTO>("SELECT * FROM ProductCategories").AsList();
            }
        }

        public int Insert(CategoriesDTO category)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO ProductCategories (CategoryName, Description, Status)
                                 VALUES (@CategoryName, @Description, @Status);
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, category);
            }
        }

        public bool Update(CategoriesDTO category)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE ProductCategories SET CategoryName=@CategoryName,
                                 Description=@Description, Status=@Status
                                 WHERE CategoryID=@CategoryID";
                return db.Execute(query, category) > 0;
            }
        }

        public bool Delete(int id)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Execute("DELETE FROM ProductCategories WHERE CategoryID=@id", new { id }) > 0;
            }
        }
    }
}