using System;

namespace Training7
{
    public abstract class AreaCalculation
    {
        public string Name { get; set; }

        public virtual void WriteArea()
        {
            Console.WriteLine("The area is: {0}", CalculateArea());
        }

        protected abstract double CalculateArea();
    }
}
