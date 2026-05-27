using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    internal abstract class Enquiry:ILoan,IInsurance
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }

        public void ApplyLoan()
        {
            // throw new NotImplementedException();
            Console.WriteLine("Applied for loan");
        }

        public void BuyInsurance(int amt, SavingBankAccount account)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Enquired for insurance");
        }
    }
}
