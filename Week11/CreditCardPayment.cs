using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    class CreditCardPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Credit Card Payment is active.....");
        }
    }
}
