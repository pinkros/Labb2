using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butiken
{
    public class Kund
    {
        public string Name { get; private set; }

        private string Password { get; set; }

        public double Rabatt { get; set; }

        private List<Produkt> _cart;
        public List<Produkt> Cart { get { return _cart; } }

        public Kund(string name, string password)
        {
            Name = name;
            Password = password;
            _cart = new List<Produkt>();
        }
        public override string ToString()
        {
            return $"Kund: {Name} Lösenord: {Password}";
        }

        public void ViewCart(List<Produkt> cart)
        {
            var total = 0.0;
            foreach (var produkt in cart)
            {
                var radPris = produkt.Maengd * produkt.Pris;
                Console.WriteLine($"{produkt.Maengd} {produkt.Enhet} {produkt.Name}  {radPris}");
                total += radPris;
            }

            Console.WriteLine($"Total kostnad: {total} kr");
        }
    }

    
}
