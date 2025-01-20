using SuperCalculator.Strategies;

namespace SuperCalculator.Tests.Strategies
{
    public class TypeOneCalculationTests
    {
        [Fact]
        public void Calculate_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            var strategy = new TypeOneCalculation();
            var input = 10;

            // Act
            var result = strategy.Calculate(input);

            // Assert
            Assert.Equal("Result is: 11", result);
        }
    }
}
