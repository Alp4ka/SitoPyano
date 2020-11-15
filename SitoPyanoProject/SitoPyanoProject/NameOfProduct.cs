using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class NameOfProduct
    {
        public static List<Product> allProducts = new List<Product>();
        public static List<Product> AllProducts => allProducts;
        public NameOfProduct(Product name)
        {
            allProducts.Add(name);
        }
    }
}
