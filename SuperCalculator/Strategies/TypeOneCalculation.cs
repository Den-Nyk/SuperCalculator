namespace SuperCalculator.Strategies
{
    public class TypeOneCalculation : ICalculationStrategy
    {
        public string Calculate(int num)
        {
            Console.WriteLine("CalcOne executing!");

            // A lot of very complex computations going here!!! :)
            // many-many-many lines of code!!! :)
            var result = num + 1;

            return $"Result is: {result}";
        }
    }
}
