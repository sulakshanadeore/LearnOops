using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    public class Payment
    {
        public virtual void ProcessPayment()
        {
            Console.WriteLine("Processing payment");
        }
    
    }
    public class CreditCardPayment : Payment
    {

        public override void ProcessPayment() {

            Console.WriteLine("Processing credit card payment.");
        
        }
    }

    public class DebitCardPayment : CreditCardPayment {
        public sealed override void ProcessPayment()
        {

            Console.WriteLine("Processing debit card payment.");

        }


    }
    public class UpiPayment : CreditCardPayment {
        public  override void ProcessPayment()
        {

            Console.WriteLine("Processing debit card payment.");

        }

    }
    
}
