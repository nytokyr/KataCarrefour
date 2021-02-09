using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PromotionArticles
{
    public class Get_5_Percent_Discount_ForEach_2000_Grams : IPromotionForArticle
    {
        public int Nombre { get; set; }
        public int PoidsEnGrammes { get; set; }
        public decimal PrixUnitaire { get; set; }       

        public decimal GetPrix()
        {
            const int poidsDiscount = 2000;
            const decimal discount = 5m / 100;
            var lotOf2000Grams = PoidsEnGrammes / poidsDiscount;
            var reste = PoidsEnGrammes % poidsDiscount;
            var prixDiscount = PrixUnitaire - (PrixUnitaire * discount);
            return (prixDiscount * lotOf2000Grams * poidsDiscount) + (reste * PrixUnitaire);
        }
    }
}
