using System;
namespace SitoPyanoProject
{
    public class Product
    {
        private double price;
        private int count;
        public double Price { 
            get => price;
            set
            {
                if(value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException($"Неверное значение для цены продукта: {value}");
                }
            }
        }
        public string Name { get; set; }
        public int Count {
            get => count;
            set
            {
                if (value >= 0)
                {
                    count = value;
                }
                else
                {
                    throw new ArgumentException($"Неверное значение для количества продукта: {value}");
                }
            }
        }
        public Product(double price, int count, string name)
        {
            Price = price;
            Count = count;
            Name = name;
        }
        public override string ToString()
        {
            return $"Название : {Name}\n" +
                $"Цена: {Price} руб.шт.\n" +
                $"Количество: {Count} шт.\n";
        }
    }
}