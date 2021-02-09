using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PromotionPanier
{
    public interface IPromotionPanier
    {
        decimal GetDiscountPrice(decimal totalPrice);
    }
}
