using System;
using System.Collections.Generic;
using System.Text;

namespace Supermarket
{
    public class Get_2_And_1_Offered : IPromotionForArticle
    {
        public int Nombre { get; set; }
        public int PoidsEnGrammes { get; set; }
        public decimal PrixUnitaire { get; set; }

        public decimal GetPrix()
        {
            int getTwoAndOneOffered = (2 * Nombre / 3 + Nombre % 3);
            return PrixUnitaire * getTwoAndOneOffered;
        }
    }
}
