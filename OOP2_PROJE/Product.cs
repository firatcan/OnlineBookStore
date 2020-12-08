using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_PROJE
{
    /// <summary>
    /// abstract product classidir book,magazine,music-cd buradan inherit eder
    /// </summary>
    public abstract class Product
    {
        private string id;
        private string name;
        private double price;
        private string imageLocation;
        private int adet ;
        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public double Price { get => price; set => price = value; }
        public string ImageLocation { get => imageLocation; set => imageLocation = value; }
        public int Adet { get => adet; set => adet = value; }
        public static void printProperties()//: shows the all properties of the items.
        {
        }
    }
}
