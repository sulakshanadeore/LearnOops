using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    public class BankAccount
    {
        private int AccountNo;

        public int BankAccountNo
        {
            get { return AccountNo; }
            set { AccountNo = value; }
        }

        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
        public void Deposit(int amt)
        {
            Balance = Balance + amt;
            Console.WriteLine("Deposited amount");
        }


        public void Deposit(int amt, string chqno)
        {
            Balance += amt;
            Console.WriteLine("Amount= {amt}  deposited by cheque");
        
        }

        public void Deposit(int amt, string mode,string tranid)
        {

            Balance+= amt;  
            Console.WriteLine($"Amount ={amt} deposited by {mode} with transactionid={tranid} ");

        }


        public void Withdraw(int amt)
        {
            Balance = Balance - amt;
            Console.WriteLine("Withdrawn amount");
        }

        public void CalculateInterest()
        {
            Console.WriteLine("Interest calculation in respective classes");
        }
    }

    public class  SavingBankAccount:BankAccount
    {

        public new void CalculateInterest()
        {
            base.Balance += base.Balance * .1;

            
        }
    }

    public class CurrentBankAccout : BankAccount
    {
        public new  void CalculateInterest()
        {
            base.Balance += base.Balance * .02;

        }

    }
}
