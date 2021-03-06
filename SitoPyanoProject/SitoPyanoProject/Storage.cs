﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public class Storage
    {
        public List<Product> AllProducts = new List<Product>();
        public bool DecrementProductAmountByName(string productName)
        {
            int productIndex = AllProducts.FindIndex(x => x.Name == productName);
            if(productIndex < 0)
            {
                return false;
            }
            if(AllProducts[productIndex].Count == 0)
            {
                AllProducts.RemoveAt(productIndex);
                return false;
            }
            AllProducts[productIndex].Count--;
            return true;
        }
        public Product GetProductByName(string name)
        {
            if (CheckIfExists(name))
            {
                return AllProducts.Find(x => x.Name == name);
            }
            return null;
        }
        public bool CheckIfExists(string name)
        {
            return AllProducts.Where(x => x.Name == name).ToList().Count > 0;
        }
    }
}
