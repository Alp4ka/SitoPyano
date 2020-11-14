using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLib
{
    class Food
    {
        public int mass;
        public int Mass
        {
            get => mass;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Некореектный ввод.");
                }
                mass = value;
            }
        }
        public Food(int mass,double price, int count,string name) : base(price, count, name)
        {
            Mass = mass;
        }
        public override string ToString()
        {
            return base.ToString() + $" Масса содержимог: {Mass}кг.";
        }
    }
}
