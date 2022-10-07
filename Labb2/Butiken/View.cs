using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butiken
{
    internal class View
    {
        public void LogInMenu()
        {
            Console.WriteLine();
        }

        public void ShopMenu()
        {

        }

        public void BuyMenu(List<Produkt> varor)
        {
            foreach (Produkt produkt in varor)
            {
                Console.WriteLine($"{produkt.Name}\t{produkt.Pris} kr/{produkt.Enhet}");
            }
        }
    }
}
