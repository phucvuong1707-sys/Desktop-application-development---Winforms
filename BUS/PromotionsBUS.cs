using DAL;
using DTO;

namespace BUS
{
    public class PromotionsBUS
    {
        private readonly PromotionsDAL _dal = new PromotionsDAL();

        /// <summary>
        /// Áp dụng mã khuyến mãi, trả về số tiền được giảm.
        /// </summary>
        public (decimal discount, string error) ApplyPromoCode(string promoCode, decimal totalAmount)
        {
            if (string.IsNullOrWhiteSpace(promoCode))
                return (0, "Mã khuyến mãi không được để trống.");

            var promo = _dal.GetActiveByCode(promoCode);
            if (promo == null)
                return (0, "Mã không hợp lệ hoặc đã hết hạn.");

            decimal discount = promo.DiscountPercent > 0
                ? totalAmount * promo.DiscountPercent / 100
                : promo.DiscountAmount;

            return (discount, null);
        }

        public (bool success, string error) Insert(PromotionsDTO promo)
        {
            if (string.IsNullOrWhiteSpace(promo.PromoCode))
                return (false, "Mã khuyến mãi không được để trống.");
            if (promo.EndDate <= promo.StartDate)
                return (false, "Ngày kết thúc phải sau ngày bắt đầu.");

            return (_dal.Insert(promo), "Thêm thất bại.");
        }

        public bool SetActive(int id, bool isActive) => _dal.SetActive(id, isActive);
    }
}