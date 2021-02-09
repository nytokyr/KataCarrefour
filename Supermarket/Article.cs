namespace Supermarket
{
    public class Article : IArticle
    {
        readonly IPromotionForArticle _promo;
        
        public Article()
        {

        }

        public Article(IPromotionForArticle promotion)
        {
            _promo = promotion;
        }
        public int Nombre { get; set; }
        public int PoidsEnGrammes { get; set; }
        public decimal PrixUnitaire { get; set; }

        public decimal GetPrix()
        {
            if (_promo is object)
            {
                return _promo
                    .BindArticle(this)
                    .GetPrix();
            }
            else
            {
                if (Nombre > 0)
                    return Nombre * PrixUnitaire;
                else
                    return PoidsEnGrammes * PrixUnitaire;
            }
        }
    }
}
