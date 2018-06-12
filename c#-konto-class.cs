using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontoanwendungen
{
    class CKonto
    {
        private double kontostand;

        public CKonto() {
            kontostand = 5000.00;
        }

        public double getKontostand() {
            return kontostand;
        }

        public void Einzahlung(double einzahlung) {
            kontostand += einzahlung;
        }

        public void Auszahelung(double auszahlung)
        {
            kontostand -= auszahlung;
        }
    }
}
