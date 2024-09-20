using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal interface IPayment
    {
        public void ProcessPayment(double amount);
    }
}
