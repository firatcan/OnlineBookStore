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
    public partial class FormProfilim : Form
    {
        /// <summary>
        /// FormProfilim constructor
        /// </summary>
        public FormProfilim()
        {
            InitializeComponent();
            CenterToScreen();
        }
        Customer CustomerNesnesi = FormAnaEkran.CustomerNesnesi;
        /// <summary>
        /// butona tiklandiginda musterinin kendi bilgilerini guncelleyebildigi fonksiyon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnGuncelle.Name, CustomerNesnesi.userName);
                this.Close();
            }
            FormKayitOl formKayitOl_obj = new FormKayitOl();
            formKayitOl_obj.btnGuncelle.Enabled = true;
            formKayitOl_obj.btnKayitOlOnay.Enabled = false;
            formKayitOl_obj.Show();
        }
    }
}
