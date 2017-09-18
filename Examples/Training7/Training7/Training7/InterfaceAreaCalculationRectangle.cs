using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training7
{
    public class InterfaceAreaCalculationRectangle : IAreaCalculation
    {
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        public double CalculateArea()
        {
            return Side1 * Side2;
        }
    }
}
