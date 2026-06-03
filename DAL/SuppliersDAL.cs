using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class SuppliersDAL
    {
        public List<SuppliersDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<SuppliersDTO>("SELECT * FROM Suppliers").AsList();
            }
        }

        public int Insert(SuppliersDTO supplier)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Suppliers (SupplierCode,SupplierName,Phone,Address,Debt,CreatedAt)
                                 VALUES (@SupplierCode,@SupplierName,@Phone,@Address,0,NOW());
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, supplier);
            }
        }

        public bool Update(SuppliersDTO supplier)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Suppliers SET SupplierName=@SupplierName,
                                 Phone=@Phone, Address=@Address, Debt=@Debt
                                 WHERE SupplierID=@SupplierID";
                return db.Execute(query, supplier) > 0;
            }
        }
    }
}