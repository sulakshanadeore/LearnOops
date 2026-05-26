using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    //Accept Data for employee and display it.
    //Writing Business Logic for Accept Data for employee and display it.
    public class Employee
    {
        int _empid;
        string _ename;


        private int _sal;

        public int Salary
        {
            get { return _sal; }    
            set {
                if(value>0)
                _sal = value;
                else
                    Console.WriteLine("Invalid input");
            }
        }




        private string _city;

        public string StudentCity
        {
            get { return _city; }
            set { _city = value; }
        }



        public string EmployeeName
        {
            get 
            {
            return _ename;  
            }
            set 
            {
                if(value!=null)
                _ename = value;
                else
                    Console.WriteLine("Invalid input");
            }
        }



        //Accept the data,display the data, and validate the data.
        public int EmployeeID//special method is called as "Property"
        {
            get { return _empid; }
            
            set {
                if (value == 0)
                {
                    Console.WriteLine("Invalid input");
                }
                else
                _empid = value; //assigning value to variable using value keyword
            }
        }

    }
}
