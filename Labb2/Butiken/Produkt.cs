using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Butiken
{
    public abstract class Produkt
    {
        private double _pris;
        public double Pris
        {
            get { return _pris; }
            set { _pris = value; }
        }

        

        private string _enhet;
        private string _name;

        private double _maengd;

        public double Maengd
        {
            get { return _maengd; }
            set { _maengd = value; }
        }

        public abstract void LaeggIVagn();

    }
}
