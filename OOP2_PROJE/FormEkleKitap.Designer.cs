namespace OOP2_PROJE
{
    partial class FormEkleKitap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkleKitap));
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageKitapEkle = new System.Windows.Forms.TabPage();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.dgvKitapGoster = new System.Windows.Forms.DataGridView();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.cmbxKitapTur = new System.Windows.Forms.ComboBox();
            this.pbxKitapFotograf = new System.Windows.Forms.PictureBox();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.txtSayfa = new System.Windows.Forms.TextBox();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtYayin = new System.Windows.Forms.TextBox();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.txtIsbn = new System.Windows.Forms.TextBox();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.tpageDRKitapCek = new System.Windows.Forms.TabPage();
            this.lblTur1 = new System.Windows.Forms.Label();
            this.cmbKitapDR = new System.Windows.Forms.ComboBox();
            this.lblIsbn1 = new System.Windows.Forms.Label();
            this.txtIsbnDR = new System.Windows.Forms.TextBox();
            this.btnKitapEkleDR = new System.Windows.Forms.Button();
            this.dgwDr = new System.Windows.Forms.DataGridView();
            this.btnVeriCekKitapDr = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpageKitapEkle.SuspendLayout();
            this.gbxSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapGoster)).BeginInit();
            this.gbxEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKitapFotograf)).BeginInit();
            this.tpageDRKitapCek.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDr)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageKitapEkle);
            this.tabControl1.Controls.Add(this.tpageDRKitapCek);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 546);
            this.tabControl1.TabIndex = 0;
            // 
            // tpageKitapEkle
            // 
            this.tpageKitapEkle.Controls.Add(this.gbxSil);
            this.tpageKitapEkle.Controls.Add(this.gbxEkle);
            this.tpageKitapEkle.Location = new System.Drawing.Point(4, 25);
            this.tpageKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.tpageKitapEkle.Name = "tpageKitapEkle";
            this.tpageKitapEkle.Padding = new System.Windows.Forms.Padding(4);
            this.tpageKitapEkle.Size = new System.Drawing.Size(808, 517);
            this.tpageKitapEkle.TabIndex = 0;
            this.tpageKitapEkle.Text = "KİTAP EKLE";
            this.tpageKitapEkle.UseVisualStyleBackColor = true;
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.lblNot);
            this.gbxSil.Controls.Add(this.dgvKitapGoster);
            this.gbxSil.Location = new System.Drawing.Point(16, 282);
            this.gbxSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSil.Size = new System.Drawing.Size(775, 203);
            this.gbxSil.TabIndex = 46;
            this.gbxSil.TabStop = false;
            this.gbxSil.Text = "groupBox1";
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(8, 4);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(282, 17);
            this.lblNot.TabIndex = 39;
            this.lblNot.Text = "NOT: SİLMEK İÇİN TABLODAN VERİ SEÇİN";
            // 
            // dgvKitapGoster
            // 
            this.dgvKitapGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitapGoster.Location = new System.Drawing.Point(11, 25);
            this.dgvKitapGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvKitapGoster.Name = "dgvKitapGoster";
            this.dgvKitapGoster.ReadOnly = true;
            this.dgvKitapGoster.RowTemplate.Height = 50;
            this.dgvKitapGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKitapGoster.Size = new System.Drawing.Size(748, 161);
            this.dgvKitapGoster.TabIndex = 13;
            this.dgvKitapGoster.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKitapGoster_CellMouseClick);
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.lblTur);
            this.gbxEkle.Controls.Add(this.cmbxKitapTur);
            this.gbxEkle.Controls.Add(this.pbxKitapFotograf);
            this.gbxEkle.Controls.Add(this.btnKitapEkle);
            this.gbxEkle.Controls.Add(this.lblPage);
            this.gbxEkle.Controls.Add(this.txtSayfa);
            this.gbxEkle.Controls.Add(this.lblPublisher);
            this.gbxEkle.Controls.Add(this.lblPrice);
            this.gbxEkle.Controls.Add(this.lblisbn);
            this.gbxEkle.Controls.Add(this.lblAuthor);
            this.gbxEkle.Controls.Add(this.lblName);
            this.gbxEkle.Controls.Add(this.txtYayin);
            this.gbxEkle.Controls.Add(this.txtFiyat);
            this.gbxEkle.Controls.Add(this.txtIsbn);
            this.gbxEkle.Controls.Add(this.txtYazar);
            this.gbxEkle.Controls.Add(this.txtAdi);
            this.gbxEkle.Location = new System.Drawing.Point(16, 30);
            this.gbxEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEkle.Size = new System.Drawing.Size(664, 254);
            this.gbxEkle.TabIndex = 45;
            this.gbxEkle.TabStop = false;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTur.Location = new System.Drawing.Point(8, 185);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(49, 17);
            this.lblTur.TabIndex = 42;
            this.lblTur.Text = "TÜR: ";
            // 
            // cmbxKitapTur
            // 
            this.cmbxKitapTur.FormattingEnabled = true;
            this.cmbxKitapTur.Items.AddRange(new object[] {
            "Cizgi Roman",
            "Roman",
            "Felsefe",
            "Tarih"});
            this.cmbxKitapTur.Location = new System.Drawing.Point(124, 177);
            this.cmbxKitapTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxKitapTur.MaxLength = 14;
            this.cmbxKitapTur.Name = "cmbxKitapTur";
            this.cmbxKitapTur.Size = new System.Drawing.Size(253, 24);
            this.cmbxKitapTur.TabIndex = 41;
            // 
            // pbxKitapFotograf
            // 
            this.pbxKitapFotograf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxKitapFotograf.Image = ((System.Drawing.Image)(resources.GetObject("pbxKitapFotograf.Image")));
            this.pbxKitapFotograf.Location = new System.Drawing.Point(469, 9);
            this.pbxKitapFotograf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxKitapFotograf.Name = "pbxKitapFotograf";
            this.pbxKitapFotograf.Size = new System.Drawing.Size(169, 206);
            this.pbxKitapFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKitapFotograf.TabIndex = 40;
            this.pbxKitapFotograf.TabStop = false;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnKitapEkle.Location = new System.Drawing.Point(301, 217);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKitapEkle.TabIndex = 12;
            this.btnKitapEkle.Text = "EKLE";
            this.btnKitapEkle.UseVisualStyleBackColor = false;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPage.Location = new System.Drawing.Point(8, 154);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(63, 17);
            this.lblPage.TabIndex = 11;
            this.lblPage.Text = "SAYFA:";
            // 
            // txtSayfa
            // 
            this.txtSayfa.Location = new System.Drawing.Point(124, 149);
            this.txtSayfa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayfa.Name = "txtSayfa";
            this.txtSayfa.Size = new System.Drawing.Size(253, 22);
            this.txtSayfa.TabIndex = 10;
            this.txtSayfa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSayfa_KeyPress);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPublisher.Location = new System.Drawing.Point(8, 126);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(60, 17);
            this.lblPublisher.TabIndex = 9;
            this.lblPublisher.Text = "YAYIN:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(8, 98);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 17);
            this.lblPrice.TabIndex = 8;
            this.lblPrice.Text = "FİYAT:";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblisbn.Location = new System.Drawing.Point(8, 70);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(110, 17);
            this.lblisbn.TabIndex = 7;
            this.lblisbn.Text = "ISBN NUMBER";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblAuthor.Location = new System.Drawing.Point(8, 42);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(64, 17);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "YAZAR:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(8, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 17);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "ADI:";
            // 
            // txtYayin
            // 
            this.txtYayin.Location = new System.Drawing.Point(124, 121);
            this.txtYayin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYayin.MaxLength = 24;
            this.txtYayin.Name = "txtYayin";
            this.txtYayin.Size = new System.Drawing.Size(253, 22);
            this.txtYayin.TabIndex = 4;
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(124, 94);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(253, 22);
            this.txtFiyat.TabIndex = 3;
            this.txtFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiyat_KeyPress);
            // 
            // txtIsbn
            // 
            this.txtIsbn.Location = new System.Drawing.Point(124, 65);
            this.txtIsbn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsbn.MaxLength = 19;
            this.txtIsbn.Name = "txtIsbn";
            this.txtIsbn.Size = new System.Drawing.Size(253, 22);
            this.txtIsbn.TabIndex = 2;
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(124, 37);
            this.txtYazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtYazar.MaxLength = 24;
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(253, 22);
            this.txtYazar.TabIndex = 1;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(124, 9);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdi.MaxLength = 24;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(253, 22);
            this.txtAdi.TabIndex = 0;
            // 
            // tpageDRKitapCek
            // 
            this.tpageDRKitapCek.Controls.Add(this.lblTur1);
            this.tpageDRKitapCek.Controls.Add(this.cmbKitapDR);
            this.tpageDRKitapCek.Controls.Add(this.lblIsbn1);
            this.tpageDRKitapCek.Controls.Add(this.txtIsbnDR);
            this.tpageDRKitapCek.Controls.Add(this.btnKitapEkleDR);
            this.tpageDRKitapCek.Controls.Add(this.dgwDr);
            this.tpageDRKitapCek.Controls.Add(this.btnVeriCekKitapDr);
            this.tpageDRKitapCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tpageDRKitapCek.Location = new System.Drawing.Point(4, 25);
            this.tpageDRKitapCek.Margin = new System.Windows.Forms.Padding(4);
            this.tpageDRKitapCek.Name = "tpageDRKitapCek";
            this.tpageDRKitapCek.Padding = new System.Windows.Forms.Padding(4);
            this.tpageDRKitapCek.Size = new System.Drawing.Size(808, 517);
            this.tpageDRKitapCek.TabIndex = 1;
            this.tpageDRKitapCek.Text = "D&R KİTAP EKLE";
            this.tpageDRKitapCek.UseVisualStyleBackColor = true;
            // 
            // lblTur1
            // 
            this.lblTur1.AutoSize = true;
            this.lblTur1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTur1.Location = new System.Drawing.Point(29, 384);
            this.lblTur1.Name = "lblTur1";
            this.lblTur1.Size = new System.Drawing.Size(49, 17);
            this.lblTur1.TabIndex = 44;
            this.lblTur1.Text = "TÜR: ";
            // 
            // cmbKitapDR
            // 
            this.cmbKitapDR.FormattingEnabled = true;
            this.cmbKitapDR.Items.AddRange(new object[] {
            "Cizgi Roman",
            "Roman",
            "Felsefe",
            "Tarih"});
            this.cmbKitapDR.Location = new System.Drawing.Point(145, 377);
            this.cmbKitapDR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbKitapDR.MaxLength = 14;
            this.cmbKitapDR.Name = "cmbKitapDR";
            this.cmbKitapDR.Size = new System.Drawing.Size(253, 25);
            this.cmbKitapDR.TabIndex = 43;
            // 
            // lblIsbn1
            // 
            this.lblIsbn1.AutoSize = true;
            this.lblIsbn1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblIsbn1.Location = new System.Drawing.Point(8, 337);
            this.lblIsbn1.Name = "lblIsbn1";
            this.lblIsbn1.Size = new System.Drawing.Size(110, 17);
            this.lblIsbn1.TabIndex = 9;
            this.lblIsbn1.Text = "ISBN NUMBER";
            // 
            // txtIsbnDR
            // 
            this.txtIsbnDR.Location = new System.Drawing.Point(145, 331);
            this.txtIsbnDR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIsbnDR.MaxLength = 19;
            this.txtIsbnDR.Name = "txtIsbnDR";
            this.txtIsbnDR.Size = new System.Drawing.Size(253, 23);
            this.txtIsbnDR.TabIndex = 8;
            // 
            // btnKitapEkleDR
            // 
            this.btnKitapEkleDR.BackColor = System.Drawing.Color.Transparent;
            this.btnKitapEkleDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapEkleDR.Location = new System.Drawing.Point(541, 329);
            this.btnKitapEkleDR.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkleDR.Name = "btnKitapEkleDR";
            this.btnKitapEkleDR.Size = new System.Drawing.Size(197, 28);
            this.btnKitapEkleDR.TabIndex = 2;
            this.btnKitapEkleDR.Text = "EKLE";
            this.btnKitapEkleDR.UseVisualStyleBackColor = true;
            this.btnKitapEkleDR.Click += new System.EventHandler(this.btnKitapEkleDR_Click);
            // 
            // dgwDr
            // 
            this.dgwDr.AllowUserToAddRows = false;
            this.dgwDr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDr.Location = new System.Drawing.Point(9, 92);
            this.dgwDr.Margin = new System.Windows.Forms.Padding(4);
            this.dgwDr.Name = "dgwDr";
            this.dgwDr.ReadOnly = true;
            this.dgwDr.RowTemplate.Height = 50;
            this.dgwDr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDr.Size = new System.Drawing.Size(752, 226);
            this.dgwDr.TabIndex = 1;
            this.dgwDr.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwDr_CellMouseClick);
            // 
            // btnVeriCekKitapDr
            // 
            this.btnVeriCekKitapDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriCekKitapDr.Location = new System.Drawing.Point(9, 4);
            this.btnVeriCekKitapDr.Margin = new System.Windows.Forms.Padding(4);
            this.btnVeriCekKitapDr.Name = "btnVeriCekKitapDr";
            this.btnVeriCekKitapDr.Size = new System.Drawing.Size(197, 46);
            this.btnVeriCekKitapDr.TabIndex = 0;
            this.btnVeriCekKitapDr.Text = "D&R KİTAPLARI ÇEK";
            this.btnVeriCekKitapDr.UseVisualStyleBackColor = true;
            this.btnVeriCekKitapDr.Click += new System.EventHandler(this.btnVeriCekKitapDr_Click);
            // 
            // FormEkleKitap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(825, 502);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEkleKitap";
            this.Text = "KİTAP KAYIT EKRANI";
            this.Load += new System.EventHandler(this.FormEkleKitap_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpageKitapEkle.ResumeLayout(false);
            this.gbxSil.ResumeLayout(false);
            this.gbxSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitapGoster)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKitapFotograf)).EndInit();
            this.tpageDRKitapCek.ResumeLayout(false);
            this.tpageDRKitapCek.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpageKitapEkle;
        public System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.DataGridView dgvKitapGoster;
        public System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.ComboBox cmbxKitapTur;
        private System.Windows.Forms.PictureBox pbxKitapFotograf;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.TextBox txtSayfa;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtYayin;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.TextBox txtIsbn;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TabPage tpageDRKitapCek;
        private System.Windows.Forms.DataGridView dgwDr;
        private System.Windows.Forms.Button btnVeriCekKitapDr;
        private System.Windows.Forms.Button btnKitapEkleDR;
        private System.Windows.Forms.Label lblIsbn1;
        private System.Windows.Forms.TextBox txtIsbnDR;
        private System.Windows.Forms.Label lblTur1;
        private System.Windows.Forms.ComboBox cmbKitapDR;
    }
}