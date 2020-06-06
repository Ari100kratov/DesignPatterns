
namespace PatternBuilder
{
    /// <summary>
    /// Дом
    /// </summary>
    public class House
    {
        public Basement Basement { get; }

        public Roof Roof { get; }

        public Storey Storey { get; }

        public House(Basement basement, Roof roof, Storey storey)
        {
            this.Basement = basement;
            this.Roof = roof;
            this.Storey = storey;
        }
    }
}
