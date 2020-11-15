using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public class Menu : List<PunctOfMenu>
    {
        private List<PunctOfMenu> Cocktails
        {
            get => FindAll(x => x is Cocktail);
        }
        private List<PunctOfMenu> Dishes
        {
            get => FindAll(x => x is Dish);
        }
    }
}
