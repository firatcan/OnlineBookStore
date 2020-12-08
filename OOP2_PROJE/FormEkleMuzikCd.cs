using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using HtmlAgilityPack;
using System.Net;

namespace OOP2_PROJE
{
    public partial class FormEkleMuzikCd : Form
    {
        SqlConnection bagla = new SqlConnection("Data Source=.;Initial Catalog=BookStore;Integrated Security=true");
        SQLmusicCd muzikCd = new SQLmusicCd();
        MusicCD musicCDnesnesi = new MusicCD();
        private int dgwsirasi;
        /// <summary>
        /// FormEkleMusicCd constructor
        /// </summary>
        public FormEkleMuzikCd()
        {
            InitializeComponent();
            tabloGoster();
        }
        /// <summary>
        /// admin tarafindan butona tiklandiginda muzik cd ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMuzikCdEkle_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnMuzikCdEkle.Name, adminUserNesnesi.userName);
            MuzikCdFotoAl();
            nesneDoldur();
            adminUserNesnesi.addNewItem(musicCDnesnesi);
            //muzikCd.MusicCdSQLeEkle(musicCDnesnesi);
            tabloGoster();
            MessageBox.Show("eklendi");
        }
        /// <summary>
        /// girilen bilgileri musicCD nesnesine atan fonksiyon
        /// </summary>
        private void nesneDoldur()
        {
            musicCDnesnesi.Name = txtAdi.Text;
            musicCDnesnesi.Price = double.Parse(txtFiyat.Text);
            musicCDnesnesi.Singer = txtSarkici.Text;
            musicCDnesnesi.Type = (MusicCD.typeOfMusicCD)cmbxTur.SelectedIndex;
            musicCDnesnesi.ImageLocation = pbxMuzikCdFotograf.ImageLocation;
        }
        /// <summary>
        /// eklenecek olan music cd'nin fotografini alan fonksiyon
        /// </summary>
        private void MuzikCdFotoAl()
        {
            OpenFileDialog dosyaAc = new OpenFileDialog();

            string yol;
            dosyaAc.Filter = "png Files |*.png| jpg Files|*.jpg";
            if (dosyaAc.ShowDialog() == DialogResult.OK)
            {
                yol = dosyaAc.FileName;
                Bitmap bitti = new Bitmap(yol);
                SaveFileDialog dosyaKaydet = new SaveFileDialog();
                SQLmusicCd cek = new SQLmusicCd();
                cek.muzikCDleriSQLdenCek();
                dosyaKaydet.FileName = @"MuzikCDFotograf\muzikCd" + SQLmusicCd.idSayac + ".png";
                pbxMuzikCdFotograf.ImageLocation = dosyaKaydet.FileName;
                bitti.Save(dosyaKaydet.FileName);
            }
        }
        /// <summary>
        /// silmek istediginiz urunu tablodan sectiginizde silen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMuzikCdGoster_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult res = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Confirmation", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                string silinecekVeri = dgvMuzikCdGoster.SelectedCells[0].Value.ToString();
                bagla.Open();
                SqlCommand komut = new SqlCommand("DELETE FROM TableMusicCD WHERE musicCDID= '" + silinecekVeri + "'", bagla);

                komut.ExecuteNonQuery();
                bagla.Close();
                tabloGoster();
            }
        }
        /// <summary>
        /// dgvMuzikCdGoster datagridview tablosunda verileri gosteren fonksiyon
        /// </summary>
        private void tabloGoster()
        {
            //data grid view tablosunda verileri gostermek icin
            DataTable tablo = new DataTable();
            muzikCd.MusicCdGoster(tablo);
            dgvMuzikCdGoster.DataSource = tablo;
        }
        /// <summary>
        /// txtfiyat textine sadece int veri girilmesini saglayan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// FormEkleMuzikCd Load fonksiyonu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEkleMuzikCd_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dgwDr.ColumnCount = 4;

            dgwDr.Columns[0].Name = "ADI";
            dgwDr.Columns[1].Name = "Fiyat";
            dgwDr.Columns[2].Name = "sarkici";
            dgwDr.Columns[3].Name = "image";
        }
        /// <summary>
        /// butona tiklandiginda DR'den muzik cd ceken fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVeriCekMusicCdDr_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnVeriCekMusicCdDr.Name, adminUserNesnesi.userName);
            WebClient client = new WebClient();
            Uri url = new Uri("https://www.dr.com.tr/Sectiklerimiz/Muzik");
            client.Encoding = Encoding.UTF8;

            var html1 = client.DownloadData(url);
            string html = Encoding.UTF8.GetString(html1);

            HtmlAgilityPack.HtmlDocument dokuman = new HtmlAgilityPack.HtmlDocument();
            dokuman.LoadHtml(html);

            HtmlNodeCollection resim = dokuman.DocumentNode.SelectNodes("//img[@class='lazyload']");

            HtmlNodeCollection ad = dokuman.DocumentNode.SelectNodes("//h3");

            HtmlNodeCollection fiyat = dokuman.DocumentNode.SelectNodes("//span[@class='old-price']");
            HtmlNodeCollection sarkici = dokuman.DocumentNode.SelectNodes("//a[@class='who']");

            string duzeltme,gecicifiyat;

            DataGridViewImageColumn resim11 = new DataGridViewImageColumn();
            dgwDr.Columns.Add(resim11);
            resim11.ImageLayout = DataGridViewImageCellLayout.Stretch;

            for (int i = 0; i < fiyat.Count; i++)
            {
                gecicifiyat = "";
                var adi = ad[i];
                duzeltme = yerineKoy(adi.InnerText);
                dgwDr.Rows.Add(duzeltme.ToString());

                var fiyati = fiyat[i];
                for (int t = 0; t < fiyati.InnerLength - 3; t++)
                {
                    gecicifiyat += fiyati.InnerText[t];
                }
                dgwDr.Rows[i].Cells[1].Value = gecicifiyat;
                
                var kim = sarkici[i];
                duzeltme = yerineKoy(kim.InnerText);
                dgwDr.Rows[i].Cells[2].Value = duzeltme.ToString();
                
                var imge = resim[i].Attributes["data-src"].Value;
                
                dgwDr.Rows[i].Cells[3].Value = imge.ToString();
                
                imageİndirNet dmage = new imageİndirNet(imge);
                dmage.Download();
                try
                { dmage.SaveImage("D:\\cdadi" + i + ".jpg", ImageFormat.Jpeg); }
                catch (Exception )
                {
                    dmage.SaveImage("D:\\cdadi" + i + ".png", ImageFormat.Png);
                }

                try
                {
                    
                    dgwDr.Rows[i].Cells[4].Value = Image.FromFile("D:\\cdadi" + i + ".jpg");
                    dgwDr.Rows[i].Cells[3].Value = "D:\\cdadi" + i + ".jpg";

                }
                catch (Exception)
                {
                    dgwDr.Rows[i].Cells[5].Value = Image.FromFile("D:\\cdadi" + i + ".png");
                }

            }
            
        }
        /// <summary>
        /// hatali harfleri duzelten fonksiyon
        /// </summary>
        /// <param name="gelenText"></param>
        /// <returns></returns>
        public string yerineKoy(string gelenText)
        {
            gelenText = gelenText.Replace("&#214;", " Ö").Replace("&#252;", "ü").Replace("&#246;", "ö").Replace("&#199;", " Ç").Replace("&#231;", "ç").Replace("&#220;", " Ü").Replace("&#39;","'");
            return gelenText;
        }
        /// <summary>
        /// secilen nesneyi bulan fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgwDr_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dgwsirasi = e.RowIndex;
        }
        /// <summary>
        /// butona tiklandiginda DR'den veri ekleyen fonksiyon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCdEkleDR_Click(object sender, EventArgs e)
        {
            AdminUser adminUserNesnesi = FormAnaEkran.AdminUserNesnesi;
            adminUserNesnesi.logAdmin(this, btnCdEkleDR.Name, adminUserNesnesi.userName);
            Bitmap bitti = new Bitmap("D:\\cdadi" + dgwsirasi + ".jpg");
            SaveFileDialog dosyaKaydet = new SaveFileDialog();
            SQLmusicCd cek = new SQLmusicCd();
            cek.muzikCDleriSQLdenCek();
            musicCDnesnesi.Name = dgwDr.Rows[dgwsirasi].Cells[0].Value.ToString();
            dosyaKaydet.FileName = @"MuzikCDFotograf\muzikCd" + (SQLmusicCd.sonid+1) + ".png";
            bitti.Save(dosyaKaydet.FileName);


            
            musicCDnesnesi.Price = double.Parse(dgwDr.Rows[dgwsirasi].Cells[1].Value.ToString());
            musicCDnesnesi.Singer = dgwDr.Rows[dgwsirasi].Cells[2].Value.ToString();
            musicCDnesnesi.Type = (MusicCD.typeOfMusicCD)cmbTur1.SelectedIndex;
            musicCDnesnesi.ImageLocation = @"MuzikCDFotograf\muzikCd" + (SQLmusicCd.sonid+1) + ".png";
            SQLmusicCd.sonid++;
            adminUserNesnesi.addNewItem(musicCDnesnesi);
            //muzikCd.MusicCdSQLeEkle(musicCDnesnesi);
            tabloGoster();
        }
    }
}
