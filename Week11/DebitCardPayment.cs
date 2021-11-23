using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    class DebitCardPayment : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Debit Card Payment is active.....");
        }
    }
}
