namespace Supermarket
{
    public interface IPromotionForArticle : IArticle
    {
        IArticle BindArticle(IArticle articles)
        {
            PoidsEnGrammes = articles.PoidsEnGrammes;
            Nombre = articles.Nombre;
            PrixUnitaire = articles.PrixUnitaire;
            return this;
        }
    }
}