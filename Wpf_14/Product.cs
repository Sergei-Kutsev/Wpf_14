using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_14
{
    public enum ProductTypes
    {
        Food,
        Medicine
    }

    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string ProductImage { get; set; }
        public ProductTypes ProductType { get; set; }
    }
}
