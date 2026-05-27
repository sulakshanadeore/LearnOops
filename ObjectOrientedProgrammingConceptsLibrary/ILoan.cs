using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    internal interface IIDCard
    {
        void ApplyAadhar();
        void ApplyPan();
    
    }
    internal interface ILoan:IIDCard
    {
        void ApplyLoan();
    }
    interface IInsurance:IIDCard
    {

        void BuyInsurance(int amt, SavingBankAccount account);
    }

    public class Customer : ILoan, IInsurance
    {
        
        public void ApplyLoan()
        {
            Console.WriteLine("Applied for loan");
        }

        public void BuyInsurance(int amt,SavingBankAccount account)
        {

            account.Withdraw(amt);
            Console.WriteLine("Purchased Insurance");
            
        }
    }
}
