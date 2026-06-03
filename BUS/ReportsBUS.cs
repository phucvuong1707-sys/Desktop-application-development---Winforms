using System;
using System.Collections.Generic;
using System.Linq;
using DAL;
using DTO;

namespace BUS
{
    public class ReportsBUS
    {
        private readonly SalesInvoicesDAL _invoiceDAL = new SalesInvoicesDAL();
        private readonly SalesDetailsDAL _detailDAL = new SalesDetailsDAL();

        /// <summary>Doanh thu + lợi nhuận gộp trong ngày của một nhân viên.</summary>
        public (decimal revenue, decimal profit) GetDailySummary(int userID, DateTime date)
        {
            var invoices = _invoiceDAL.GetByShift(userID, date);
            decimal revenue = 0, cost = 0;

            foreach (var inv in invoices)
            {
                revenue += inv.FinalAmount;
                var details = _detailDAL.GetByInvoice(inv.InvoiceID);
                cost += details.Sum(d => d.CostPrice * d.Quantity);
            }

            return (revenue, revenue - cost);
        }
    }
}