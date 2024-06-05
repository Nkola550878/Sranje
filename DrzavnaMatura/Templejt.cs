using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace DrzavnaMatura
{
    internal class Templejt
    {
        public string imeTemplejta;
        public string tipMature;
        public string jezik;
        public string predmet1;
        public string predmet2;
        public string predmet3;

        public Templejt(string l_imeTemplejta, string l_tipMature, string l_jezik, string l_predmet1, string l_predmet2, string l_predmet3)
        {
            imeTemplejta = l_imeTemplejta;
            tipMature = l_tipMature;
            jezik = l_jezik;
            predmet1 = l_predmet1;
            predmet2 = l_predmet2;
            predmet3 = l_predmet3;
        }

        public Templejt(string info)
        {
            string[] podaci = info.Split(',');
            imeTemplejta = podaci[0];
            tipMature = podaci[1];
            jezik = podaci[2];
            predmet1 = podaci[3];
            predmet2 = podaci[4];
            predmet3 = podaci[5];
        }

        public override string ToString()
        {
            return $"{imeTemplejta},{tipMature},{jezik},{predmet1},{predmet2},{predmet3}";
        }

        public void Sacuvaj(string imeFajla)
        {
            StreamWriter pisacToka = new StreamWriter(imeFajla, true);
            pisacToka.WriteLine(ToString());
            pisacToka.Close();
        }
    }
}
