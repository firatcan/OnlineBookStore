namespace OOP2_PROJE
{
    partial class FormSifremiUnuttum
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
            this.txtKullaniciAdiAl = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.btnMailGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtKullaniciAdiAl
            // 
            this.txtKullaniciAdiAl.Location = new System.Drawing.Point(127, 10);
            this.txtKullaniciAdiAl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKullaniciAdiAl.MaxLength = 24;
            this.txtKullaniciAdiAl.Name = "txtKullaniciAdiAl";
            this.txtKullaniciAdiAl.Size = new System.Drawing.Size(149, 20);
            this.txtKullaniciAdiAl.TabIndex = 0;
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullaniciAdi.Location = new System.Drawing.Point(19, 12);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(96, 13);
            this.lblKullaniciAdi.TabIndex = 1;
            this.lblKullaniciAdi.Text = "KULLANICI ADI";
            // 
            // btnMailGonder
            // 
            this.btnMailGonder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMailGonder.Location = new System.Drawing.Point(209, 32);
            this.btnMailGonder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMailGonder.Name = "btnMailGonder";
            this.btnMailGonder.Size = new System.Drawing.Size(65, 19);
            this.btnMailGonder.TabIndex = 2;
            this.btnMailGonder.Text = "GONDER";
            this.btnMailGonder.UseVisualStyleBackColor = false;
            this.btnMailGonder.Click += new System.EventHandler(this.btnMailGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "*Kullanıcı adınızı girin. Şifreniz E-mail adresinize gönderilecektir.";
            // 
            // FormSifremiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 85);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMailGonder);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.txtKullaniciAdiAl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSifremiUnuttum";
            this.Text = "SİFREMİ UNUTTUM";
            this.Load += new System.EventHandler(this.FormSifremiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKullaniciAdiAl;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Button btnMailGonder;
        private System.Windows.Forms.Label label1;
    }
}