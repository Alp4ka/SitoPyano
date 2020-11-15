using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class Dish : IPunctOfMenu
    {
        private static double price;
        private static string name;
        public List<Product> components = new List<Product>();
        public string Type { get; set; }
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
        public string Name { get => name; set { name = value; } }
        public List<Product> Components => components;

        public Dish(List<string> components, string name, double price)
        {
            IsAvailable = true;
            foreach (string component in components)
            {
                if (!Storage.CheckIfExists(component))
                {
                    Components.Add(Storage.GetProductByName(component));
                    IsAvailable = false;
                    break;
                }
            }

            Name = name;
            Price = price;
        }
    }
}
