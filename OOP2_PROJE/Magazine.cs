using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{/// <summary>
/// magazine nesnesini burada tutar
/// </summary>
     class Magazine:Product
    {
        private string issue;
        public string Issue { get => issue; set => issue = value; }
        internal typeOfMagazine Type { get => type; set => type = value; }
        public Magazine()
        {
        }
        public enum typeOfMagazine
        {
            Actual,
            News,
            Sport,
            Computer,
            Technology
        }
        private typeOfMagazine type; 
    }
}
