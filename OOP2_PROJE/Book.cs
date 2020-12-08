using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP2_PROJE
{
     class Book:Product
    {
        private string ısbnNumber;
        private string author;
        private string publisher;
        private int page;
        private string cover_page_picture;
        private string typeOfBook;
        public string IsbnNumber { get => ısbnNumber; set => ısbnNumber = value; }
        public string Author { get => author; set => author = value; }
        public int Page { get => page; set => page = value; }
        public string Publisher { get => publisher; set => publisher = value; }
        public string Cover_page_picture { get => cover_page_picture; set => cover_page_picture = value; }
        public string TypeOfBook { get => typeOfBook; set => typeOfBook = value; }
        /// <summary>
        /// Book constructor
        /// </summary>
        public Book()
        {

        }
    }
}
