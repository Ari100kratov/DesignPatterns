using System;

namespace FactoryMethod
{
    /// <summary>
    /// Конкретный создатель
    /// </summary>
    public class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
