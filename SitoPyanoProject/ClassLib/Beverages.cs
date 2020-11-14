namespace ClassLib
{
    public class Beverages : Product
    {
        public double Size { get; }
        public string BeverageType { get; }

        public Beverages(string type, double size, string name, int count, double price) : base(price, count, name)
        {
            BeverageType = type;
            Size = size;
        }

        public override string ToString()
        {
            return base.ToString() + $"{BeverageType}; {Size:F1}";
        }
    }
}