/*****************************************
* FormSepet.cs
* *****************************************
* IDE : Visual Studio 2017
* * Author : SAMET SALGIN(sametsalgin10@gmail.com)
* * Date : 29.04.2019
* *****************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace OOP2_PROJE
{
    public partial class FormSepet : Form
    {

        static int  sayac = 0;
        int kontrol = 0;
        Book kitapSepet;
        Magazine dergiSepet;
        MusicCD cdSepet;

        internal static List<Product> listeSepet = new List<Product>();
        List<double> tutar = new List<double>();
        private static FormSepet singletonNesnesi = null;
        int time = 0;
        ShoppingCard sepetSinif = ShoppingCard.shoppingCard;
        Customer CustomerNesnesi = Customer.customer;
        /// <summary>
        /// FormSepet singleton fonksiyonu
        /// </summary>
        /// <returns></returns>
        public static FormSepet formSepet()
        {
            if (singletonNesnesi == null)
            {
                singletonNesnesi = new FormSepet();
            }
            return singletonNesnesi;
        }
        /// <summary>
        /// FormSepet constructor
        /// </summary>
        private FormSepet()
        {
            InitializeComponent();
        }
        /// <summary>
        /// urunu sepete ekleyen fonksiyon
        /// </summary>
        /// <param name="gelenSepetUrun"></param>
        public void FormSepeteekle(Product gelenSepetUrun)
        {
            esle();
            sepetSinif.addProduct(gelenSepetUrun, ref listeSepet);
        }
        /// <summary>
        /// ekrandaki dgwsepeti, pbxUrun, lblAltToplamim, lblToplamim araclarini ShoppinCard sinifindaki verilere esleyen fonksiyon
        /// </summary>
        public void esle()
        {
            sepetSinif.sepetFormEslestir(ref dgwSepet, ref pbxUrun, ref lblAltToplamim, ref lblKargom, ref lblToplamim);
        }
        /// <summary>
        /// FormSepet Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSepet_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dgwColonDoldur();
        }
        /// <summary>
        /// dgwsepet datagridview tablosunun colonlarina isim veren fonksiyon
        /// </summary>
        protected internal void dgwColonDoldur()
        {
            dgwSepet.DataSource = null;
            dgwSepet.ColumnCount = 6;
            dgwSepet.Columns[0].Name = "ADI";
            dgwSepet.Columns[1].Name = "EKSİLT";
            dgwSepet.Columns[2].Name = "ADET";
            dgwSepet.Columns[3].Name = "ARTTIR";
            dgwSepet.Columns[4].Name = "SİL";
            dgwSepet.Columns[5].Name = "FİYAT";
            pbxUrun.SizeMode = PictureBoxSizeMode.StretchImage;
            if (sayac == 0)
            {
                //sepetSinif.dgwDoldur();
                if (listeSepet.Count > 0)
                {
                    sepetSinif.dgwDoldur();
                }
                else
                    dgwSepet.DataSource = "";
            }
        }
        /// <summary>
        /// urunun ustune mouse geldiginde, mouse imlecinin sag alt kosesinde urunun fotosunu gosteren fonksiyon 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwSepet_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1)
            {
                tmrSepet.Stop();
                pbxUrun.Visible = false;
            }
            else if (e.RowIndex != -1 && e.RowIndex < listeSepet.Count )
            {
                if (listeSepet[e.RowIndex].GetType().ToString() == "OOP2_PROJE.Book")
                {
                    kitapSepet = (Book)listeSepet[e.RowIndex];
                    pbxUrun.ImageLocation = kitapSepet.Cover_page_picture;
                }
                else if (listeSepet[e.RowIndex].GetType().ToString() == "OOP2_PROJE.Magazine")
                {
                    dergiSepet = (Magazine)listeSepet[e.RowIndex];
                    pbxUrun.ImageLocation = dergiSepet.ImageLocation;
                }
                else if (listeSepet[e.RowIndex].GetType().ToString() == "OOP2_PROJE.MusicCD")
                {
                    cdSepet = (MusicCD)listeSepet[e.RowIndex];
                    pbxUrun.ImageLocation = cdSepet.ImageLocation;
                }
                time = 0;
                tmrSepet.Start();
            }
            else
            {
                tmrSepet.Stop();
                pbxUrun.Visible = false;
            }
        }
        /// <summary>
        /// timer ile dgwSepet_CellMouseEnter fonksiyonun da yaptigimiz islemi guncel tutan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tmrSepet_Tick(object sender, EventArgs e)
        {
            time++;
            pbxUrun.Visible = true;
            Point pointMouse = MousePosition;
            pointMouse.X -= this.Location.X;
            pointMouse.Y -= this.Location.Y;
            pbxUrun.Location = pointMouse;
            if (time >= 500)
            {
                pbxUrun.Visible = false;
                tmrSepet.Stop();
            }
            
        }
        /// <summary>
        /// mouse imleci, urunun ustunden ayrildiginda fotograf gosterme islemini sonlandiran fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwSepet_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            tmrSepet.Stop();
            pbxUrun.Visible = false;
        }
        /// <summary>
        /// anasayfa fotografina tiklandiginda FormAnaEkran formuna giden fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pbxAnasayfa_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, pbxAnasayfa.Name, CustomerNesnesi.userName);
            }
            this.Close();
        }
        /// <summary>
        /// sepetten urun silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            sepetSinif.removeProduct(sender, e);
        }
        /// <summary>
        /// butona tiklandiginda alisveri tamamlamak icin odeme ekranina yonlendiren fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAlisverisTamamla_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnAlisverisTamamla.Name, CustomerNesnesi.userName);
            }
            sepetSinif.placeOrder();   

        }
        private void FormSepet_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        /// <summary>
        /// butona tiklandiginda giris yapan musterinin satin aldigi urunleri gosteren fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiparislerim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnSiparislerim.Name, CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerPurchases();
            }
        }
        /// <summary>
        /// butona tiklandiginda giris yapan musterinin bilgilerini gosteren fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProfilim_Click(object sender, EventArgs e)
        {
            if (CustomerNesnesi != null)
            {
                CustomerNesnesi.logCustomer(this, btnSiparislerim.Name, CustomerNesnesi.userName);
                CustomerNesnesi.printCustomerDetails();
            }
        }
    }
}
