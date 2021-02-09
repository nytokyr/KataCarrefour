using Supermarket;
using Supermarket.PromotionArticles;
using System;
using Xunit;

namespace Carrefour.Tests
{
    public class ShouldArticle
    {
        [Fact]
        public void GetPrix_return_10_when_5_articles_of_2_euros_added()
        {
            var article = new Article { PrixUnitaire = 2, Nombre = 5 };

            Assert.Equal(10, article.GetPrix());
        }

        [Fact]
        public void GetPrix_return_2_when_3_articles_of_1_euro_added()
        {
            var promotion = new Get_2_And_1_Offered();
            var unitPrice = 1;
            var article = new Article(promotion) { PrixUnitaire = unitPrice, Nombre = 3 };

            Assert.Equal(2, article.GetPrix());
        }

        [Fact]
        public void GetPrix_return_price_of_4_when_take_6_items()
        {
            var promotion = new Get_2_And_1_Offered();
            var unitPrice = 1;
            var priceOf4 = unitPrice * 4;
            var article = new Article(promotion) { PrixUnitaire = unitPrice, Nombre = 6 };

            Assert.Equal(priceOf4, article.GetPrix());
        }

        [Fact]
        public void GetPrix_has_5_percent_discount_when_buy_2000_grammes()
        {
            var unitPricePerGram = 10;
            var promotion = new Get_5_Percent_Discount_ForEach_2000_Grams();
            var article = new Article(promotion) { PrixUnitaire = unitPricePerGram, PoidsEnGrammes = 2000 };

            Assert.Equal(9.5m * 2000, article.GetPrix());
        }

        [Fact]
        public void GetPrix_apply_5_percent_discount_foreach_2000_grammes_and_apply_normal_price_on_the_rest()
        {
            var unitPricePerGram = 10;
            var discountPrice = 9.5m;
            var promotion = new Get_5_Percent_Discount_ForEach_2000_Grams();
            var article = new Article(promotion) { PrixUnitaire = unitPricePerGram, PoidsEnGrammes = 4500 };

            Assert.Equal((discountPrice * 2000) + (discountPrice * 2000) + (unitPricePerGram * 500), article.GetPrix());
        }
    }
}
