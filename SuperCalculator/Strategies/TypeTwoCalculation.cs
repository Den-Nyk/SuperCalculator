namespace SuperCalculator.Strategies
{
    public class TypeTwoCalculation : ICalculationStrategy
    {
        public string Calculate(int num)
        {
            Console.WriteLine("CalcThree executing!");

            // A lot of very complex computations going here!!! :)
            // many-many-many lines of code!!! :)
            var result = num + 2;

            return $"Result is: {result}";
        }
    }
}
