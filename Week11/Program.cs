using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreditCardPayment CCP = new CreditCardPayment();
            //DebitCardPayment DCP = new DebitCardPayment();
            //ApplePay ap = new ApplePay();

            //PaymentManager pm = new PaymentManager(CCP, DCP, ap);
            var CreditCard = PaymentModeFactory.create(Mode.ApplePay);
            PaymentManager pm = new PaymentManager(CreditCard);
            pm.ManagePayment();

            Console.ReadLine();
        }
    }
}
