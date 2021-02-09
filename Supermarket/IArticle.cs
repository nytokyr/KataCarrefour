namespace Supermarket
{
    public interface IArticle
    {
        int Nombre { get;  set; }
        int PoidsEnGrammes { get;  set; }
        decimal PrixUnitaire { get;  set; }

        decimal GetPrix();
      
    }
}