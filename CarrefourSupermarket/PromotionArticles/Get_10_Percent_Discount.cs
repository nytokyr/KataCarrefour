using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket.PromotionArticles
{
    public class Get_10_Percent_Discount : IPromotionForArticle
    {
        public int Nombre { get; set; }
        public int PoidsEnGrammes { get; set; }
        public decimal PrixUnitaire { get; set; }

        public decimal GetPrix()
        {
            decimal price = Nombre * PrixUnitaire;
            return price - (price * 10m / 100);
        }
    }
}
