namespace OOP2_PROJE
{
    partial class FormEkleDergi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkleDergi));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageDergiEKle = new System.Windows.Forms.TabPage();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.dgvDergiGoster = new System.Windows.Forms.DataGridView();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.cmbxTur = new System.Windows.Forms.ComboBox();
            this.pbxDergiFotograf = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnDergiEkle = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.tpageDergiEkleDR = new System.Windows.Forms.TabPage();
            this.lblSayi1 = new System.Windows.Forms.Label();
            this.txtSayi1 = new System.Windows.Forms.TextBox();
            this.cmbDergiTur = new System.Windows.Forms.ComboBox();
            this.lblTur1 = new System.Windows.Forms.Label();
            this.btnDergiEkleDR = new System.Windows.Forms.Button();
            this.dgwDr = new System.Windows.Forms.DataGridView();
            this.btnVeriCekDergiDr = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpageDergiEKle.SuspendLayout();
            this.gbxSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDergiGoster)).BeginInit();
            this.gbxEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDergiFotograf)).BeginInit();
            this.tpageDergiEkleDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDr)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageDergiEKle);
            this.tabControl1.Controls.Add(this.tpageDergiEkleDR);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(825, 560);
            this.tabControl1.TabIndex = 44;
            // 
            // tpageDergiEKle
            // 
            this.tpageDergiEKle.Controls.Add(this.gbxSil);
            this.tpageDergiEKle.Controls.Add(this.gbxEkle);
            this.tpageDergiEKle.Location = new System.Drawing.Point(4, 25);
            this.tpageDergiEKle.Margin = new System.Windows.Forms.Padding(4);
            this.tpageDergiEKle.Name = "tpageDergiEKle";
            this.tpageDergiEKle.Padding = new System.Windows.Forms.Padding(4);
            this.tpageDergiEKle.Size = new System.Drawing.Size(817, 531);
            this.tpageDergiEKle.TabIndex = 0;
            this.tpageDergiEKle.Text = "DERGİ EKLE";
            this.tpageDergiEKle.UseVisualStyleBackColor = true;
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.lblNot);
            this.gbxSil.Controls.Add(this.dgvDergiGoster);
            this.gbxSil.Location = new System.Drawing.Point(17, 198);
            this.gbxSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSil.Size = new System.Drawing.Size(779, 293);
            this.gbxSil.TabIndex = 49;
            this.gbxSil.TabStop = false;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(7, 0);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(282, 17);
            this.lblNot.TabIndex = 39;
            this.lblNot.Text = "NOT: SİLMEK İÇİN TABLODAN VERİ SEÇİN";
            // 
            // dgvDergiGoster
            // 
            this.dgvDergiGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDergiGoster.Location = new System.Drawing.Point(11, 20);
            this.dgvDergiGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDergiGoster.Name = "dgvDergiGoster";
            this.dgvDergiGoster.ReadOnly = true;
            this.dgvDergiGoster.RowTemplate.Height = 24;
            this.dgvDergiGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDergiGoster.Size = new System.Drawing.Size(757, 219);
            this.dgvDergiGoster.TabIndex = 28;
            this.dgvDergiGoster.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDergiGoster_CellMouseClick);
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.cmbxTur);
            this.gbxEkle.Controls.Add(this.pbxDergiFotograf);
            this.gbxEkle.Controls.Add(this.lblPrice);
            this.gbxEkle.Controls.Add(this.txtFiyat);
            this.gbxEkle.Controls.Add(this.btnDergiEkle);
            this.gbxEkle.Controls.Add(this.lblType);
            this.gbxEkle.Controls.Add(this.lblSayi);
            this.gbxEkle.Controls.Add(this.lblName);
            this.gbxEkle.Controls.Add(this.txtSayi);
            this.gbxEkle.Controls.Add(this.txtAdi);
            this.gbxEkle.Location = new System.Drawing.Point(17, 37);
            this.gbxEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEkle.Size = new System.Drawing.Size(607, 161);
            this.gbxEkle.TabIndex = 48;
            this.gbxEkle.TabStop = false;
            // 
            // cmbxTur
            // 
            this.cmbxTur.FormattingEnabled = true;
            this.cmbxTur.Items.AddRange(new object[] {
            "Actuals",
            "News",
            "Sport",
            "Computer",
            "Technology"});
            this.cmbxTur.Location = new System.Drawing.Point(123, 92);
            this.cmbxTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxTur.Name = "cmbxTur";
            this.cmbxTur.Size = new System.Drawing.Size(253, 24);
            this.cmbxTur.TabIndex = 41;
            // 
            // pbxDergiFotograf
            // 
            this.pbxDergiFotograf.Image = ((System.Drawing.Image)(resources.GetObject("pbxDergiFotograf.Image")));
            this.pbxDergiFotograf.Location = new System.Drawing.Point(445, 10);
            this.pbxDergiFotograf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxDergiFotograf.Name = "pbxDergiFotograf";
            this.pbxDergiFotograf.Size = new System.Drawing.Size(121, 135);
            this.pbxDergiFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDergiFotograf.TabIndex = 40;
            this.pbxDergiFotograf.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(7, 43);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 17);
            this.lblPrice.TabIndex = 27;
            this.lblPrice.Text = "FİYAT:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(123, 38);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(253, 22);
            this.txtFiyat.TabIndex = 26;
            // 
            // btnDergiEkle
            // 
            this.btnDergiEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnDergiEkle.Location = new System.Drawing.Point(301, 122);
            this.btnDergiEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDergiEkle.Name = "btnDergiEkle";
            this.btnDergiEkle.Size = new System.Drawing.Size(75, 23);
            this.btnDergiEkle.TabIndex = 25;
            this.btnDergiEkle.Text = "EKLE";
            this.btnDergiEkle.UseVisualStyleBackColor = false;
            this.btnDergiEkle.Click += new System.EventHandler(this.btnDergiEkle_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(7, 98);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 24;
            this.lblType.Text = "TÜR:";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSayi.Location = new System.Drawing.Point(7, 71);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(48, 17);
            this.lblSayi.TabIndex = 22;
            this.lblSayi.Text = "SAYI:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(7, 15);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 17);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "ADI:";
            // 
            // txtSayi
            // 
            this.txtSayi.Location = new System.Drawing.Point(123, 66);
            this.txtSayi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi.MaxLength = 49;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(253, 22);
            this.txtSayi.TabIndex = 17;
            this.txtSayi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKonu_KeyPress);
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(123, 10);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdi.MaxLength = 24;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(253, 22);
            this.txtAdi.TabIndex = 13;
            // 
            // tpageDergiEkleDR
            // 
            this.tpageDergiEkleDR.Controls.Add(this.lblSayi1);
            this.tpageDergiEkleDR.Controls.Add(this.txtSayi1);
            this.tpageDergiEkleDR.Controls.Add(this.cmbDergiTur);
            this.tpageDergiEkleDR.Controls.Add(this.lblTur1);
            this.tpageDergiEkleDR.Controls.Add(this.btnDergiEkleDR);
            this.tpageDergiEkleDR.Controls.Add(this.dgwDr);
            this.tpageDergiEkleDR.Controls.Add(this.btnVeriCekDergiDr);
            this.tpageDergiEkleDR.Location = new System.Drawing.Point(4, 25);
            this.tpageDergiEkleDR.Margin = new System.Windows.Forms.Padding(4);
            this.tpageDergiEkleDR.Name = "tpageDergiEkleDR";
            this.tpageDergiEkleDR.Padding = new System.Windows.Forms.Padding(4);
            this.tpageDergiEkleDR.Size = new System.Drawing.Size(817, 531);
            this.tpageDergiEkleDR.TabIndex = 1;
            this.tpageDergiEkleDR.Text = "D&R DERGİ EKLE";
            this.tpageDergiEkleDR.UseVisualStyleBackColor = true;
            // 
            // lblSayi1
            // 
            this.lblSayi1.AutoSize = true;
            this.lblSayi1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSayi1.Location = new System.Drawing.Point(29, 342);
            this.lblSayi1.Name = "lblSayi1";
            this.lblSayi1.Size = new System.Drawing.Size(48, 17);
            this.lblSayi1.TabIndex = 54;
            this.lblSayi1.Text = "SAYI:";
            // 
            // txtSayi1
            // 
            this.txtSayi1.Location = new System.Drawing.Point(145, 337);
            this.txtSayi1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSayi1.MaxLength = 49;
            this.txtSayi1.Name = "txtSayi1";
            this.txtSayi1.Size = new System.Drawing.Size(253, 22);
            this.txtSayi1.TabIndex = 53;
            // 
            // cmbDergiTur
            // 
            this.cmbDergiTur.FormattingEnabled = true;
            this.cmbDergiTur.Items.AddRange(new object[] {
            "Actuals",
            "News",
            "Sport",
            "Computer",
            "Technology"});
            this.cmbDergiTur.Location = new System.Drawing.Point(144, 384);
            this.cmbDergiTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDergiTur.Name = "cmbDergiTur";
            this.cmbDergiTur.Size = new System.Drawing.Size(253, 24);
            this.cmbDergiTur.TabIndex = 52;
            // 
            // lblTur1
            // 
            this.lblTur1.AutoSize = true;
            this.lblTur1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTur1.Location = new System.Drawing.Point(28, 388);
            this.lblTur1.Name = "lblTur1";
            this.lblTur1.Size = new System.Drawing.Size(49, 17);
            this.lblTur1.TabIndex = 51;
            this.lblTur1.Text = "TÜR: ";
            // 
            // btnDergiEkleDR
            // 
            this.btnDergiEkleDR.BackColor = System.Drawing.Color.Transparent;
            this.btnDergiEkleDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDergiEkleDR.Location = new System.Drawing.Point(540, 332);
            this.btnDergiEkleDR.Margin = new System.Windows.Forms.Padding(4);
            this.btnDergiEkleDR.Name = "btnDergiEkleDR";
            this.btnDergiEkleDR.Size = new System.Drawing.Size(197, 28);
            this.btnDergiEkleDR.TabIndex = 47;
            this.btnDergiEkleDR.Text = "EKLE";
            this.btnDergiEkleDR.UseVisualStyleBackColor = true;
            this.btnDergiEkleDR.Click += new System.EventHandler(this.btnDergiEkleDR_Click);
            // 
            // dgwDr
            // 
            this.dgwDr.AllowUserToAddRows = false;
            this.dgwDr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDr.Location = new System.Drawing.Point(8, 96);
            this.dgwDr.Margin = new System.Windows.Forms.Padding(4);
            this.dgwDr.Name = "dgwDr";
            this.dgwDr.ReadOnly = true;
            this.dgwDr.RowTemplate.Height = 50;
            this.dgwDr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDr.Size = new System.Drawing.Size(752, 226);
            this.dgwDr.TabIndex = 46;
            this.dgwDr.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwDr_CellMouseClick);
            // 
            // btnVeriCekDergiDr
            // 
            this.btnVeriCekDergiDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriCekDergiDr.Location = new System.Drawing.Point(8, 7);
            this.btnVeriCekDergiDr.Margin = new System.Windows.Forms.Padding(4);
            this.btnVeriCekDergiDr.Name = "btnVeriCekDergiDr";
            this.btnVeriCekDergiDr.Size = new System.Drawing.Size(197, 46);
            this.btnVeriCekDergiDr.TabIndex = 45;
            this.btnVeriCekDergiDr.Text = "D&R DERGİLERİ ÇEK";
            this.btnVeriCekDergiDr.UseVisualStyleBackColor = true;
            this.btnVeriCekDergiDr.Click += new System.EventHandler(this.btnVeriCekDergiDr_Click);
            // 
            // FormEkleDergi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(815, 479);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEkleDergi";
            this.Text = "DERGİ KAYIT EKRANI";
            this.Load += new System.EventHandler(this.FormEkleDergi_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpageDergiEKle.ResumeLayout(false);
            this.gbxSil.ResumeLayout(false);
            this.gbxSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDergiGoster)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDergiFotograf)).EndInit();
            this.tpageDergiEkleDR.ResumeLayout(false);
            this.tpageDergiEkleDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpageDergiEKle;
        private System.Windows.Forms.TabPage tpageDergiEkleDR;
        public System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.DataGridView dgvDergiGoster;
        public System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.ComboBox cmbxTur;
        private System.Windows.Forms.PictureBox pbxDergiFotograf;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnDergiEkle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblSayi;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label lblTur1;
        private System.Windows.Forms.Button btnDergiEkleDR;
        private System.Windows.Forms.DataGridView dgwDr;
        private System.Windows.Forms.Button btnVeriCekDergiDr;
        private System.Windows.Forms.Label lblSayi1;
        private System.Windows.Forms.TextBox txtSayi1;
        private System.Windows.Forms.ComboBox cmbDergiTur;
    }
}