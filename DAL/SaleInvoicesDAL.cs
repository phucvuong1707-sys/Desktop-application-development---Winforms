using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using DTO;

namespace DAL
{
    public class SalesInvoicesDAL
    {
        public int Insert(SalesInvoicesDTO invoice)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = @"INSERT INTO SalesInvoices
                                 (InvoiceCode,CustomerID,UserID,TotalAmount,DiscountAmount,FinalAmount,PaymentMethod,SaleDate)
                                 VALUES (@InvoiceCode,@CustomerID,@UserID,@TotalAmount,@DiscountAmount,@FinalAmount,@PaymentMethod,NOW());
                                 SELECT LAST_INSERT_ID();";
                return db.ExecuteScalar<int>(query, invoice);
            }
        }

        public List<SalesInvoicesDTO> GetByShift(int userID, DateTime date)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM SalesInvoices WHERE UserID=@userID AND DATE(SaleDate)=DATE(@date)";
                return db.Query<SalesInvoicesDTO>(query, new { userID, date }).AsList();
            }
        }

        public SalesInvoicesDTO GetByCode(string code)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                return db.QueryFirstOrDefault<SalesInvoicesDTO>(
                    "SELECT * FROM SalesInvoices WHERE InvoiceCode=@code", new { code });
            }
        }

        public List<SalesInvoicesDTO> GetByDateRange(DateTime from, DateTime to)
        {
            using (IDbConnection db = DatabaseHelper.GetConnection())
            {
                string query = "SELECT * FROM SalesInvoices WHERE SaleDate >= @from AND SaleDate <= @to";
                return db.Query<SalesInvoicesDTO>(query, new { from, to }).AsList();
            }
        }
    }
}