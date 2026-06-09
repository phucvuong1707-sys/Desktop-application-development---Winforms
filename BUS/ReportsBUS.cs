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

        /// <summary>Lấy tóm tắt báo cáo trong khoảng thời gian (doanh thu, lợi nhuận, số hóa đơn, số sản phẩm, số bảo hành).</summary>
        public (decimal revenue, decimal profit, int invoiceCount, int productCount, int warrantyCount) GetSummaryByRange(DateTime from, DateTime to)
        {
            var invoices = _invoiceDAL.GetByDateRange(from, to);
            decimal revenue = 0, cost = 0;
            int productCount = 0;

            foreach (var inv in invoices)
            {
                revenue += inv.FinalAmount;
                var details = _detailDAL.GetByInvoice(inv.InvoiceID);
                cost += details.Sum(d => d.CostPrice * d.Quantity);
                productCount += details.Sum(d => d.Quantity);
            }

            // TODO: Lấy số bảo hành từ WarrantyDAL nếu cần
            int warrantyCount = 0;

            return (revenue, revenue - cost, invoices.Count, productCount, warrantyCount);
        }

        /// <summary>Lấy danh sách hóa đơn trong khoảng thời gian.</summary>
        public List<SalesInvoicesDTO> GetInvoicesByRange(DateTime from, DateTime to)
        {
            return _invoiceDAL.GetByDateRange(from, to);
        }
    }
}