using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP2_PROJE
{/// <summary>
/// internetteki resim doyasini indiren ve kaydeden siniftir
/// </summary>
    class imageİndirNet
    {
        private int sayactanila = 0;
        private string imageUrl;
        private Bitmap bitmap;
        /// <summary>
        /// resimin uzantisini alir
        /// </summary>
        /// <param name="imageUrl"></param>
        public imageİndirNet(string imageUrl)
        {
            this.imageUrl = imageUrl;
        }
        /// <summary>
        /// dosyayi indirir
        /// </summary>
        public void Download()
        {
            try
            {
                sayactanila = 0;
                WebClient client = new WebClient();
                Stream stream = client.OpenRead(imageUrl);
                bitmap = new Bitmap(stream);
                stream.Flush();
                stream.Close();
            }
            catch (Exception)
            {
                sayactanila = 1;
                //MessageBox.Show(e.Message);
            }
        }
        /// <summary>
        /// resimi diske kaydeder
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="format"></param>
        public void SaveImage(string filename, ImageFormat format)
        {
            if (sayactanila == 1)
            {
                Bitmap bitti = new Bitmap("D:\\Resimadi9.jpg");
                SaveFileDialog dosyaKaydet = new SaveFileDialog();
                dosyaKaydet.FileName = filename;
                bitti.Save(dosyaKaydet.FileName);
            }
            if (bitmap != null)
            {
                bitmap.Save(filename, format);
            }
        }
        /// <summary>
        /// image geri dondurur
        /// </summary>
        /// <returns></returns>
        public Bitmap GetImage()
        {
            return bitmap;
        }
    }
}
