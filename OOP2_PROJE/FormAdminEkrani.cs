using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    public partial class FormAdminEkrani : Form
    {

        private static FormAdminEkrani singletonNesnesi = null;
        /// <summary>
        /// FormAdminEkrani constructor
        /// </summary>
        private FormAdminEkrani()
        {
            InitializeComponent();
        }
        /// <summary>
        /// FormAdminEkrani singleton nesnesi
        /// </summary>
        public static FormAdminEkrani formAdminEkrani
        {
            get
            {
                if (singletonNesnesi == null)
                {
                    singletonNesnesi = new FormAdminEkrani();

                }
                return singletonNesnesi;
            }

        }
        /// <summary>
        /// admin tarafindan kitap ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnKitapEkle.Name, adminUserNesnesi.userName);
            FormEkleKitap formEkleKitap_obj = new FormEkleKitap();
            formEkleKitap_obj.gbxSil.Visible = false;
            formEkleKitap_obj.gbxEkle.Enabled = true;
            formEkleKitap_obj.Show();
        }
        /// <summary>
        /// admin tarafindan dergi ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDergiEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnDergiEkle.Name, adminUserNesnesi.userName);
            FormEkleDergi formEkleDergi_obj = new FormEkleDergi();
            formEkleDergi_obj.gbxSil.Visible = false;
            formEkleDergi_obj.gbxEkle.Enabled = true;
            formEkleDergi_obj.Show();
        }
        /// <summary>
        /// admin tarafindan muzik cd ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMuzikCdEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnMuzikCdEkle.Name, adminUserNesnesi.userName);
            FormEkleMuzikCd formEkleMuzikCd_obj = new FormEkleMuzikCd();
            formEkleMuzikCd_obj.gbxEkle.Enabled = true;
            formEkleMuzikCd_obj.gbxSil.Visible = false;
            formEkleMuzikCd_obj.Show();
        }
        /// <summary>
        /// admin tarafindan yeni admin ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYeniAdminEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnYeniAdminEkle.Name, adminUserNesnesi.userName);
            AdminUser admin = AdminUser.adminUser;
            FormEkleAdmin formEkleAdmin_obj = new FormEkleAdmin();
            formEkleAdmin_obj.gbxEkle.Enabled = true;
            formEkleAdmin_obj.gbxSil.Visible = false;
            formEkleAdmin_obj.Show();
        }
        /// <summary>
        /// admin tarafindan kitap silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnKitapSil.Name, adminUserNesnesi.userName);
            FormEkleKitap formEkleKitap_obj = new FormEkleKitap();
            formEkleKitap_obj.gbxEkle.Enabled = false;
            formEkleKitap_obj.gbxSil.Visible = true;
            formEkleKitap_obj.Show();
        }
        /// <summary>
        /// admin tarafindan dergi silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDergiSil_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnDergiSil.Name, adminUserNesnesi.userName);
            FormEkleDergi formEkleDergi_obj = new FormEkleDergi();
            formEkleDergi_obj.gbxSil.Visible = true;
            formEkleDergi_obj.gbxEkle.Enabled = false;
            formEkleDergi_obj.Show();
        }
        /// <summary>
        /// admin tarafindan muzik cd silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLblAdminCikis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, linkLblAdminCikis.Name, adminUserNesnesi.userName);
            FormAnaEkran anaEkran = FormAnaEkran.formAnaEkran;
            anaEkran.linklblCikisYap.Visible = false;
            anaEkran.linklblKayitOl.Visible = true;
            anaEkran.linklblUyeGirisi.Visible = true;
            adminUserNesnesi = null;
            this.Close();
        }
        DialogResult diaRes = new DialogResult();
        /// <summary>
        /// form kapandi fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdminEkrani_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            if (diaRes == DialogResult.Yes)
            {
                FormAnaEkran anaEkran = FormAnaEkran.formAnaEkran;
                anaEkran.linklblCikisYap.Visible = false;
                anaEkran.linklblKayitOl.Visible = true;
                anaEkran.linklblUyeGirisi.Visible = true;
                adminUserNesnesi = null;
                singletonNesnesi = null;
                MessageBox.Show("Çıkış Yapıldı");
            }
        }
        /// <summary>
        /// form kapaniyor fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdminEkrani_FormClosing(object sender, FormClosingEventArgs e)
        {
            diaRes=MessageBox.Show("Çıkış Yapmak İstediğinize Emin misiniz?","çıkış yapılıyor",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if (diaRes == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// admin bilgilerini admin ekranina yazan fonksiyon
        /// </summary>
        private void AdminBilgisi()
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            lblAdminAdi.Text = adminUserNesnesi.name;
            lblAdminKullaniciAdi.Text = adminUserNesnesi.userName;
        }
        /// <summary>
        /// admin tarafindan admin silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdminSil_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnAdminSil.Name, adminUserNesnesi.userName);
            AdminUser admin = AdminUser.adminUser;
            FormEkleAdmin formEkleAdmin_obj = new FormEkleAdmin();
            formEkleAdmin_obj.gbxEkle.Enabled = false;
            formEkleAdmin_obj.gbxSil.Visible = true;
            formEkleAdmin_obj.Show();
        }
        /// <summary>
        /// admin tarafindan muzik cd silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMuzikCdSil_Click_1(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnMuzikCdSil.Name, adminUserNesnesi.userName);
            FormEkleMuzikCd formEkleMuzikCd_obj = new FormEkleMuzikCd();
            formEkleMuzikCd_obj.gbxEkle.Enabled = false;
            formEkleMuzikCd_obj.gbxSil.Visible = true;
            formEkleMuzikCd_obj.Show();
        }
        /// <summary>
        /// FormAdminEkrani Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdminEkrani_Load(object sender, EventArgs e)
        {
            CenterToScreen();
        }
    }
}
