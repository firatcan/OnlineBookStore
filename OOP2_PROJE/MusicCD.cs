using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{
    /// <summary>
    /// music-cd nesnesi burada tutulur
    /// </summary>
     class MusicCD : Product
    {
        private string singer;
        public string Singer { get => singer; set => singer = value; }
        internal typeOfMusicCD Type { get => type; set => type = value; }
        public MusicCD()
        {

        }
        public enum typeOfMusicCD
        {
            Romance,
            Hard_Rock,
            Country
        }
        private typeOfMusicCD type;
    }
}
