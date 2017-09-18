using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training7
{
    public class InterfaceAreaCalculationSquare : IAreaCalculation
    {
        public double Side1 { get; set; }

        public double CalculateArea()
        {
            return Side1 * Side1;
        }
    }
}
