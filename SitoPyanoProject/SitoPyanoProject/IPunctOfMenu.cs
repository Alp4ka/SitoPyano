using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    interface IPunctOfMenu
    {
        public static double price;
        public static string name;
        public static string type;
        public static List<Product> components = new List<Product>();
        public double Price 
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Цена не может быть меньше 0");
                }
            }
        }
        public string Name => name;
        public string Type => type;
        public List<Product> Components => components;
    }
}