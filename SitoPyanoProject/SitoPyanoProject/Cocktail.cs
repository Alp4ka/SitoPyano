using System;
using System.Collections.Generic;
using System.Text;

namespace SitoPyanoProject
{
    class Cocktail
    { 
        public IPunctOfMenu Parametrs { get; set; }
        public Cocktail(List<string> components)
        {
            Parametrs.Name = components[0];
            Parametrs.Price = double.Parse(components[1]);
            Parametrs.Type = components[2];
            for (int i = 0; i < components.Count-3; i++)
            {
                Parametrs.Components = NameOfProduct.allProducts.FindAll(x => x.Name == components[i + 3]);
            }
        }
    }
}
