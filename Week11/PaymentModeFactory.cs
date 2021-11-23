using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    public enum Mode
    {
        creditCard,
        debitCard,
        ApplePay
    }
    class PaymentModeFactory
    {
        public static IPayment create(Mode mode)
        {
            if(mode == Mode.creditCard)
            {
                return new CreditCardPayment();
            }
            else if(mode == Mode.debitCard)
            {
                return new DebitCardPayment();
            }
            else
            {
                return new ApplePay();
            }

        }
    }
}
