using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MusicCollection.TempModels
{
    public class Root
    {
        public List<Product> Products { get; set; }
    }
    public class Product
    {
        public string barcode_number { get; set; }
        public string title { get; set; }
        public string artist { get; set; }
        public string description { get; set; }
        public List<string> images { get; set; }
        public string Product_Name { get; set; }
    }
}
