using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOP2_PROJE
{
    /// <summary>
    /// sqldeki alınmıs urunlerin islemlerini yapar ve sql veri sinifindan inherit eder
    /// </summary>
    class SQL_ShoppingCard:SQL_Veri
    {
        /// <summary>
        /// alinmis urunleri tutar
        /// </summary>
        /// <param name="custID"></param>
        /// <param name="adet"></param>
        /// <param name="urunAdi"></param>
        /// <param name="fiyati"></param>
        public void CardKaydet(int custID, int adet, string urunAdi,string fiyati)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO TableShoppingCard(CardCustomerID,urunAdet,urunAdi,fiyati)" +
                " VALUES('" + custID + "','" + adet + "','" + urunAdi + "','"+fiyati+"')", bagla);

            komut.ExecuteNonQuery();
            bagla.Close();
        }
    }
}
