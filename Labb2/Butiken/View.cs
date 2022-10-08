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
            var i = 1;
            Console.WriteLine("Vad vill du köpa?");
            foreach (Produkt produkt in varor)
            {
                var nameof = char.ToUpper(produkt.Name[0]) + produkt.Name.Substring(1);
                //Console.WriteLine($"{i}. {nameof}\t {produkt.Pris} kr/{produkt.Enhet}");
                Console.WriteLine($"{i}. {produkt}");
                i++;
            }
        }
    }
}
