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

        int indexUcenikaKogaGledamo = 0;

        List<Ucenik> ucenici = new List<Ucenik>();
        List<Templejt> templejtovi = new List<Templejt>();

        public Form1()
        {
            InitializeComponent();
            if (!File.Exists(imeFajlaGdeSeCuvajuTemplejtovi))
            {
                FileStream tokFajla = File.Create(imeFajlaGdeSeCuvajuTemplejtovi);
                tokFajla.Close();
            }
            UcitajUcenike();
            UcitajTemplejtove();
        }

        private void cbTipMature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTipMature.SelectedIndex == 0)
            {
                TreciPredmetUZavisnostiOdTipaMature(cbPredmet3, opstaMatura);
            }
            if (cbTipMature.SelectedIndex == 1)
            {
                TreciPredmetUZavisnostiOdTipaMature(cbPredmet3, strucnaMatura);
            }
            if (cbTipMature.SelectedIndex == 2)
            {
                TreciPredmetUZavisnostiOdTipaMature(cbPredmet3, umetnickaMatura);
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

            if(indexUcenikaKogaGledamo < ucenici.Count && indexUcenikaKogaGledamo >= 0)
            {
                ucenici[indexUcenikaKogaGledamo] = new Ucenik(tbIme.Text, tbPrezime.Text, tbSkola.Text, cbTipMature.Text, cbJezik.Text, cbPredmet1.Text, cbPredmet2.Text, cbPredmet3.Text);
                return;
            }
            ucenici.Add(new Ucenik(tbIme.Text, tbPrezime.Text, tbSkola.Text, cbTipMature.Text, cbJezik.Text, cbPredmet1.Text, cbPredmet2.Text, cbPredmet3.Text));
        }

        private void btnUcitajUcenika_Click(object sender, EventArgs e)
        {
            PrikaziUcenika(indexUcenikaKogaGledamo);
        }

        private void UcitajUcenike()
        {
            StreamReader citacToka = new StreamReader(imeFajlaGdeSeCuvajuUcenici);
            string linija = "";
            int brojUcenika = ucenici.Count;
            for (int i = 0; i < BrojLinijaUFajlu(imeFajlaGdeSeCuvajuUcenici); i++)
            {
                linija = citacToka.ReadLine();
                ucenici.Add(new Ucenik(linija));
            }
            citacToka.Close();
        }

        private void PrikaziUcenika(Ucenik ucenik)
        {
            tbIme.Text = ucenik.ime;
            tbPrezime.Text = ucenik.prezime;
            tbSkola.Text = ucenik.skola;
            cbTipMature.Text = ucenik.tipMature;
            cbJezik.Text = ucenik.jezik;
            cbPredmet1.Text = ucenik.predmet1;
            cbPredmet2.Text = ucenik.predmet2;
            cbPredmet3.Text = ucenik.predmet3;
        }

        private void PrikaziUcenika(int index)
        {
            if(index >= 0 && index < ucenici.Count)
            {
                tbIme.Text = ucenici[index].ime;
                tbPrezime.Text = ucenici[index].prezime;
                tbSkola.Text = ucenici[index].skola;
                cbTipMature.Text = ucenici[index].tipMature;
                cbJezik.Text = ucenici[index].jezik;
                cbPredmet1.Text = ucenici[index].predmet1;
                cbPredmet2.Text = ucenici[index].predmet2;
                cbPredmet3.Text = ucenici[index].predmet3;
            }
            else
            {
                tbIme.Text = "";
                tbPrezime.Text = "";
                tbSkola.Text = "";
                for (int i = 0; i < templejtovi.Count; i++)
                {
                    if (templejtovi[i].imeTemplejta == cbImenaTemplejtova.Text)
                    {
                        PrikaziTemplejt(templejtovi[i]);
                        return;
                    }
                }
            }
        }

        private void btnDesniUcenik_Click(object sender, EventArgs e)
        {
            if (ucenici.Count == 0)
            {
                MessageBox.Show("Nema unetih ucenika");
                return;
            }
            indexUcenikaKogaGledamo = (indexUcenikaKogaGledamo + 1) % ucenici.Count;
            PrikaziUcenika(indexUcenikaKogaGledamo);
        }

        private void btnleviUcenik_Click(object sender, EventArgs e)
        {
            if (ucenici.Count == 0)
            {
                MessageBox.Show("Nema unetih ucenika");
                return;
            }
            indexUcenikaKogaGledamo = (indexUcenikaKogaGledamo - 1 + ucenici.Count) % ucenici.Count;
            PrikaziUcenika(indexUcenikaKogaGledamo);
        }

        private void btnNoviUcenik_Click(object sender, EventArgs e)
        {
            indexUcenikaKogaGledamo = -1;
            PrikaziUcenika(indexUcenikaKogaGledamo);
        }

        #endregion

        #region Templejtovi

        private void UcitajTemplejtove()
        {
            StreamReader citacToka = new StreamReader(imeFajlaGdeSeCuvajuTemplejtovi);
            string linija = "";
            for (int i = 0; i < BrojLinijaUFajlu(imeFajlaGdeSeCuvajuTemplejtovi); i++)
            {
                linija = citacToka.ReadLine();
                templejtovi.Add(new Templejt(linija));
                cbImenaTemplejtova.Items.Add(linija.Split(',')[0]);
            }
            citacToka.Close();
        }

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

            templejtovi.Add(new Templejt(cbImenaTemplejtova.Text, cbTipMature.Text, cbJezik.Text, cbPredmet1.Text, cbPredmet2.Text, cbPredmet3.Text));
        }

        private void TreciPredmetUZavisnostiOdTipaMature(ComboBox kutijaKombinacija, string mature)
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
            UcitajTemplejtove();
            for (int i = 0; i < templejtovi.Count; i++)
            {
                if (templejtovi[i].imeTemplejta == cbImenaTemplejtova.Text)
                {
                    PrikaziTemplejt(templejtovi[i]);
                    return;
                }
            }
            MessageBox.Show("templejt ne postoji");
        }

        private void PrikaziTemplejt(Templejt templejt)
        {
            cbTipMature.Text = templejt.tipMature;
            cbJezik.Text = templejt.jezik;
            cbPredmet1.Text = templejt.predmet1;
            cbPredmet2.Text = templejt.predmet2;
            cbPredmet3.Text = templejt.predmet3;
        }

        #endregion

        private int BrojLinijaUFajlu(string put)
        {
            return File.ReadLines(put).Count();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter pisacToka = new StreamWriter(imeFajlaGdeSeCuvajuUcenici);
            for (int i = 0; i < ucenici.Count; i++)
            {
                pisacToka.WriteLine(ucenici[i].ToString());
            }
            pisacToka.Close();

            pisacToka = new StreamWriter(imeFajlaGdeSeCuvajuTemplejtovi);
            for (int i = 0; i < templejtovi.Count; i++)
            {
                pisacToka.WriteLine(templejtovi[i].ToString());
            }
            pisacToka.Close();
        }
    }
}
