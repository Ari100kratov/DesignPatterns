using System;

namespace FactoryMethod
{
    /// <summary>
    /// Конкретный продукт
    /// </summary>
    public class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
