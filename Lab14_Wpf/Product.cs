using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_Wpf

{
    public enum ProductCategorys
    {
        Appliances,
        Food
    }
    public class Product
    {
        public string ProductName { get; set; }
        public int ProductPrice { get; set; }
        public string ProductImage { get; set; }
        public ProductCategorys ProductCategory { get; set; }

        public override string ToString()
        {
            return ProductName;
        }
    }
}
