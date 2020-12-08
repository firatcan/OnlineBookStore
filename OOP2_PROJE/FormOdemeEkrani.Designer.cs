namespace OOP2_PROJE
{
    partial class FormOdemeEkrani
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControlOdeme = new System.Windows.Forms.TabControl();
            this.tpageKrediKartı = new System.Windows.Forms.TabPage();
            this.lblTl = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.grupAdres = new System.Windows.Forms.GroupBox();
            this.radiobtnYeniAdres = new System.Windows.Forms.RadioButton();
            this.rediobtnKayitli = new System.Windows.Forms.RadioButton();
            this.lblSonKullanma = new System.Windows.Forms.Label();
            this.lblCvc = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblKart = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.mtxtSnKullanma = new System.Windows.Forms.MaskedTextBox();
            this.mtxtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.mtxtKart = new System.Windows.Forms.MaskedTextBox();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.mtxtCvc = new System.Windows.Forms.MaskedTextBox();
            this.tpageNakitOdeme = new System.Windows.Forms.TabPage();
            this.lblTl1 = new System.Windows.Forms.Label();
            this.lblTutar1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radiobtnYeniAdres1 = new System.Windows.Forms.RadioButton();
            this.radiobtnKayitli1 = new System.Windows.Forms.RadioButton();
            this.lblTelefon1 = new System.Windows.Forms.Label();
            this.lblAdres1 = new System.Windows.Forms.Label();
            this.mtxtTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.txtAdres1 = new System.Windows.Forms.TextBox();
            this.btnOnayla1 = new System.Windows.Forms.Button();
            this.tabControlOdeme.SuspendLayout();
            this.tpageKrediKartı.SuspendLayout();
            this.grupAdres.SuspendLayout();
            this.tpageNakitOdeme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlOdeme
            // 
            this.tabControlOdeme.Controls.Add(this.tpageKrediKartı);
            this.tabControlOdeme.Controls.Add(this.tpageNakitOdeme);
            this.tabControlOdeme.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControlOdeme.Location = new System.Drawing.Point(2, 2);
            this.tabControlOdeme.Name = "tabControlOdeme";
            this.tabControlOdeme.SelectedIndex = 0;
            this.tabControlOdeme.Size = new System.Drawing.Size(525, 386);
            this.tabControlOdeme.TabIndex = 4;
            // 
            // tpageKrediKartı
            // 
            this.tpageKrediKartı.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpageKrediKartı.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tpageKrediKartı.Controls.Add(this.lblTl);
            this.tpageKrediKartı.Controls.Add(this.lblTutar);
            this.tpageKrediKartı.Controls.Add(this.grupAdres);
            this.tpageKrediKartı.Controls.Add(this.lblSonKullanma);
            this.tpageKrediKartı.Controls.Add(this.lblCvc);
            this.tpageKrediKartı.Controls.Add(this.lblTelefon);
            this.tpageKrediKartı.Controls.Add(this.lblKart);
            this.tpageKrediKartı.Controls.Add(this.lblAdres);
            this.tpageKrediKartı.Controls.Add(this.mtxtSnKullanma);
            this.tpageKrediKartı.Controls.Add(this.mtxtTelefon);
            this.tpageKrediKartı.Controls.Add(this.txtAdres);
            this.tpageKrediKartı.Controls.Add(this.mtxtKart);
            this.tpageKrediKartı.Controls.Add(this.btnOnayla);
            this.tpageKrediKartı.Controls.Add(this.mtxtCvc);
            this.tpageKrediKartı.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpageKrediKartı.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpageKrediKartı.Location = new System.Drawing.Point(4, 22);
            this.tpageKrediKartı.Name = "tpageKrediKartı";
            this.tpageKrediKartı.Padding = new System.Windows.Forms.Padding(3);
            this.tpageKrediKartı.Size = new System.Drawing.Size(517, 360);
            this.tpageKrediKartı.TabIndex = 0;
            this.tpageKrediKartı.Text = "KREDİ KARTI";
            // 
            // lblTl
            // 
            this.lblTl.AutoSize = true;
            this.lblTl.Location = new System.Drawing.Point(278, 242);
            this.lblTl.Name = "lblTl";
            this.lblTl.Size = new System.Drawing.Size(26, 16);
            this.lblTl.TabIndex = 30;
            this.lblTl.Text = "TL";
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(211, 242);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(60, 16);
            this.lblTutar.TabIndex = 29;
            this.lblTutar.Text = "TUTAR";
            // 
            // grupAdres
            // 
            this.grupAdres.Controls.Add(this.radiobtnYeniAdres);
            this.grupAdres.Controls.Add(this.rediobtnKayitli);
            this.grupAdres.Location = new System.Drawing.Point(5, 160);
            this.grupAdres.Name = "grupAdres";
            this.grupAdres.Size = new System.Drawing.Size(372, 57);
            this.grupAdres.TabIndex = 28;
            this.grupAdres.TabStop = false;
            // 
            // radiobtnYeniAdres
            // 
            this.radiobtnYeniAdres.AutoSize = true;
            this.radiobtnYeniAdres.Location = new System.Drawing.Point(6, 21);
            this.radiobtnYeniAdres.Name = "radiobtnYeniAdres";
            this.radiobtnYeniAdres.Size = new System.Drawing.Size(126, 20);
            this.radiobtnYeniAdres.TabIndex = 27;
            this.radiobtnYeniAdres.Text = "Yeni Adres Gir";
            this.radiobtnYeniAdres.UseVisualStyleBackColor = true;
            this.radiobtnYeniAdres.CheckedChanged += new System.EventHandler(this.radiobtnYeniAdres_CheckedChanged);
            // 
            // rediobtnKayitli
            // 
            this.rediobtnKayitli.AutoSize = true;
            this.rediobtnKayitli.Checked = true;
            this.rediobtnKayitli.Location = new System.Drawing.Point(171, 21);
            this.rediobtnKayitli.Name = "rediobtnKayitli";
            this.rediobtnKayitli.Size = new System.Drawing.Size(163, 20);
            this.rediobtnKayitli.TabIndex = 26;
            this.rediobtnKayitli.TabStop = true;
            this.rediobtnKayitli.Text = "Kayıtlı Adresi Kullan";
            this.rediobtnKayitli.UseVisualStyleBackColor = true;
            this.rediobtnKayitli.CheckedChanged += new System.EventHandler(this.rediobtnKayitli_CheckedChanged);
            // 
            // lblSonKullanma
            // 
            this.lblSonKullanma.AutoSize = true;
            this.lblSonKullanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonKullanma.Location = new System.Drawing.Point(-2, 60);
            this.lblSonKullanma.Name = "lblSonKullanma";
            this.lblSonKullanma.Size = new System.Drawing.Size(177, 16);
            this.lblSonKullanma.TabIndex = 25;
            this.lblSonKullanma.Text = "SON KULLANMA TARİHİ";
            // 
            // lblCvc
            // 
            this.lblCvc.AutoSize = true;
            this.lblCvc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCvc.Location = new System.Drawing.Point(2, 97);
            this.lblCvc.Name = "lblCvc";
            this.lblCvc.Size = new System.Drawing.Size(168, 16);
            this.lblCvc.TabIndex = 24;
            this.lblCvc.Text = "GÜVENLİK KODU(CVC)";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon.Location = new System.Drawing.Point(2, 135);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(77, 16);
            this.lblTelefon.TabIndex = 23;
            this.lblTelefon.Text = "TELEFON";
            // 
            // lblKart
            // 
            this.lblKart.AutoSize = true;
            this.lblKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKart.Location = new System.Drawing.Point(2, 19);
            this.lblKart.Name = "lblKart";
            this.lblKart.Size = new System.Drawing.Size(101, 16);
            this.lblKart.TabIndex = 22;
            this.lblKart.Text = "KREDİ KARTI";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(43, 223);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(60, 16);
            this.lblAdres.TabIndex = 21;
            this.lblAdres.Text = "ADRES";
            this.lblAdres.Visible = false;
            // 
            // mtxtSnKullanma
            // 
            this.mtxtSnKullanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtSnKullanma.Location = new System.Drawing.Point(200, 60);
            this.mtxtSnKullanma.Mask = "00/00.";
            this.mtxtSnKullanma.Name = "mtxtSnKullanma";
            this.mtxtSnKullanma.Size = new System.Drawing.Size(52, 26);
            this.mtxtSnKullanma.TabIndex = 20;
            // 
            // mtxtTelefon
            // 
            this.mtxtTelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTelefon.Location = new System.Drawing.Point(200, 132);
            this.mtxtTelefon.Mask = "(999)-000-0000.";
            this.mtxtTelefon.Name = "mtxtTelefon";
            this.mtxtTelefon.Size = new System.Drawing.Size(166, 22);
            this.mtxtTelefon.TabIndex = 19;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(4, 242);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(166, 66);
            this.txtAdres.TabIndex = 18;
            this.txtAdres.Visible = false;
            // 
            // mtxtKart
            // 
            this.mtxtKart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtKart.Location = new System.Drawing.Point(200, 16);
            this.mtxtKart.Mask = "0000-0000-0000-0000.";
            this.mtxtKart.Name = "mtxtKart";
            this.mtxtKart.Size = new System.Drawing.Size(166, 22);
            this.mtxtKart.TabIndex = 15;
            this.mtxtKart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnOnayla
            // 
            this.btnOnayla.BackColor = System.Drawing.Color.White;
            this.btnOnayla.Location = new System.Drawing.Point(211, 280);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(105, 28);
            this.btnOnayla.TabIndex = 17;
            this.btnOnayla.Text = "ONAY";
            this.btnOnayla.UseVisualStyleBackColor = false;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // mtxtCvc
            // 
            this.mtxtCvc.Location = new System.Drawing.Point(200, 97);
            this.mtxtCvc.Mask = "000.";
            this.mtxtCvc.Name = "mtxtCvc";
            this.mtxtCvc.Size = new System.Drawing.Size(52, 22);
            this.mtxtCvc.TabIndex = 16;
            this.mtxtCvc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tpageNakitOdeme
            // 
            this.tpageNakitOdeme.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tpageNakitOdeme.Controls.Add(this.lblTl1);
            this.tpageNakitOdeme.Controls.Add(this.lblTutar1);
            this.tpageNakitOdeme.Controls.Add(this.groupBox1);
            this.tpageNakitOdeme.Controls.Add(this.lblTelefon1);
            this.tpageNakitOdeme.Controls.Add(this.lblAdres1);
            this.tpageNakitOdeme.Controls.Add(this.mtxtTelefon1);
            this.tpageNakitOdeme.Controls.Add(this.txtAdres1);
            this.tpageNakitOdeme.Controls.Add(this.btnOnayla1);
            this.tpageNakitOdeme.Location = new System.Drawing.Point(4, 22);
            this.tpageNakitOdeme.Name = "tpageNakitOdeme";
            this.tpageNakitOdeme.Padding = new System.Windows.Forms.Padding(3);
            this.tpageNakitOdeme.Size = new System.Drawing.Size(517, 360);
            this.tpageNakitOdeme.TabIndex = 1;
            this.tpageNakitOdeme.Text = "KAPIDA ÖDEME";
            // 
            // lblTl1
            // 
            this.lblTl1.AutoSize = true;
            this.lblTl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTl1.Location = new System.Drawing.Point(282, 174);
            this.lblTl1.Name = "lblTl1";
            this.lblTl1.Size = new System.Drawing.Size(26, 16);
            this.lblTl1.TabIndex = 42;
            this.lblTl1.Text = "TL";
            // 
            // lblTutar1
            // 
            this.lblTutar1.AutoSize = true;
            this.lblTutar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTutar1.Location = new System.Drawing.Point(215, 174);
            this.lblTutar1.Name = "lblTutar1";
            this.lblTutar1.Size = new System.Drawing.Size(60, 16);
            this.lblTutar1.TabIndex = 41;
            this.lblTutar1.Text = "TUTAR";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radiobtnYeniAdres1);
            this.groupBox1.Controls.Add(this.radiobtnKayitli1);
            this.groupBox1.Location = new System.Drawing.Point(8, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 57);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            // 
            // radiobtnYeniAdres1
            // 
            this.radiobtnYeniAdres1.AutoSize = true;
            this.radiobtnYeniAdres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtnYeniAdres1.Location = new System.Drawing.Point(6, 21);
            this.radiobtnYeniAdres1.Name = "radiobtnYeniAdres1";
            this.radiobtnYeniAdres1.Size = new System.Drawing.Size(126, 20);
            this.radiobtnYeniAdres1.TabIndex = 27;
            this.radiobtnYeniAdres1.Text = "Yeni Adres Gir";
            this.radiobtnYeniAdres1.UseVisualStyleBackColor = true;
            this.radiobtnYeniAdres1.CheckedChanged += new System.EventHandler(this.radiobtnYeniAdres1_CheckedChanged);
            // 
            // radiobtnKayitli1
            // 
            this.radiobtnKayitli1.AutoSize = true;
            this.radiobtnKayitli1.Checked = true;
            this.radiobtnKayitli1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radiobtnKayitli1.Location = new System.Drawing.Point(171, 21);
            this.radiobtnKayitli1.Name = "radiobtnKayitli1";
            this.radiobtnKayitli1.Size = new System.Drawing.Size(163, 20);
            this.radiobtnKayitli1.TabIndex = 26;
            this.radiobtnKayitli1.TabStop = true;
            this.radiobtnKayitli1.Text = "Kayıtlı Adresi Kullan";
            this.radiobtnKayitli1.UseVisualStyleBackColor = true;
            this.radiobtnKayitli1.CheckedChanged += new System.EventHandler(this.radiobtnKayitli1_CheckedChanged);
            // 
            // lblTelefon1
            // 
            this.lblTelefon1.AutoSize = true;
            this.lblTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTelefon1.Location = new System.Drawing.Point(12, 46);
            this.lblTelefon1.Name = "lblTelefon1";
            this.lblTelefon1.Size = new System.Drawing.Size(77, 16);
            this.lblTelefon1.TabIndex = 37;
            this.lblTelefon1.Text = "TELEFON";
            // 
            // lblAdres1
            // 
            this.lblAdres1.AutoSize = true;
            this.lblAdres1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres1.Location = new System.Drawing.Point(49, 162);
            this.lblAdres1.Name = "lblAdres1";
            this.lblAdres1.Size = new System.Drawing.Size(60, 16);
            this.lblAdres1.TabIndex = 35;
            this.lblAdres1.Text = "ADRES";
            this.lblAdres1.Visible = false;
            // 
            // mtxtTelefon1
            // 
            this.mtxtTelefon1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mtxtTelefon1.Location = new System.Drawing.Point(156, 43);
            this.mtxtTelefon1.Mask = "(999) 000-0000";
            this.mtxtTelefon1.Name = "mtxtTelefon1";
            this.mtxtTelefon1.Size = new System.Drawing.Size(166, 22);
            this.mtxtTelefon1.TabIndex = 33;
            // 
            // txtAdres1
            // 
            this.txtAdres1.Location = new System.Drawing.Point(10, 181);
            this.txtAdres1.Multiline = true;
            this.txtAdres1.Name = "txtAdres1";
            this.txtAdres1.Size = new System.Drawing.Size(166, 66);
            this.txtAdres1.TabIndex = 32;
            this.txtAdres1.Visible = false;
            // 
            // btnOnayla1
            // 
            this.btnOnayla1.BackColor = System.Drawing.Color.White;
            this.btnOnayla1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOnayla1.Location = new System.Drawing.Point(217, 219);
            this.btnOnayla1.Name = "btnOnayla1";
            this.btnOnayla1.Size = new System.Drawing.Size(105, 28);
            this.btnOnayla1.TabIndex = 31;
            this.btnOnayla1.Text = "ONAY";
            this.btnOnayla1.UseVisualStyleBackColor = false;
            this.btnOnayla1.Click += new System.EventHandler(this.btnOnayla1_Click);
            // 
            // FormOdemeEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 387);
            this.Controls.Add(this.tabControlOdeme);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "FormOdemeEkrani";
            this.Text = "ODEME EKRANI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOdemeEkrani_FormClosing);
            this.Load += new System.EventHandler(this.FormOdemeEkrani_Load);
            this.tabControlOdeme.ResumeLayout(false);
            this.tpageKrediKartı.ResumeLayout(false);
            this.tpageKrediKartı.PerformLayout();
            this.grupAdres.ResumeLayout(false);
            this.grupAdres.PerformLayout();
            this.tpageNakitOdeme.ResumeLayout(false);
            this.tpageNakitOdeme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControlOdeme;
        private System.Windows.Forms.TabPage tpageKrediKartı;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.TabPage tpageNakitOdeme;
        private System.Windows.Forms.GroupBox grupAdres;
        private System.Windows.Forms.RadioButton radiobtnYeniAdres;
        private System.Windows.Forms.RadioButton rediobtnKayitli;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtnYeniAdres1;
        private System.Windows.Forms.RadioButton radiobtnKayitli1;
        private System.Windows.Forms.Label lblTelefon1;
        private System.Windows.Forms.Label lblAdres1;
        private System.Windows.Forms.MaskedTextBox mtxtTelefon1;
        private System.Windows.Forms.TextBox txtAdres1;
        private System.Windows.Forms.Button btnOnayla1;
        private System.Windows.Forms.Label lblSonKullanma;
        private System.Windows.Forms.Label lblCvc;
        private System.Windows.Forms.Label lblKart;
        private System.Windows.Forms.MaskedTextBox mtxtSnKullanma;
        private System.Windows.Forms.MaskedTextBox mtxtKart;
        private System.Windows.Forms.MaskedTextBox mtxtCvc;
        private System.Windows.Forms.Label lblTl;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTl1;
        private System.Windows.Forms.Label lblTutar1;
    }
}