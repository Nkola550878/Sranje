using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sranje
{
    public partial class Form1 : Form
    {
        static string opstaMatura = "Biologija\nGeografija\nEngleski jezik\nIstorija\nItalijanski jezik\nNemački jezik\nRuski jezik\nSrpski kao nematernji jezik\nFizika\nFrancuski jezik\nHemija\nŠpanski jezik";
        static string strucnaMatura = "Zootehničar\nTehničar za biotehnologiju\nTehničar poljoprivredne tehnike\nTehničar hortikulture\nTehničar za pejzažnu arhitekturu\nŠumarski tehničar\nGeološki tehničar za geotehniku i hidrogeologiju\nGeološki tehničar za istraživanje mineralnih sirovina\nRudarski tehničar\nRudarski tehničar za pripremu mineralnih sirovina\nBrodomašinski tehničar\nMašinski tehničar za kompjutersko konstruisanje\nMašinski tehničar merne i regulacione tehnike\nMašinski tehničar motornih vozila\nTehničar grejanja i klimatizacije\nTehničar za kompjutersko upravljanje (CNC) mašina\nTehničar za robotiku\nTehničar mašinske energetike\nTehničar optike\nObjedinjeni test za obrazovne profile:\nElektrotehničar automatike\nElektrotehničar elektromotornih pogona\nElektrotehničar elektronike\nElektrotehničar energetike\nElektrotehničar za termičke i rashladne uređaje\nElektrotehničar informacionih tehnologija\nElektrotehničar procesnog upravljanja\nElektrotehničar računara\nTehničar grafičke dorade\nTehničar za zaštitu životne sredine\nTehničar za industrijsku farmaceutsku tehnologiju\nTehničar štampe\nFotograf\nHemijski laborant\nHemijsko-tehnološki tehničar\nTekstilni tehničar\nGrađevinski tehničar za laboratorijska ispitivanja\nGrađevinski tehničar za hidrogradnju\nIzvođač instalaterskih i završnih građevinskih radova\nNautički tehničar – rečni smer\nSaobraćajno-transportni tehničar\nTehničar vuče\nTehničar PTT saobraćaja\nTehničar unutrašnjeg transporta\nTransportni komercijalista\nObjedinjeni test za obrazovne profile: Aranžer u trgovini i Trgovinski tehničar\nKulinarski tehničar\nUgostiteljski tehničar\nObjedinjeni test za obrazovne profile:\nEkonomski tehničar\nFinansijski tehničar\nCarinski tehničar\nGinekološko-akušerska sestra\nZubni tehničar\nMedicinska sestra – vaspitač\nPedijatrijska sestra – tehničar\nSanitarno-ekološki tehničar\nScenski masker i vlasuljar";
        static string umetnickaMatura = "Solfeđo i harmonija";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSacuvajUcenika_Click(object sender, EventArgs e)
        {
            Ucenik temp = new Ucenik(tbIme.Text, tbPrezime.Text, tbSkola.Text, cbTipMature.Text, cbJezik.Text, cbPredmet1.Text, cbPredmet2.Text, cbPredmet3.Text);
        }

        private void cbTipMature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipMature.SelectedIndex == 0)
            {
                PostaviMaturu(cbPredmet3, opstaMatura);
            }
            if (cbTipMature.SelectedIndex == 1)
            {
                PostaviMaturu(cbPredmet3, strucnaMatura);
            }
            if (cbTipMature.SelectedIndex == 2)
            {
                PostaviMaturu(cbPredmet3, umetnickaMatura);
            }
        }

        private void PostaviMaturu(ComboBox comboBox, string mature)
        {
            comboBox.Items.Clear();
            string[] predmeti = mature.Split('\n');
            for (int i = 0; i < predmeti.Length; i++)
            {
                comboBox.Items.Add(predmeti[i]);
            }
        }
    }
}
