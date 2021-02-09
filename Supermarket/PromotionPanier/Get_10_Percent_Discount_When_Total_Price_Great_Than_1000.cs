using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PromotionPanier
{
    public class Get_10_Percent_Discount_When_Total_Price_Great_Than_1000 : IPromotionPanier
    {
        public decimal GetDiscountPrice(decimal totalPrice)
        {
            if (totalPrice > 1000)
                return totalPrice * 10 / 100;
            return totalPrice;
        }
    }
}
