using System;
using System.Collections.Generic;
using BUS;
using DAL;
using DTO;

namespace BUS
{
    public class ShiftsBUS
    {
        private readonly ShiftsDAL _dal = new ShiftsDAL();
        private readonly SalesInvoicesDAL _invoiceDAL = new SalesInvoicesDAL();

        public ShiftsDTO? GetOpenShift(int userID) =>
            _dal.GetOpenShiftByUser(userID);

        public List<ShiftsDTO> GetAllShifts()
        {
            return _dal.GetAllShifts();
        }

        public (bool success, string error) OpenShift(decimal openingCash)
        {
            var existing = _dal.GetOpenShiftByUser(CurrentUser.UserID);
            if (existing != null)
                return (false, "Bạn đang có ca chưa chốt. Vui lòng chốt ca cũ trước.");

            var shift = new ShiftsDTO
            {
                ShiftCode = $"CA{DateTime.Now:yyyyMMddHHmm}",
                UserID = CurrentUser.UserID,
                OpeningCash = openingCash
            };

            int id = _dal.OpenShift(shift);
            if (id <= 0) return (false, "Mở ca thất bại.");

            CurrentUser.ShiftID = id;
            return (true, null!);
        }

        public (bool success, string error) CloseShift(decimal actualCash, string note)
        {
            var shift = _dal.GetOpenShiftByUser(CurrentUser.UserID);
            if (shift == null)
                return (false, "Không tìm thấy ca đang mở.");

            // Tính tổng tiền mặt thu được trong ca
            var invoices = _invoiceDAL.GetByShift(CurrentUser.UserID, DateTime.Today);
            decimal cashCollected = 0;
            foreach (var inv in invoices)
                if (inv.PaymentMethod == "Tiền mặt")
                    cashCollected += inv.FinalAmount;

            shift.ExpectedCash = shift.OpeningCash + cashCollected;
            shift.ClosingCash = actualCash;
            shift.DifferenceAmount = actualCash - shift.ExpectedCash;
            shift.DifferenceNote = note;

            return (_dal.CloseShift(shift), "Chốt ca thất bại.");
        }
    }
}