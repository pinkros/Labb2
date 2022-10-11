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
            Console.WriteLine("Vad vill du göra?\n" +
                              "1. Logga in\n" +
                              "2. Registrera ny användare" +
                              "\n\n\n0.Avsluta");
        }

        public void ShopMenu(Kund kund)
        {
            Console.WriteLine(
                $"Välkommen,{kund.Name}! Vad vill du göra idag?\n" +
                "1. Handla\n" +
                "2. Se kundvagn\n" +
                "3. Gå till kassan\n" +
                "\n\n0. Logga ut");
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
