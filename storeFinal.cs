using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produit
{
    class FinalStore
    {
        public static void Main(string[] agrs)
        {
            IList<Article> articles = new List<Article>
        {
           new Article  { Nom = "Aged Brie", Vendu = 2, Qualite = 0 },
            new Article  { Nom = "Backstage passes to a TAFKAL80ETC concert", Vendu = 15, Qualite = 20 },
             new Article  { Nom = "Sulfuras, Hand of Ragnaros", Vendu = 0, Qualite = 80 },
             new Article  { Nom = "Conjured Mana Cake", Vendu = 3, Qualite = 6 }
        };

            Store store = new Store(articles);

            for (int day = 0; day < 10; day++)
            {
                Console.WriteLine("Avant la mise à jour de la qualité :");
                Console.WriteLine("Nom, Vendu, Qualite");

                foreach (Article article in articles)
                {
                    Console.WriteLine("");
                }

                store.UpdateQuality();
            }
        }
    }
}
