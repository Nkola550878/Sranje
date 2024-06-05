using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DrzavnaMatura
{
    internal class Ucenik
    {
        public string ime;
        public string prezime;
        public string skola;
        public string tipMature;
        public string jezik;
        public string predmet1;
        public string predmet2;
        public string predmet3;

        public Ucenik(string l_ime, string l_prezime, string l_skola, string l_tipMature, string l_jezik, string l_predmet1, string l_predmet2, string l_predmet3)
        {
            ime = l_ime;
            prezime = l_prezime;
            skola = l_skola;
            tipMature = l_tipMature;
            jezik = l_jezik;
            predmet1 = l_predmet1;
            predmet2 = l_predmet2;
            predmet3 = l_predmet3;
        }

        public Ucenik(string info)
        {
            string[] podaci = info.Split(',');
            ime = podaci[0];
            prezime = podaci[1];
            skola = podaci[2];
            tipMature = podaci[3];
            jezik = podaci[4];
            predmet1 = podaci[5];
            predmet2 = podaci[6];
            predmet3 = podaci[7];
        }

        public override string ToString()
        {
            return $"{ime},{prezime},{skola},{tipMature},{jezik},{predmet1},{predmet2},{predmet3}";
        }

        public void Sacuvaj(string imeFajla)
        {
            StreamWriter pisacToka = new StreamWriter(imeFajla, true);
            pisacToka.WriteLine(ToString());
            pisacToka.Close();
        }
    }
}
