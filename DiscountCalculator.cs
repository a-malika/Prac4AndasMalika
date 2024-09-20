using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    public interface IDiscount
    {
        public double CalculateDiscount(double totalAmount);

    }
    public class NoDiscount : IDiscount
    {
        public double CalculateDiscount(double totalAmount)
        {
            return totalAmount;
        }
    }
    public class SilverDiscount : IDiscount
    { 
        public double CalculateDiscount(double totalAmount)
        {
            return totalAmount * (90.0 / 100.0);
        }
    }
}
