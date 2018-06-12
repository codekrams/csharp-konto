using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontoanwendungen
{
    class Program
    {
        private static double sumein;
        private static double sumaus;

        static void Main(string[] args)
        {
            int eingabe = 0;
            List<double> umsaetze = new List<double>();
            CKonto konto = new CKonto();
            umsaetze.Add(konto.getKontostand());
            Console.WriteLine("Saldo: " + konto.getKontostand());

            try { 
            do
            {
                eingabe=menueAnzeigen();
                if (eingabe != 0) { 
                aktivitaetsAuswahl(eingabe, konto, umsaetze);
                }


            } while (eingabe != 0);

            Console.WriteLine("Neuer Saldo: " + konto.getKontostand());

            Console.WriteLine("Gesamteinzahlungen: " + sumein);
            Console.WriteLine("Gesamtauszahlungen: " + sumaus);

            Console.WriteLine("Gesamtumsätze:");
            foreach (double u in umsaetze) {
                    Console.WriteLine(u);
                }
                

            }
            catch (Exception ex) //wenn ein Fehler auftritt, wird er aufgefangen
            {
                Console.WriteLine("Schwerer Fehler aufgetreten");
            }
            finally
            {
                Console.WriteLine("Programm wird geschlossen");
            }
            Console.ReadKey();
        }

        private static int menueAnzeigen () {
            Console.WriteLine("Einzahlen (1) \nAuszahlen(2)\nBeenden (0)");
            int eingabe = Convert.ToInt32(Console.ReadLine());
            return eingabe;
        }

        private static void aktivitaetsAuswahl(int eingabe, CKonto konto, List<double> liste) {
            if (eingabe == 1)
            {
                Console.WriteLine("Einzahlungsbetrag: ");
                double einzahlung = Convert.ToDouble(Console.ReadLine());
                konto.Einzahlung(einzahlung);
                Console.WriteLine(konto.getKontostand().ToString());
                sumein += einzahlung;
                liste.Add(einzahlung);
                liste.Add(konto.getKontostand());
            }
            else if (eingabe == 2) {
                Console.WriteLine("Auszahlungsbetrag: ");
                double auszahlung = Convert.ToDouble(Console.ReadLine());
                konto.Auszahelung(auszahlung);
                Console.WriteLine(konto.getKontostand().ToString());
                sumaus += auszahlung;
                liste.Add(auszahlung);
                liste.Add(konto.getKontostand());

            }
        }

    }
}
