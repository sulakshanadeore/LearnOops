using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    public class Maths
    {

        public void Swap(int fno, int sno)
        {
            int temp;

            temp = fno;
            fno = sno;
            sno = temp;
            Console.WriteLine($"First number= {fno}");
            Console.WriteLine($"Second number={sno}");
        
        }


        
        public int DoCalculation(int no,out double square,out double cube)
        {
            square = no * no;
            cube = square * no;
        return Convert.ToInt32(Math.Sqrt(no));
        }

        public void SwapByRef(ref int fno, ref int sno)
        {
            int temp;
            temp = fno;
            fno = sno;
            sno = temp;
            Console.WriteLine($"First number= {fno}");
            Console.WriteLine($"Second number={sno}");

        }


    }
}
