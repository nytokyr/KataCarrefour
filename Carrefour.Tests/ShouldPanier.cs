using Supermarket;
using Supermarket.PromotionArticles;
using Supermarket.PromotionPanier;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Carrefour.Tests
{
    public class ShouldPanier
    {
        [Fact]
        public void GetPrixTotal_returns_sum_of_article_price_when_no_discount_for_panier()
        {
            var sut = new Panier();
            sut.AddItem(new Article { PrixUnitaire = 10, Nombre = 5 });
            sut.AddItem(new Article { PrixUnitaire = 3, Nombre = 2 });
            sut.AddItem(new Article { PrixUnitaire = 5, Nombre = 1 });
            Assert.Equal(50 + 6 + 5, sut.GetPrixTotal());
        }

        [Fact]
        public void GetPrixTotal_apply_10_percent_discount_on_1_article_in_panier()
        {
            var sut = new Panier();
            var promotion = new Get_10_Percent_Discount();
            sut.AddItem(new Article(promotion) { PrixUnitaire = 10, Nombre = 5 });
            sut.AddItem(new Article { PrixUnitaire = 3, Nombre = 2 });
            sut.AddItem(new Article { PrixUnitaire = 5, Nombre = 1 });
            Assert.Equal(45 + 6 + 5, sut.GetPrixTotal());
        }

        [Fact]
        public void GetPrixTotal_apply_10_percent_discount_when_total_great_than_1000()
        {
            var sut = new Panier();
            sut.ApplyDiscount(new Get_10_Percent_Discount_When_Total_Price_Great_Than_1000());
            sut.AddItem(new Article { PrixUnitaire = 100, Nombre = 11 });
            Assert.Equal(1100 - (1100 * 10m / 100), sut.GetPrixTotal());
        }
    }
}
