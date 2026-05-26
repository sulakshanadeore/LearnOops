using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgrammingConceptsLibrary
{
    public class Circle
    {
        public decimal CalculateArea(int radius)
        {
            return Convert.ToDecimal(Math.PI * radius * radius);
        }

        public decimal CalculatePerimeter(int radius=0, int diameter=0)
        {
            if (diameter == 0)
            {
                return Convert.ToDecimal(2 * Math.PI * radius * radius);
            }
            else {
                int r=diameter / 2;
                return Convert.ToDecimal(2 * Math.PI * r * r);

            }
        }
    }
}
