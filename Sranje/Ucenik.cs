using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sranje
{
    internal class Ucenik
    {
        public static int brojUcenika;
        string ime;
        string prezime;
        string skola;
        string tipMature;
        string jezik;
        string predmet1;
        string predmet2;
        string predmet3;

        public Ucenik(string l_ime, string l_prezime, string l_skola, string l_tipMature, string l_jezik, string l_predmet1, string l_predmet2, string l_predmet3)
        {
            brojUcenika++;
            ime = l_ime;
            prezime = l_prezime;
            skola = l_skola;
            tipMature = l_tipMature;
            jezik = l_jezik;
            predmet1 = l_predmet1;
            predmet2 = l_predmet2;
            predmet3 = l_predmet3;
        }

        public override string ToString()
        {
            return $"{ime}, {prezime}, {skola}, {tipMature}, {jezik}, {predmet1}, {predmet2}, {predmet3}";
        }
    }
}
