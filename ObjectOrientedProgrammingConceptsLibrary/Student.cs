using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    public class Student
    {
        private int _Rollno=1;//Microsoft Programming Language, "_" for variable name;
        private string _StudentName="Jay";

        private string _City="Indore";

        public void AcceptData(int rno, string name, string address)
        {
            _Rollno = rno;
            _StudentName = name;
            _City = address;
        
        }

        public void PrintData()
        {
            Console.WriteLine(_Rollno);
            Console.WriteLine(_StudentName);
            Console.WriteLine(_City);


        }
    }
}
