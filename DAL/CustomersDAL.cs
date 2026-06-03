using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class CustomersDAL
    {
        public CustomersDTO GetByPhone(string phone)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.QueryFirstOrDefault<CustomersDTO>(
                    "SELECT * FROM Customers WHERE Phone=@phone", new { phone });
            }
        }

        public List<CustomersDTO> GetAll()
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.Query<CustomersDTO>("SELECT * FROM Customers").AsList();
            }
        }

        public int Insert(CustomersDTO customer)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO Customers (Phone,FullName,Address,Email,CustomerType,TotalPoints,CreatedAt)
                                 VALUES (@Phone,@FullName,@Address,@Email,@CustomerType,0,NOW());
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, customer);
            }
        }

        public bool Update(CustomersDTO customer)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"UPDATE Customers SET FullName=@FullName, Address=@Address,
                                 Email=@Email, CustomerType=@CustomerType, TotalPoints=@TotalPoints
                                 WHERE CustomerID=@CustomerID";
                return db.Execute(query, customer) > 0;
            }
        }
    }
}