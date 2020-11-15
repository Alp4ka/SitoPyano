using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public interface IPunctOfMenu
    {
        public bool IsAvailable { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public List<Product> Components { get; }
    }
}