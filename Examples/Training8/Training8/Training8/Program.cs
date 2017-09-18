using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training8
{
    public class Program
    {
        public delegate double SquareDelegate(double num);

        static double Square(double input)
        {
            return input * input;
        }

        public static void Main(string[] args)
        {
            //UsingDelegates();
            //UsingAnonymousMethods();
            EventPublisher ep = new EventPublisher();
            EventSubscriber es = new EventSubscriber(ep);
            ep.RaiseEvent();
            Console.ReadLine();
        }

        private static void UsingDelegates()
        {
            SquareDelegate sd = Square;
            DelegateClass dc = new DelegateClass();
            dc.CalculateSquareFromDelegate(sd);
        }

        private static void UsingAnonymousMethods()
        {
            SquareDelegate sd = delegate (double input)
            {
                return input * input;
            };

            DelegateClass dc = new DelegateClass();
            dc.CalculateSquareFromDelegate(sd);
        }

        private static void UsingLambdaExpressions()
        {
            SquareDelegate sd = input => input * input;
            DelegateClass dc = new DelegateClass();
            dc.CalculateSquareFromDelegate(sd);
        }

        private static void UsingFunc()
        {
            DelegateClass dc = new DelegateClass();
            dc.CalculateSquareFromDelegate(input => input * input);
        }

        private static void UsingAction()
        {
            DelegateClass dc = new DelegateClass();
            dc.CalculateSquareFromAction(input => Console.WriteLine(input * input));
        }

        private static void UsingGenerics()
        {
            List<int> ints = new List<int>();
            List<string> strings = new List<string>();
            List<Exception> exceptions = new List<Exception>();
            ints.Add(1);
            //ints.Add("test");
            strings.Add("test");
            //strings.Add(1);
            exceptions.Add(new Exception());
            exceptions.Add(new DivideByZeroException());
            //exceptions.Add(new StringBuilder());
        }
    }
}
