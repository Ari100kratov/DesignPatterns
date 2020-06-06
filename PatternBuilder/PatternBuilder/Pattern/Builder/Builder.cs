
namespace PatternBuilder.Pattern.Builder
{
    public interface IBuilder
    {
        /// <summary>
        /// Построоить подвал
        /// </summary>
        public void BuildBasement();

        /// <summary>
        /// Построить этаж
        /// </summary>
        public void BuildStorey();

        /// <summary>
        /// Построить крышу
        /// </summary>
        public void BuildRoof();

        /// <summary>
        /// Возвращает результат
        /// </summary>
        /// <returns></returns>
        public House GetResult();
    }
}
