using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public class Menu : List<IPunctOfMenu>
    {
        public List<Cocktail> Cocktails
        {
            get => base.FindAll(x => x is Cocktail);
        }
        public List<Dish> Dishes
        {
            get => base.FindAll(x => x is Dish);
        }
    }
}
