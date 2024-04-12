using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sranje
{
    public partial class Form1 : Form
    {
        static string opstaMatura = "Biologija\nGeografija\nEngleski jezik\nIstorija\nItalijanski jezik\nNemacki jezik\nRuski jezik\nSrpski kao nematernji jezik\nFizika\nFrancuski jezik\nHemija\nSpanski jezik";
        static string strucnaMatura = "Zootehnicar\nTehnicar za biotehnologiju\nTehnicar poljoprivredne tehnike\nTehnicar hortikulture\nTehnicar za pejzažnu arhitekturu\nSumarski tehnicar\nGeoloski tehnicar za geotehniku i hidrogeologiju\nGeoloski tehnicar za istraživanje mineralnih sirovina\nRudarski tehnicar\nRudarski tehnicar za pripremu mineralnih sirovina\nBrodomasinski tehnicar\nMasinski tehnicar za kompjutersko konstruisanje\nMasinski tehnicar merne i regulacione tehnike\nMasinski tehnicar motornih vozila\nTehnicar grejanja i klimatizacije\nTehnicar za kompjutersko upravljanje (CNC) masina\nTehnicar za robotiku\nTehnicar masinske energetike\nTehnicar optike\nObjedinjeni test za obrazovne profile:\nElektrotehnicar automatike\nElektrotehnicar elektromotornih pogona\nElektrotehnicar elektronike\nElektrotehnicar energetike\nElektrotehnicar za termicke i rashladne uredjaje\nElektrotehnicar informacionih tehnologija\nElektrotehnicar procesnog upravljanja\nElektrotehnicar racunara\nTehnicar graficke dorade\nTehnicar za zastitu životne sredine\nTehnicar za industrijsku farmaceutsku tehnologiju\nTehnicar stampe\nFotograf\nHemijski laborant\nHemijsko-tehnoloski tehnicar\nTekstilni tehnicar\nGradjevinski tehnicar za laboratorijska ispitivanja\nGradjevinski tehnicar za hidrogradnju\nIzvodjac instalaterskih i zavrsnih gradjevinskih radova\nNauticki tehnicar – recni smer\nSaobracajno-transportni tehnicar\nTehnicar vuce\nTehnicar PTT saobracaja\nTehnicar unutrasnjeg transporta\nTransportni komercijalista\nObjedinjeni test za obrazovne profile: Aranžer u trgovini i Trgovinski tehnicar\nKulinarski tehnicar\nUgostiteljski tehnicar\nObjedinjeni test za obrazovne profile:\nEkonomski tehnicar\nFinansijski tehnicar\nCarinski tehnicar\nGinekolosko-akuserska sestra\nZubni tehnicar\nMedicinska sestra – vaspitac\nPedijatrijska sestra – tehnicar\nSanitarno-ekoloski tehnicar\nScenski masker i vlasuljar";
        static string umetnickaMatura = "Solfedjo i harmonija";

        string imeFajlaGdeSeCuvajuUcenici = "ucenici.csv";
        string imeFajlaGdeSeCuvajuTemplejtovi = "templatovi.csv";

        int linijaZaCitanje = 0;
        string templejtovi;

        public Form1()
        {
            InitializeComponent();
            UcitajImena();
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



        #region Ucenici
        private void btnSacuvajUcenika_Click(object sender, EventArgs e)
        {
            #region Da li je ucenik validan
            if (tbIme.Text == "" || tbIme.Text == null)
            {
                MessageBox.Show("Ime je prazno");
                return;
            }
            if (tbPrezime.Text == "" || tbPrezime.Text == null)
            {
                MessageBox.Show("Prezime je prazno");
                return;
            }
            if (tbSkola.Text == "" || tbSkola.Text == null)
            {
                MessageBox.Show("Skola je prazna");
                return;
            }
            if (cbTipMature.Text == "" || cbTipMature.Text == null)
            {
                MessageBox.Show("Tip mature je prazan");
                return;
            }
            if (cbJezik.Text == "" || cbJezik.Text == null)
            {
                MessageBox.Show("Jezik je prazan");
                return;
            }
            if (cbPredmet1.Text == "" || cbPredmet1.Text == null)
            {
                MessageBox.Show("Prvi predmet je prazan");
                return;
            }
            if (cbPredmet2.Text == "" || cbPredmet2.Text == null)
            {
                MessageBox.Show("Drugi predmet je prazan");
                return;
            }
            if (cbPredmet3.Text == "" || cbPredmet3.Text == null)
            {
                MessageBox.Show("Treci predmet je prazan");
                return;
            }
            #endregion

            Ucenik ucenik = new Ucenik(tbIme.Text, tbPrezime.Text, tbSkola.Text, cbTipMature.Text, cbJezik.Text, cbPredmet1.Text, cbPredmet2.Text, cbPredmet3.Text);
            ucenik.Sacuvaj(imeFajlaGdeSeCuvajuUcenici);
        }

        private void btnUcitajUcenika_Click(object sender, EventArgs e)
        {
            UcitajUcenika();
        }

        private void UcitajUcenika()
        {
            StreamReader citacToka = new StreamReader(imeFajlaGdeSeCuvajuUcenici);
            string line = "";
            for (int i = 0; i < linijaZaCitanje + 1; i++)
            {
                line = citacToka.ReadLine();
            }
            Ucenik ucenik = new Ucenik(line);
            tbIme.Text = ucenik.ime;
            tbPrezime.Text = ucenik.prezime;
            tbSkola.Text = ucenik.skola;
            cbTipMature.Text = ucenik.tipMature;
            cbJezik.Text = ucenik.jezik;
            cbPredmet1.Text = ucenik.predmet1;
            cbPredmet2.Text = ucenik.predmet2;
            cbPredmet3.Text = ucenik.predmet3;
            citacToka.Close();
        }

        private void btnDesniUcenik_Click(object sender, EventArgs e)
        {
            linijaZaCitanje = (linijaZaCitanje + 1) % BrojLinijaUFajlu(imeFajlaGdeSeCuvajuUcenici);
            UcitajUcenika();
        }

        private void btnleviUcenik_Click(object sender, EventArgs e)
        {
            linijaZaCitanje = (linijaZaCitanje - 1 + BrojLinijaUFajlu(imeFajlaGdeSeCuvajuUcenici)) % BrojLinijaUFajlu(imeFajlaGdeSeCuvajuUcenici);
            UcitajUcenika();
        }
        #endregion

        #region Templejtovi
        private void btnNapraviTemplejt_Click(object sender, EventArgs e)
        {
            #region da li je template validan
            if (cbTipMature.Text == "" || cbTipMature.Text == null)
            {
                MessageBox.Show("Tip mature je prazan");
                return;
            }
            if (cbJezik.Text == "" || cbJezik.Text == null)
            {
                MessageBox.Show("Jezik je prazan");
                return;
            }
            if (cbPredmet1.Text == "" || cbPredmet1.Text == null)
            {
                MessageBox.Show("Prvi predmet je prazan");
                return;
            }
            if (cbPredmet2.Text == "" || cbPredmet2.Text == null)
            {
                MessageBox.Show("Drugi predmet je prazan");
                return;
            }
            if (cbPredmet3.Text == "" || cbPredmet3.Text == null)
            {
                MessageBox.Show("Treci predmet je prazan");
                return;
            }
            #endregion

            Templejt template = new Templejt(cbTipMature.Text, cbJezik.Text, cbPredmet1.Text, cbPredmet2.Text, cbPredmet3.Text);
            template.Sacuvaj(imeFajlaGdeSeCuvajuTemplejtovi, cbImenaTemplejtova.Text);
        }

        private void PostaviMaturu(ComboBox kutijaKombinacija, string mature)
        {
            kutijaKombinacija.Items.Clear();
            string[] predmeti = mature.Split('\n');
            for (int i = 0; i < predmeti.Length; i++)
            {
                kutijaKombinacija.Items.Add(predmeti[i]);
            }
        }

        private void btnUcitajTemplejt_Click(object sender, EventArgs e)
        {
            UcitajTemplejt();
        }

        private void UcitajTemplejt()
        {
            StreamReader citacToka = new StreamReader(imeFajlaGdeSeCuvajuTemplejtovi);
            string linija = "";
            for (int i = 0; i < BrojLinijaUFajlu(imeFajlaGdeSeCuvajuTemplejtovi); i++)
            {
                linija = citacToka.ReadLine();
                if (linija.Split(',')[0] == cbImenaTemplejtova.Text)
                {
                    break;
                }
                if(i == BrojLinijaUFajlu(imeFajlaGdeSeCuvajuTemplejtovi) - 1)
                {
                    MessageBox.Show("Template sa tim imenom ne postoji");
                    return;
                }
            }
            Templejt templejt = new Templejt(linija);
            cbTipMature.Text = templejt.tipMature;
            cbJezik.Text = templejt.jezik;
            cbPredmet1.Text = templejt.predmet1;
            cbPredmet2.Text = templejt.predmet2;
            cbPredmet3.Text = templejt.predmet3;
            citacToka.Close();
        }

        private void UcitajImena()
        {
            string linija = "";
            StreamReader citacToka = new StreamReader(imeFajlaGdeSeCuvajuTemplejtovi);
            for (int i = 0; i < BrojLinijaUFajlu(imeFajlaGdeSeCuvajuTemplejtovi); i++)
            {
                linija = citacToka.ReadLine();
                cbImenaTemplejtova.Items.Add(linija.Split(',')[0]);
            }
        }
        #endregion

        private int BrojLinijaUFajlu(string put)
        {
            return File.ReadLines(put).Count();
        }
    }
}
