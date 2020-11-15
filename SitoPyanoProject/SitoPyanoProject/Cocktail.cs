using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class Cocktail : IPunctOfMenu
    {
        private double price;
        private string name;
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
                price = value;
            }
        }
        public string Name { get => name; set { name = value; } }
        public List<Product> Components => components;

        public Cocktail(string name, double price, List<string> components, Storage storage)
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
            if (Components.FindIndex(x => x is Beverages && (x as Beverages).BeverageType == "Alco") != -1)
            {
                Type = "Alco";
            }
            else
            {
                Type = "Non-Alco";
            }
        }
        public override string ToString()
        {
            return $"{Name.Replace("_", " ")}, {Type}, {IsAvailable}, {Price}руб.";
        }
    }
}
