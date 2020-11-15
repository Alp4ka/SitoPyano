using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class Dish : IPunctOfMenu
    {
        private double price;
        private string name;
        public List<Product> components = new List<Product>();
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
                price = value;
            }
        }
        public string Name { get => name; set { name = value; } }
        public List<Product> Components => components;

        public Dish(string name, double price, List<string> components, Storage storage)
        {
            IsAvailable = true;
            foreach (string component in components)
            {
                if (!storage.CheckIfExists(component))
                {
                    IsAvailable = false;
                    break;
                }
                else
                {
                    Components.Add(storage.GetProductByName(component));
                }
            }

            Name = name;
            Price = price;
        }
        public override string ToString()
        {
            return $"{Name.Replace("_", " ")}, {IsAvailable}, {Price} руб.";
        }
    }
}
