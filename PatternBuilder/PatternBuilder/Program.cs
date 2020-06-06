using PatternBuilder.Pattern;
using PatternBuilder.Pattern.Builder;
using System;

namespace PatternBuilder
{
    class Program
    {
        /// <summary>
        /// Паттерн используется для пошагового построения сложного продукта
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var builder = new ConcreteBuilder();
            var foreman = new Foreman(builder);

            var house = builder.GetResult();
            Console.WriteLine("Дом построен" + house.ToString());
            Console.ReadKey();
        }
    }
}
