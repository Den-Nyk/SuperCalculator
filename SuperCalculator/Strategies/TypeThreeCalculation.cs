namespace SuperCalculator.Strategies
{
    public class TypeThreeCalculation : ICalculationStrategy
    {
        public string Calculate(int num)
        {
            Console.WriteLine("CalcTwo executing!");

            // A lot of very complex computations going here!!! :)
            // many-many-many lines of code!!! :)
            var result = num + 3;

            return $"Result is: {result}";
        }
    }
}
