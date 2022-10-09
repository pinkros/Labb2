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
            Console.WriteLine("Vad vill du göra?\n1. Logga in\n2. Registrera ny användare" +
                              "\n\n\n0.Avsluta");
        }

        public void ShopMenu()
        {
            Console.WriteLine("1. Handla\n2. Se kundvagn\n3. Gå till kassan\n\n\n4. Logga ut");
        }

        public void BuyMenu(List<Produkt> varor)
        {
            var i = 1;
            Console.WriteLine("Vad vill du köpa?");

            foreach (Produkt produkt in varor)
            {
                Console.WriteLine($"{i}. {produkt}");
                i++;
            }
        }
    }
}
