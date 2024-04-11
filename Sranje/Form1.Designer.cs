namespace Sranje
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbIme = new System.Windows.Forms.TextBox();
            this.tbPrezime = new System.Windows.Forms.TextBox();
            this.tbSkola = new System.Windows.Forms.TextBox();
            this.lblIme = new System.Windows.Forms.Label();
            this.lblPrezime = new System.Windows.Forms.Label();
            this.lbSkola = new System.Windows.Forms.Label();
            this.cbTipMature = new System.Windows.Forms.ComboBox();
            this.cbJezik = new System.Windows.Forms.ComboBox();
            this.cbPredmet1 = new System.Windows.Forms.ComboBox();
            this.cbPredmet2 = new System.Windows.Forms.ComboBox();
            this.cbPredmet3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNapraviTemplejt = new System.Windows.Forms.Button();
            this.btnUcitajTemplejt = new System.Windows.Forms.Button();
            this.btnSacuvajUcenika = new System.Windows.Forms.Button();
            this.btnUcitajUcenika = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbIme
            // 
            this.tbIme.Location = new System.Drawing.Point(12, 12);
            this.tbIme.Name = "tbIme";
            this.tbIme.Size = new System.Drawing.Size(100, 20);
            this.tbIme.TabIndex = 0;
            // 
            // tbPrezime
            // 
            this.tbPrezime.Location = new System.Drawing.Point(118, 12);
            this.tbPrezime.Name = "tbPrezime";
            this.tbPrezime.Size = new System.Drawing.Size(100, 20);
            this.tbPrezime.TabIndex = 1;
            // 
            // tbSkola
            // 
            this.tbSkola.Location = new System.Drawing.Point(224, 12);
            this.tbSkola.Name = "tbSkola";
            this.tbSkola.Size = new System.Drawing.Size(100, 20);
            this.tbSkola.TabIndex = 2;
            // 
            // lblIme
            // 
            this.lblIme.AutoSize = true;
            this.lblIme.Location = new System.Drawing.Point(9, 35);
            this.lblIme.Name = "lblIme";
            this.lblIme.Size = new System.Drawing.Size(24, 13);
            this.lblIme.TabIndex = 3;
            this.lblIme.Text = "Ime";
            // 
            // lblPrezime
            // 
            this.lblPrezime.AutoSize = true;
            this.lblPrezime.Location = new System.Drawing.Point(115, 35);
            this.lblPrezime.Name = "lblPrezime";
            this.lblPrezime.Size = new System.Drawing.Size(44, 13);
            this.lblPrezime.TabIndex = 4;
            this.lblPrezime.Text = "Prezime";
            // 
            // lbSkola
            // 
            this.lbSkola.AutoSize = true;
            this.lbSkola.Location = new System.Drawing.Point(221, 35);
            this.lbSkola.Name = "lbSkola";
            this.lbSkola.Size = new System.Drawing.Size(34, 13);
            this.lbSkola.TabIndex = 5;
            this.lbSkola.Text = "Skola";
            // 
            // cbTipMature
            // 
            this.cbTipMature.FormattingEnabled = true;
            this.cbTipMature.Items.AddRange(new object[] {
            "Opsta matura",
            "Strucna matura",
            "Umetnicka matura"});
            this.cbTipMature.Location = new System.Drawing.Point(12, 51);
            this.cbTipMature.Name = "cbTipMature";
            this.cbTipMature.Size = new System.Drawing.Size(147, 21);
            this.cbTipMature.TabIndex = 6;
            this.cbTipMature.SelectedIndexChanged += new System.EventHandler(this.cbTipMature_SelectedIndexChanged);
            // 
            // cbJezik
            // 
            this.cbJezik.FormattingEnabled = true;
            this.cbJezik.Items.AddRange(new object[] {
            "Srpski",
            "Albanski",
            "Bosanski",
            "Bugarski",
            "Madjarski",
            "Rumunski",
            "Rusinski",
            "Slovacki",
            "Hrvatski"});
            this.cbJezik.Location = new System.Drawing.Point(12, 78);
            this.cbJezik.Name = "cbJezik";
            this.cbJezik.Size = new System.Drawing.Size(147, 21);
            this.cbJezik.TabIndex = 7;
            // 
            // cbPredmet1
            // 
            this.cbPredmet1.FormattingEnabled = true;
            this.cbPredmet1.Items.AddRange(new object[] {
            "Srpski jezik i knjizevnost",
            "Albanski jezik i knjizevnost",
            "Bosanski jezik i knjizevnost",
            "Bugarski jezik i knjizevnost",
            "Madjarski jezik i knjizevnost",
            "Rumunski jezik i knjizevnost",
            "Rusinski jezik i knjizevnost",
            "Slovacki jezik i knjizevnost",
            "Hrvatski jezik i knjizevnost"});
            this.cbPredmet1.Location = new System.Drawing.Point(12, 105);
            this.cbPredmet1.Name = "cbPredmet1";
            this.cbPredmet1.Size = new System.Drawing.Size(147, 21);
            this.cbPredmet1.TabIndex = 8;
            // 
            // cbPredmet2
            // 
            this.cbPredmet2.FormattingEnabled = true;
            this.cbPredmet2.Items.AddRange(new object[] {
            "Matematika"});
            this.cbPredmet2.Location = new System.Drawing.Point(12, 132);
            this.cbPredmet2.Name = "cbPredmet2";
            this.cbPredmet2.Size = new System.Drawing.Size(147, 21);
            this.cbPredmet2.TabIndex = 9;
            // 
            // cbPredmet3
            // 
            this.cbPredmet3.FormattingEnabled = true;
            this.cbPredmet3.Location = new System.Drawing.Point(12, 159);
            this.cbPredmet3.Name = "cbPredmet3";
            this.cbPredmet3.Size = new System.Drawing.Size(147, 21);
            this.cbPredmet3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "tip mature";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "jezik";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "prvi predmet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "drugi predmet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "treci predmet";
            // 
            // btnNapraviTemplejt
            // 
            this.btnNapraviTemplejt.Location = new System.Drawing.Point(12, 186);
            this.btnNapraviTemplejt.Name = "btnNapraviTemplejt";
            this.btnNapraviTemplejt.Size = new System.Drawing.Size(100, 23);
            this.btnNapraviTemplejt.TabIndex = 16;
            this.btnNapraviTemplejt.Text = "napravi templejt";
            this.btnNapraviTemplejt.UseVisualStyleBackColor = true;
            // 
            // btnUcitajTemplejt
            // 
            this.btnUcitajTemplejt.Location = new System.Drawing.Point(12, 215);
            this.btnUcitajTemplejt.Name = "btnUcitajTemplejt";
            this.btnUcitajTemplejt.Size = new System.Drawing.Size(100, 23);
            this.btnUcitajTemplejt.TabIndex = 17;
            this.btnUcitajTemplejt.Text = "ucitaj templejt";
            this.btnUcitajTemplejt.UseVisualStyleBackColor = true;
            // 
            // btnSacuvajUcenika
            // 
            this.btnSacuvajUcenika.Location = new System.Drawing.Point(250, 157);
            this.btnSacuvajUcenika.Name = "btnSacuvajUcenika";
            this.btnSacuvajUcenika.Size = new System.Drawing.Size(100, 23);
            this.btnSacuvajUcenika.TabIndex = 18;
            this.btnSacuvajUcenika.Text = "sacuvaj ucenika";
            this.btnSacuvajUcenika.UseVisualStyleBackColor = true;
            this.btnSacuvajUcenika.Click += new System.EventHandler(this.btnSacuvajUcenika_Click);
            // 
            // btnUcitajUcenika
            // 
            this.btnUcitajUcenika.Location = new System.Drawing.Point(250, 132);
            this.btnUcitajUcenika.Name = "btnUcitajUcenika";
            this.btnUcitajUcenika.Size = new System.Drawing.Size(100, 23);
            this.btnUcitajUcenika.TabIndex = 19;
            this.btnUcitajUcenika.Text = "ucitaj ucenika";
            this.btnUcitajUcenika.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 455);
            this.Controls.Add(this.btnUcitajUcenika);
            this.Controls.Add(this.btnSacuvajUcenika);
            this.Controls.Add(this.btnUcitajTemplejt);
            this.Controls.Add(this.btnNapraviTemplejt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPredmet3);
            this.Controls.Add(this.cbPredmet2);
            this.Controls.Add(this.cbPredmet1);
            this.Controls.Add(this.cbJezik);
            this.Controls.Add(this.cbTipMature);
            this.Controls.Add(this.lbSkola);
            this.Controls.Add(this.lblPrezime);
            this.Controls.Add(this.lblIme);
            this.Controls.Add(this.tbSkola);
            this.Controls.Add(this.tbPrezime);
            this.Controls.Add(this.tbIme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbIme;
        private System.Windows.Forms.TextBox tbPrezime;
        private System.Windows.Forms.TextBox tbSkola;
        private System.Windows.Forms.Label lblIme;
        private System.Windows.Forms.Label lblPrezime;
        private System.Windows.Forms.Label lbSkola;
        private System.Windows.Forms.ComboBox cbTipMature;
        private System.Windows.Forms.ComboBox cbJezik;
        private System.Windows.Forms.ComboBox cbPredmet1;
        private System.Windows.Forms.ComboBox cbPredmet2;
        private System.Windows.Forms.ComboBox cbPredmet3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNapraviTemplejt;
        private System.Windows.Forms.Button btnUcitajTemplejt;
        private System.Windows.Forms.Button btnSacuvajUcenika;
        private System.Windows.Forms.Button btnUcitajUcenika;
    }
}

