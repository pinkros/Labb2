using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Butiken
{
    public class Produkt
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _pris;

        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        private string _enhet;

        public string Enhet { get; set; }


        private double _maengd;

        public double Maengd
        {
            get { return _maengd; }
            set { _maengd = value; }
        }

        public Produkt(string name, double pris, string enhet)
        {
            Name = name;
            Pris = pris;
            Enhet = enhet;
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

            var pris = vara.Pris * amount;

            Console.WriteLine($"Du har köpt {amount} {vara.Enhet} {vara.Name} för {pris}SEK");
        }

        public override string ToString()
        {
            return $"{Name}: {Pris}/{Enhet}";
        }
    }
}
