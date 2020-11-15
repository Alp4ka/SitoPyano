﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public class Menu : List<IPunctOfMenu>
    {
        public List<IPunctOfMenu> Cocktails
        {
            get => FindAll(x => x is Cocktail);
        }
        public List<IPunctOfMenu> Dishes
        {
            get => FindAll(x => x is Dish);
        }
    }
}
