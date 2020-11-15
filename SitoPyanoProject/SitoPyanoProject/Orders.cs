using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class Orders
    {
        public List<string> data;
        public Orders()
        {
            data = new List<string>();
        }
        public string this[int index]
        {
            get => data[index];
            set
            {
                data[index] = value; 
            }
        }
        public override string ToString()
        {
            return "Заказы: \n" + String.Join("\n\n", data);
        }
    }
}
