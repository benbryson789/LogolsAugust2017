using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training8
{
    public class GenericClass<T> where T : Exception
    {
        public GenericClass()
        {
            //nothing different with constructor
        }

        public void GenericMethod(T param)
        {
            //do something
        }

        public T GenericMethodWithGenericReturn(T param)
        {
            return param;
        }
    }
}
