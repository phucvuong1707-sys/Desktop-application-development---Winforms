using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class SuppliersBUS
    {
        private readonly SuppliersDAL _dal = new SuppliersDAL();

        public List<SuppliersDTO> GetAll() => _dal.GetAll();

        public (bool success, string error) Insert(SuppliersDTO supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
                return (false, "Tên nhà cung cấp không được để trống.");
            if (string.IsNullOrWhiteSpace(supplier.Phone))
                return (false, "Số điện thoại không được để trống.");

            _dal.Insert(supplier);
            return (true, null);
        }

        public (bool success, string error) Update(SuppliersDTO supplier)
        {
            if (string.IsNullOrWhiteSpace(supplier.SupplierName))
                return (false, "Tên nhà cung cấp không được để trống.");

            return (_dal.Update(supplier), "Cập nhật thất bại.");
        }
    }
}