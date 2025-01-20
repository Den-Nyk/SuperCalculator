using SuperCalculator.Strategies;

namespace SuperCalculator.Tests.Strategies
{
    public class TypeThreeCalculationTests
    {
        [Fact]
        public void Calculate_ValidInput_ReturnsExpectedResult()
        {
            // Arrange
            var strategy = new TypeThreeCalculation();
            var input = 10;

            // Act
            var result = strategy.Calculate(input);

            // Assert
            Assert.Equal("Result is: 13", result);
        }
    }
}
