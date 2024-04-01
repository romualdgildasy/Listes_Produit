using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produit

{
    public class Article
    {
        public string Nom { get; set; }
        public int Vendu { get; set; }
        public int Qualite { get; set; }

        public Article(string nom, int vendu, int qualité)
        {
            Nom = nom;
            Vendu = vendu;
            Qualite = qualité;
        }

        public Article()
        {

        }
    }

    public class Store
    {
        public IList<Article> Articles;

        public Store(IList<Article> articles)
        {
            Articles = articles;
        }

        public void UpdateQuality()
        {
            foreach (Article article in Articles)
            {
                if (article.Nom != "Sulfuras, Hand of Ragnaros")
                {
                    article.Vendu--;

                    if (article.Nom == "Aged Brie")
                    {
                        UpdateAgedBrieQuality(article);
                    }
                    else if (article.Nom == "Backstage passes to a TAFKAL80ETC concert")
                    {
                        UpdateBackstagePassesQuality(article);
                    }
                    else if (article.Nom.StartsWith("Conjured"))
                    {
                        UpdateConjuredItemQuality(article);
                    }
                    else
                    {
                        UpdateNormalItemQuality(article);
                    }
                }
            }
        }

        private void UpdateAgedBrieQuality(Article article)
        {
            if (article.Qualite < 50)
            {
                article.Qualite++;
            }

            if (article.Vendu < 0 && article.Qualite < 50)
            {
                article.Qualite++;
            }
        }

        private void UpdateBackstagePassesQuality(Article article)
        {
            if (article.Qualite < 50)
            {
                article.Qualite++;

                if (article.Vendu < 11 && article.Qualite < 50)
                {
                    article.Qualite++;
                }

                if (article.Vendu < 6 && article.Qualite < 50)
                {
                    article.Qualite++;
                }
            }

            if (article.Vendu < 0)
            {
                article.Qualite = 0;
            }
        }

        private void UpdateConjuredItemQuality(Article article)
        {
            if (article.Qualite > 0)
            {
                article.Qualite -= 2;
            }

            if (article.Vendu < 0 && article.Qualite > 0)
            {
                article.Qualite -= 2;
            }
        }

        private void UpdateNormalItemQuality(Article article)
        {
            if (article.Qualite > 0)
            {
                article.Qualite--;
            }

            if (article.Vendu < 0 && article.Qualite > 0)
            {
                article.Qualite--;
            }
        }
    }


}