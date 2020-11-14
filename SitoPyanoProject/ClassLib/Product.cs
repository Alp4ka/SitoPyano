namespace ClassLib
{
    public class Product
    {
        public double Price { get; private set; }

        public override string ToString()
        {
            return base.ToString() + Price;
        }

        public Product(double price, int count, string name)
        {
            
        }
    }
}