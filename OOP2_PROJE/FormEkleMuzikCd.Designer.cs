namespace OOP2_PROJE
{
    partial class FormEkleMuzikCd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEkleMuzikCd));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpageCdEkle = new System.Windows.Forms.TabPage();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.dgvMuzikCdGoster = new System.Windows.Forms.DataGridView();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.cmbxTur = new System.Windows.Forms.ComboBox();
            this.pbxMuzikCdFotograf = new System.Windows.Forms.PictureBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnMuzikCdEkle = new System.Windows.Forms.Button();
            this.lblType = new System.Windows.Forms.Label();
            this.lblKonu = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSarkici = new System.Windows.Forms.TextBox();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.tpageCdEkleDR = new System.Windows.Forms.TabPage();
            this.cmbTur1 = new System.Windows.Forms.ComboBox();
            this.lblTur1 = new System.Windows.Forms.Label();
            this.btnCdEkleDR = new System.Windows.Forms.Button();
            this.dgwDr = new System.Windows.Forms.DataGridView();
            this.btnVeriCekMusicCdDr = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpageCdEkle.SuspendLayout();
            this.gbxSil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuzikCdGoster)).BeginInit();
            this.gbxEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuzikCdFotograf)).BeginInit();
            this.tpageCdEkleDR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDr)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpageCdEkle);
            this.tabControl1.Controls.Add(this.tpageCdEkleDR);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 505);
            this.tabControl1.TabIndex = 0;
            // 
            // tpageCdEkle
            // 
            this.tpageCdEkle.Controls.Add(this.gbxSil);
            this.tpageCdEkle.Controls.Add(this.gbxEkle);
            this.tpageCdEkle.Location = new System.Drawing.Point(4, 25);
            this.tpageCdEkle.Margin = new System.Windows.Forms.Padding(4);
            this.tpageCdEkle.Name = "tpageCdEkle";
            this.tpageCdEkle.Padding = new System.Windows.Forms.Padding(4);
            this.tpageCdEkle.Size = new System.Drawing.Size(781, 476);
            this.tpageCdEkle.TabIndex = 0;
            this.tpageCdEkle.Text = "MÜZİK CD EKLE";
            this.tpageCdEkle.UseVisualStyleBackColor = true;
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.lblNot);
            this.gbxSil.Controls.Add(this.dgvMuzikCdGoster);
            this.gbxSil.Location = new System.Drawing.Point(-16, 194);
            this.gbxSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxSil.Size = new System.Drawing.Size(812, 265);
            this.gbxSil.TabIndex = 44;
            this.gbxSil.TabStop = false;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Location = new System.Drawing.Point(11, 10);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(282, 17);
            this.lblNot.TabIndex = 38;
            this.lblNot.Text = "NOT: SİLMEK İÇİN TABLODAN VERİ SEÇİN";
            // 
            // dgvMuzikCdGoster
            // 
            this.dgvMuzikCdGoster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuzikCdGoster.Location = new System.Drawing.Point(13, 30);
            this.dgvMuzikCdGoster.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMuzikCdGoster.Name = "dgvMuzikCdGoster";
            this.dgvMuzikCdGoster.ReadOnly = true;
            this.dgvMuzikCdGoster.RowTemplate.Height = 100;
            this.dgvMuzikCdGoster.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuzikCdGoster.Size = new System.Drawing.Size(793, 217);
            this.dgvMuzikCdGoster.TabIndex = 37;
            this.dgvMuzikCdGoster.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMuzikCdGoster_CellMouseClick);
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.cmbxTur);
            this.gbxEkle.Controls.Add(this.pbxMuzikCdFotograf);
            this.gbxEkle.Controls.Add(this.lblPrice);
            this.gbxEkle.Controls.Add(this.txtFiyat);
            this.gbxEkle.Controls.Add(this.btnMuzikCdEkle);
            this.gbxEkle.Controls.Add(this.lblType);
            this.gbxEkle.Controls.Add(this.lblKonu);
            this.gbxEkle.Controls.Add(this.lblName);
            this.gbxEkle.Controls.Add(this.txtSarkici);
            this.gbxEkle.Controls.Add(this.txtAdi);
            this.gbxEkle.Location = new System.Drawing.Point(-16, 15);
            this.gbxEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxEkle.Size = new System.Drawing.Size(667, 162);
            this.gbxEkle.TabIndex = 43;
            this.gbxEkle.TabStop = false;
            // 
            // cmbxTur
            // 
            this.cmbxTur.FormattingEnabled = true;
            this.cmbxTur.Items.AddRange(new object[] {
            "Romance",
            "Hard_Rock",
            "Country"});
            this.cmbxTur.Location = new System.Drawing.Point(125, 103);
            this.cmbxTur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxTur.Name = "cmbxTur";
            this.cmbxTur.Size = new System.Drawing.Size(253, 24);
            this.cmbxTur.TabIndex = 40;
            // 
            // pbxMuzikCdFotograf
            // 
            this.pbxMuzikCdFotograf.Image = ((System.Drawing.Image)(resources.GetObject("pbxMuzikCdFotograf.Image")));
            this.pbxMuzikCdFotograf.Location = new System.Drawing.Point(455, 17);
            this.pbxMuzikCdFotograf.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxMuzikCdFotograf.Name = "pbxMuzikCdFotograf";
            this.pbxMuzikCdFotograf.Size = new System.Drawing.Size(108, 112);
            this.pbxMuzikCdFotograf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxMuzikCdFotograf.TabIndex = 39;
            this.pbxMuzikCdFotograf.TabStop = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(11, 50);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(58, 17);
            this.lblPrice.TabIndex = 36;
            this.lblPrice.Text = "FİYAT:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(125, 46);
            this.txtFiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(253, 22);
            this.txtFiyat.TabIndex = 35;
            // 
            // btnMuzikCdEkle
            // 
            this.btnMuzikCdEkle.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMuzikCdEkle.Location = new System.Drawing.Point(304, 133);
            this.btnMuzikCdEkle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMuzikCdEkle.Name = "btnMuzikCdEkle";
            this.btnMuzikCdEkle.Size = new System.Drawing.Size(75, 23);
            this.btnMuzikCdEkle.TabIndex = 34;
            this.btnMuzikCdEkle.Text = "EKLE";
            this.btnMuzikCdEkle.UseVisualStyleBackColor = false;
            this.btnMuzikCdEkle.Click += new System.EventHandler(this.btnMuzikCdEkle_Click);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblType.Location = new System.Drawing.Point(11, 106);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(44, 17);
            this.lblType.TabIndex = 33;
            this.lblType.Text = "TÜR:";
            // 
            // lblKonu
            // 
            this.lblKonu.AutoSize = true;
            this.lblKonu.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblKonu.Location = new System.Drawing.Point(11, 78);
            this.lblKonu.Name = "lblKonu";
            this.lblKonu.Size = new System.Drawing.Size(79, 17);
            this.lblKonu.TabIndex = 31;
            this.lblKonu.Text = "ŞARKICI: ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(11, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 17);
            this.lblName.TabIndex = 30;
            this.lblName.Text = "ADI:";
            // 
            // txtSarkici
            // 
            this.txtSarkici.Location = new System.Drawing.Point(125, 73);
            this.txtSarkici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSarkici.MaxLength = 24;
            this.txtSarkici.Name = "txtSarkici";
            this.txtSarkici.Size = new System.Drawing.Size(253, 22);
            this.txtSarkici.TabIndex = 29;
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(125, 17);
            this.txtAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAdi.MaxLength = 24;
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(253, 22);
            this.txtAdi.TabIndex = 28;
            // 
            // tpageCdEkleDR
            // 
            this.tpageCdEkleDR.Controls.Add(this.cmbTur1);
            this.tpageCdEkleDR.Controls.Add(this.lblTur1);
            this.tpageCdEkleDR.Controls.Add(this.btnCdEkleDR);
            this.tpageCdEkleDR.Controls.Add(this.dgwDr);
            this.tpageCdEkleDR.Controls.Add(this.btnVeriCekMusicCdDr);
            this.tpageCdEkleDR.Location = new System.Drawing.Point(4, 25);
            this.tpageCdEkleDR.Margin = new System.Windows.Forms.Padding(4);
            this.tpageCdEkleDR.Name = "tpageCdEkleDR";
            this.tpageCdEkleDR.Padding = new System.Windows.Forms.Padding(4);
            this.tpageCdEkleDR.Size = new System.Drawing.Size(781, 476);
            this.tpageCdEkleDR.TabIndex = 1;
            this.tpageCdEkleDR.Text = "D&R MÜZİK CD EKLE";
            this.tpageCdEkleDR.UseVisualStyleBackColor = true;
            // 
            // cmbTur1
            // 
            this.cmbTur1.FormattingEnabled = true;
            this.cmbTur1.Items.AddRange(new object[] {
            "Romance",
            "Hard_Rock",
            "Country"});
            this.cmbTur1.Location = new System.Drawing.Point(85, 368);
            this.cmbTur1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbTur1.Name = "cmbTur1";
            this.cmbTur1.Size = new System.Drawing.Size(253, 24);
            this.cmbTur1.TabIndex = 52;
            // 
            // lblTur1
            // 
            this.lblTur1.AutoSize = true;
            this.lblTur1.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTur1.Location = new System.Drawing.Point(11, 372);
            this.lblTur1.Name = "lblTur1";
            this.lblTur1.Size = new System.Drawing.Size(49, 17);
            this.lblTur1.TabIndex = 51;
            this.lblTur1.Text = "TÜR: ";
            // 
            // btnCdEkleDR
            // 
            this.btnCdEkleDR.BackColor = System.Drawing.Color.Transparent;
            this.btnCdEkleDR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCdEkleDR.Location = new System.Drawing.Point(547, 362);
            this.btnCdEkleDR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCdEkleDR.Name = "btnCdEkleDR";
            this.btnCdEkleDR.Size = new System.Drawing.Size(197, 28);
            this.btnCdEkleDR.TabIndex = 47;
            this.btnCdEkleDR.Text = "EKLE";
            this.btnCdEkleDR.UseVisualStyleBackColor = true;
            this.btnCdEkleDR.Click += new System.EventHandler(this.btnCdEkleDR_Click);
            // 
            // dgwDr
            // 
            this.dgwDr.AllowUserToAddRows = false;
            this.dgwDr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwDr.Location = new System.Drawing.Point(15, 126);
            this.dgwDr.Margin = new System.Windows.Forms.Padding(4);
            this.dgwDr.Name = "dgwDr";
            this.dgwDr.ReadOnly = true;
            this.dgwDr.RowTemplate.Height = 50;
            this.dgwDr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwDr.Size = new System.Drawing.Size(752, 226);
            this.dgwDr.TabIndex = 46;
            this.dgwDr.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwDr_CellMouseClick);
            // 
            // btnVeriCekMusicCdDr
            // 
            this.btnVeriCekMusicCdDr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnVeriCekMusicCdDr.Location = new System.Drawing.Point(15, 37);
            this.btnVeriCekMusicCdDr.Margin = new System.Windows.Forms.Padding(4);
            this.btnVeriCekMusicCdDr.Name = "btnVeriCekMusicCdDr";
            this.btnVeriCekMusicCdDr.Size = new System.Drawing.Size(197, 46);
            this.btnVeriCekMusicCdDr.TabIndex = 45;
            this.btnVeriCekMusicCdDr.Text = "D&R  CDLERİ ÇEK";
            this.btnVeriCekMusicCdDr.UseVisualStyleBackColor = true;
            this.btnVeriCekMusicCdDr.Click += new System.EventHandler(this.btnVeriCekMusicCdDr_Click);
            // 
            // FormEkleMuzikCd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormEkleMuzikCd";
            this.Text = "MUZİK CD KAYIT EKRANI";
            this.Load += new System.EventHandler(this.FormEkleMuzikCd_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpageCdEkle.ResumeLayout(false);
            this.gbxSil.ResumeLayout(false);
            this.gbxSil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuzikCdGoster)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMuzikCdFotograf)).EndInit();
            this.tpageCdEkleDR.ResumeLayout(false);
            this.tpageCdEkleDR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwDr)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpageCdEkle;
        public System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.DataGridView dgvMuzikCdGoster;
        public System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.ComboBox cmbxTur;
        private System.Windows.Forms.PictureBox pbxMuzikCdFotograf;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnMuzikCdEkle;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblKonu;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSarkici;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.TabPage tpageCdEkleDR;
        private System.Windows.Forms.ComboBox cmbTur1;
        private System.Windows.Forms.Label lblTur1;
        private System.Windows.Forms.Button btnCdEkleDR;
        private System.Windows.Forms.DataGridView dgwDr;
        private System.Windows.Forms.Button btnVeriCekMusicCdDr;
    }
}