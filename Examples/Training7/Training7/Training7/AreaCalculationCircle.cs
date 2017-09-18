using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training7
{
    public sealed class AreaCalculationCircle : AreaCalculation

    {
        public double radius { get; set; }
        public override void WriteArea()
        {
            Console.WriteLine("The area of cirlce is: {0}", CalculateArea());
        }

        protected override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
