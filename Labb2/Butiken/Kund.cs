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
            var cart = string.Empty;
            var totalPrice = 0.0;

            foreach (var produkt in _cart)
            {
                var radPris = produkt.Maengd * produkt.Pris;
                cart += $"{produkt.Maengd} {produkt.Enhet} {produkt.Name}  {radPris} kr\n";
                totalPrice += radPris;
            }

            cart += $"Total kostnad: {Math.Round(totalPrice, 2)} kr";

            return $"Kund: {Name} Lösenord: {Password}\n Kundvagn:\n{cart} ";
        }

        public void ViewCart(List<Produkt> cart)
        {
            var totalPrice = 0.0;
            foreach (var produkt in cart)
            {
                var radPris = produkt.Maengd * produkt.Pris;
                Console.WriteLine($"{produkt.Maengd} {produkt.Enhet} {produkt.Name}  {radPris} kr");
                totalPrice += radPris;
            }

            Console.WriteLine($"Total kostnad: {totalPrice} kr");
        }

        public void LaeggIVagn(Produkt vara, double amount, List<Produkt> kundvagn)
        {
            if (kundvagn.Contains(vara))
            {
                for (int i = 0; i < kundvagn.Count; i++)
                {
                    if (kundvagn[i].Name == vara.Name)
                    {
                        kundvagn[i].Maengd += amount;
                        break;
                    }
                }
            }

            else
            {
                vara.Maengd = amount;
                kundvagn.Add(vara);
            }

            var pris = Math.Round(vara.Pris * amount, 2) ;

            Console.WriteLine($"Du har köpt {amount} {vara.Enhet} {vara.Name} för {pris}SEK");
        }

        public bool VerifieraPassword(string? pw)
        {
            if (pw == Password)
            {
                return true;
            }
            return false;
        }
    }

    
}
