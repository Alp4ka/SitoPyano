using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public abstract class PunctOfMenu
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public List<Product> Components { get; set; }
    }
}