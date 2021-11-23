using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    class ApplePay : IPayment
    {
        public void MakePayment()
        {
            Console.WriteLine("Apple Pay Payment is active.....");
        }
    }
}
