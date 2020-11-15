using System;
namespace SitoPyanoProject
{
    public class Beverages : Product
    {
        public double Size { get; }
        public string BeverageType { get; }

        public Beverages(string type, int size, double price, int count, string name) : base(price, count, name)
        {
            BeverageType = type;
            Size = size;
        }

        public override string ToString()
        {
            return $"{BeverageType}; {Size:F1}";
        }
    }
}