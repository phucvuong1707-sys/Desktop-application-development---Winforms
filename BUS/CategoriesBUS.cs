using System.Collections.Generic;
using DAL;
using DTO;

namespace BUS
{
    public class CategoriesBUS
    {
        private readonly CategoriesDAL _dal = new CategoriesDAL();

        public List<CategoriesDTO> GetAll() => _dal.GetAll();

        public (bool success, string error) Insert(CategoriesDTO category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
                return (false, "Tên danh mục không được để trống.");

            _dal.Insert(category);
            return (true, null);
        }

        public (bool success, string error) Update(CategoriesDTO category)
        {
            if (string.IsNullOrWhiteSpace(category.CategoryName))
                return (false, "Tên danh mục không được để trống.");

            return (_dal.Update(category), "Cập nhật thất bại.");
        }

        public (bool success, string error) Delete(int id)
        {
            // TODO: kiểm tra còn sản phẩm thuộc danh mục này không
            return (_dal.Delete(id), "Xóa thất bại.");
        }
    }
}