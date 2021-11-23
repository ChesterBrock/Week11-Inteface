using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    class PaymentManager
    {
        //private readonly CreditCardPayment creditCard;
        //private readonly DebitCardPayment debitCard;
        //private readonly ApplePay applePay;
        private IPayment paymentMode;

        public PaymentManager(IPayment paymentMode)
        {
            this.paymentMode = paymentMode;
            //this.creditCard = creditCard;
            //this.debitCard = debitCard;
            //this.applePay = applePay;

        }
        public void ManagePayment()
        {
            paymentMode.MakePayment();
            //creditCard.MakePayment();
            //debitCard.MakePayment();
            //applePay.MakePayment();
        }
    }
}
