using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butiken
{
    public abstract class Kund
    {
        public string Name { get; private set; }

        private string Password { get; }

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
            return "";
        }
    }

    
}
