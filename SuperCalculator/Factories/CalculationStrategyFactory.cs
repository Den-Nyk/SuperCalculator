using SuperCalculator.Exceptions;
using SuperCalculator.Strategies;

namespace SuperCalculator.Factories
{
    public static class CalculationStrategyFactory
    {
        public static ICalculationStrategy GetStrategy(string type)
        {
            return type switch
            {
                "one" => new TypeOneCalculation(),
                "two" => new TypeTwoCalculation(),
                "three" => new TypeThreeCalculation(),
                _ => throw new UnknownCalculationTypeException(type)
            };
        }
    }
}
