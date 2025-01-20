using SuperCalculator.Factories;

namespace SuperCalculator.SuperCalculator
{
    public class SuperCalculator
    {
        public string Calculate(string type, int num)
        {
            var strategy = CalculationStrategyFactory.GetStrategy(type);
            return strategy.Calculate(num);
        }
    }
}
