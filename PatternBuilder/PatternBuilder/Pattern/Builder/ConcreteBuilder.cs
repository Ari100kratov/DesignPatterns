using System;

namespace PatternBuilder.Pattern.Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Basement _basement;
        private Roof _roof;
        private Storey _storey;

        public void BuildBasement()
        {
            this._basement = new Basement();
            Console.WriteLine("Подвал построен");
        }

        public void BuildRoof()
        {
            this._roof = new Roof();
            Console.WriteLine("Крыша построена");
        }

        public void BuildStorey()
        {
            this._storey = new Storey();
            Console.WriteLine("Этаж построен");
        }

        public House GetResult()
        {
            return new House(this._basement, this._roof, this._storey);
        }
    }
}
