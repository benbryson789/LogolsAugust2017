using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training7
{
    public sealed class AreaCalculationSquare : AreaCalculation
    {
        public double Side1 { get; set; }

        protected override double CalculateArea()
        {
            return Side1 * Side1;
        }
    }
}
