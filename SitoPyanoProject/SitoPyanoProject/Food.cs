using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class Food : Product
    {
        private int mass;
        public int Mass
        {
            get => mass;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Некорректный ввод.");
                }
                mass = value;
            }
        }
        public Food(int mass, double price, int count, string name) : base(price, count, name)
        {
            Mass = mass;
        }
        public override string ToString()
        {
            return base.ToString() + $" Масса содержимог: {Mass}кг.";
        }
    }
}
