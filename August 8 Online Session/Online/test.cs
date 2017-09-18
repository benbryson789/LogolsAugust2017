using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online
{
    public class Car : auto
    {
        public string Make { get; set; }
        public Model Model { get; set; }
        public int Year { get; set; }
        public testEnum EnumVal { get; set; }

        public Car()
        {
            Console.WriteLine("instantiated");
        }

        public void MethodWithError()
        {
            throw new Exception("test error");
        }
    }

    public enum testEnum
    {
        test1,
        test2,
        test3
    }
}
