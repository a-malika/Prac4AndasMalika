using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Product() { }
        public Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Product))
                return false;

            Product other = (Product)obj;
            return Name == other.Name;
        }
        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
