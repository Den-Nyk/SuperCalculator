using SuperCalculator.Strategies;

namespace SuperCalculator.Tests.Strategies
{
    public class TypeTwoCalculationTests
    {
        [Fact]
        public void Calculate_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            var strategy = new TypeTwoCalculation();
            var input = 10;

            // Act
            var result = strategy.Calculate(input);

            // Assert
            Assert.Equal("Result is: 12", result);
        }
    }
}
