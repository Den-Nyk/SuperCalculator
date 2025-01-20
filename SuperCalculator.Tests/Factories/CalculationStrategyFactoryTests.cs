using SuperCalculator.Exceptions;
using SuperCalculator.Factories;
using SuperCalculator.Strategies;

namespace SuperCalculator.Tests.Factories
{
    public class CalculationStrategyFactoryTests
    {
        [Theory]
        [InlineData("one", typeof(TypeOneCalculation))]
        [InlineData("two", typeof(TypeTwoCalculation))]
        [InlineData("three", typeof(TypeThreeCalculation))]
        public void GetStrategy_ValidType_ReturnsCorrectStrategy(string type, Type expectedType)
        {
            // Act
            var strategy = CalculationStrategyFactory.GetStrategy(type);

            // Assert
            Assert.IsType(expectedType, strategy);
        }

        [Fact]
        public void GetStrategy_InvalidType_ThrowsUnknownCalculationTypeException()
        {
            // Arrange
            var invalidType = "invalid";

            // Act & Assert
            var exception = Assert.Throws<UnknownCalculationTypeException>(() =>
                CalculationStrategyFactory.GetStrategy(invalidType));

            Assert.Equal($"Error: Unknown calculation type '{invalidType}'.", exception.Message);
        }
    }
}
