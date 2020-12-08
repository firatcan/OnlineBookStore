using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{
    /// <summary>
    /// admin veya customer siniflarinin ortak ozelliklerini tasiyan siniftir base siniftir
    /// </summary>
    public abstract class User
    {
        public string id;
        public string name;
        public string address;
        public string email;
        public string userName;
        public string password;
    }
}
