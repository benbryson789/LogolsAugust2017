using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training8
{
    public class DelegateClass
    {
        public void CalculateSquareFromDelegate(Program.SquareDelegate sd)
        {
            Console.WriteLine(sd(4));
        }

        public void CalculateSquareFromFunction(Func<double, double> squareFunction)
        {
            Console.WriteLine(squareFunction(4));
        }

        public void CalculateSquareFromAction(Action<double> squareFunction)
        {
            squareFunction(4);
        }
    }
}
