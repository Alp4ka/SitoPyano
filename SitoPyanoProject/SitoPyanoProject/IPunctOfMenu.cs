using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SitoPyanoProject
{
    public interface IPunctOfMenu
    {
        public double Price { get; protected set; }
        public string Name { get; protected set; }
        public List<Product> Components { get; protected set; }
    }
}
