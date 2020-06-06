using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // Назначение - быть основой всех порождающих паттернов

            var creator = new ConcreteCreator();
            var product = creator.FactoryMethod();

            Console.ReadKey();
        }
    }
}
