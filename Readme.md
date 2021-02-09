# Proposition de Kata
Si tu avais a modéliser en objet, le logiciel de pricing de  carrefour et surtout les promos:

- 2 produits achetés donc 3eme gratuit
- montant total > 1000 donc -10% en promo
- 2kg achetés  = -5%
- -10% sur certains produits

La solution ne prend pas encore en compte :
- L'enchainement de plusieurs "promotionPanier" sur le prix total (montant total > 1000 donc -10% en promo, puis montant total > 500 donc reduction de 50€, si tu es membre remise de 10€, ... )
- Bundling : Prendre 2 brosses à dent et avoir un dentifrice gratuit 
