using Supermarket.PromotionPanier;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    public class Panier
    {
        IPromotionPanier _promotion;
        public List<IArticle> Items { get; set; } = new List<IArticle>();
        public void AddItem(IArticle articles)
        {
            Items.Add(articles);
        }

        public void ApplyDiscount(IPromotionPanier promotion)
        {
            _promotion = promotion;
        }

        public decimal GetPrixTotal()
        {
            var totalPrice = Items.Sum(_ => _.GetPrix());
            decimal finalPrice = totalPrice;
            if (_promotion is object)
            {
                finalPrice -= _promotion.GetDiscountPrice(totalPrice);
            }
            return finalPrice;
        }
    }
}
