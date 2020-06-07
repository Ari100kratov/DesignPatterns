using System;

namespace Ptototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Prototype prototype = null;
            Prototype clone = null;

            prototype = new ConcretePrototype1(1, "Name");
            clone = prototype.Clone();
        }
    }
}
