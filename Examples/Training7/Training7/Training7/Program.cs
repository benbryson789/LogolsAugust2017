using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training7
{
    public class Program
    {
        public static void Main(string[] args)
        {
      
            List<IAreaCalculation> areaCalcs = new List<IAreaCalculation>();
            InterfaceAreaCalculationSquare square = new InterfaceAreaCalculationSquare();
            square.Side1 = 1;
            InterfaceAreaCalculationRectangle rectangle = new InterfaceAreaCalculationRectangle();
            rectangle.Side1 = 2;
            rectangle.Side2 = 3;
            InterfaceAreaCalculationCircle circle = new InterfaceAreaCalculationCircle();
            circle.Radius = 4;
            areaCalcs.Add(square);
            areaCalcs.Add(rectangle);
            areaCalcs.Add(circle);
            WriteAreas(areaCalcs);
      
            /*
            int testInput = 3;
            Console.WriteLine("Before method: " + testInput);
            test(ref testInput);
            Console.WriteLine("After method: " + testInput);
            Console.ReadLine();
            */
        }

        private static void test (ref int input)
        {
            input = 6;
            Console.WriteLine("In method: " + input);
        }

        private static void WriteAreas(List<IAreaCalculation> areaCalcs)
        {
            foreach(IAreaCalculation areaCalc in areaCalcs)
            {
                Console.WriteLine("The area is: {0}", areaCalc.CalculateArea());
            }

            Console.ReadLine();
        }
    }
}
