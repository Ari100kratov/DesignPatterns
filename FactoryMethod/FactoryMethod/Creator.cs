
namespace FactoryMethod
{
    /// <summary>
    /// Создатель
    /// </summary>
    public abstract class Creator
    {
        private Product _product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            this._product = FactoryMethod();
        }
    }
}
