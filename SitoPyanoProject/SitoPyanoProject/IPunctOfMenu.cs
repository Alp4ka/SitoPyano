using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public interface IPunctOfMenu
    {
        private static double price;
        private static string name;
        public static List<Product> components = new List<Product>();
        public bool IsAvailable { get; set; }
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
        public List<Product> Components => components;
    }
}