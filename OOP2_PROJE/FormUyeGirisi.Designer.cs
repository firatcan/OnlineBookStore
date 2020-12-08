namespace OOP2_PROJE
{
    partial class FormUyeGirisi
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
            this.lblSifreUyeGirisi = new System.Windows.Forms.Label();
            this.txtSifreUyeGirisi = new System.Windows.Forms.TextBox();
            this.btnUyeGirisiOnay = new System.Windows.Forms.Button();
            this.lblKullaniciAdiUyeGirisi = new System.Windows.Forms.Label();
            this.txtKullaniciAdiUyeGirisi = new System.Windows.Forms.TextBox();
            this.btnSifremiUnuttum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSifreUyeGirisi
            // 
            this.lblSifreUyeGirisi.AutoSize = true;
            this.lblSifreUyeGirisi.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblSifreUyeGirisi.Location = new System.Drawing.Point(12, 70);
            this.lblSifreUyeGirisi.Name = "lblSifreUyeGirisi";
            this.lblSifreUyeGirisi.Size = new System.Drawing.Size(44, 17);
            this.lblSifreUyeGirisi.TabIndex = 14;
            this.lblSifreUyeGirisi.Text = "Sifre";
            // 
            // txtSifreUyeGirisi
            // 
            this.txtSifreUyeGirisi.Font = new System.Drawing.Font("Vivaldi", 8.25F);
            this.txtSifreUyeGirisi.Location = new System.Drawing.Point(144, 70);
            this.txtSifreUyeGirisi.MaxLength = 14;
            this.txtSifreUyeGirisi.Name = "txtSifreUyeGirisi";
            this.txtSifreUyeGirisi.Size = new System.Drawing.Size(223, 24);
            this.txtSifreUyeGirisi.TabIndex = 13;
            this.txtSifreUyeGirisi.TextChanged += new System.EventHandler(this.txtSifreUyeGirisi_TextChanged);
            // 
            // btnUyeGirisiOnay
            // 
            this.btnUyeGirisiOnay.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnUyeGirisiOnay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeGirisiOnay.Location = new System.Drawing.Point(246, 119);
            this.btnUyeGirisiOnay.Name = "btnUyeGirisiOnay";
            this.btnUyeGirisiOnay.Size = new System.Drawing.Size(121, 28);
            this.btnUyeGirisiOnay.TabIndex = 12;
            this.btnUyeGirisiOnay.Text = "Giris";
            this.btnUyeGirisiOnay.UseVisualStyleBackColor = false;
            this.btnUyeGirisiOnay.Click += new System.EventHandler(this.btnUyeGirisiOnay_Click);
            // 
            // lblKullaniciAdiUyeGirisi
            // 
            this.lblKullaniciAdiUyeGirisi.AutoSize = true;
            this.lblKullaniciAdiUyeGirisi.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullaniciAdiUyeGirisi.Location = new System.Drawing.Point(12, 34);
            this.lblKullaniciAdiUyeGirisi.Name = "lblKullaniciAdiUyeGirisi";
            this.lblKullaniciAdiUyeGirisi.Size = new System.Drawing.Size(111, 17);
            this.lblKullaniciAdiUyeGirisi.TabIndex = 11;
            this.lblKullaniciAdiUyeGirisi.Text = "Kullanıcı Adı ";
            // 
            // txtKullaniciAdiUyeGirisi
            // 
            this.txtKullaniciAdiUyeGirisi.Location = new System.Drawing.Point(144, 31);
            this.txtKullaniciAdiUyeGirisi.MaxLength = 24;
            this.txtKullaniciAdiUyeGirisi.Name = "txtKullaniciAdiUyeGirisi";
            this.txtKullaniciAdiUyeGirisi.Size = new System.Drawing.Size(223, 22);
            this.txtKullaniciAdiUyeGirisi.TabIndex = 10;
            // 
            // btnSifremiUnuttum
            // 
            this.btnSifremiUnuttum.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSifremiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            this.btnSifremiUnuttum.Location = new System.Drawing.Point(246, 153);
            this.btnSifremiUnuttum.Name = "btnSifremiUnuttum";
            this.btnSifremiUnuttum.Size = new System.Drawing.Size(121, 28);
            this.btnSifremiUnuttum.TabIndex = 15;
            this.btnSifremiUnuttum.Text = "Sifremi Unuttum";
            this.btnSifremiUnuttum.UseVisualStyleBackColor = false;
            this.btnSifremiUnuttum.Click += new System.EventHandler(this.btnSifremiUnuttum_Click);
            // 
            // FormUyeGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 213);
            this.Controls.Add(this.btnSifremiUnuttum);
            this.Controls.Add(this.lblSifreUyeGirisi);
            this.Controls.Add(this.txtSifreUyeGirisi);
            this.Controls.Add(this.btnUyeGirisiOnay);
            this.Controls.Add(this.lblKullaniciAdiUyeGirisi);
            this.Controls.Add(this.txtKullaniciAdiUyeGirisi);
            this.Name = "FormUyeGirisi";
            this.Text = "FormUyeGirisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSifreUyeGirisi;
        private System.Windows.Forms.TextBox txtSifreUyeGirisi;
        private System.Windows.Forms.Button btnUyeGirisiOnay;
        private System.Windows.Forms.Label lblKullaniciAdiUyeGirisi;
        private System.Windows.Forms.TextBox txtKullaniciAdiUyeGirisi;
        private System.Windows.Forms.Button btnSifremiUnuttum;
    }
}