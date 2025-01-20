using SuperCalculator.Exceptions;

namespace SuperCalculator.Tests.Exceptions
{
    public class UnknownCalculationTypeExceptionTests
    {
        [Fact]
        public void Constructor_ValidInput_SetsMessageCorrectly()
        {
            // Arrange
            var type = "invalid";

            // Act
            var exception = new UnknownCalculationTypeException(type);

            // Assert
            Assert.Equal($"Error: Unknown calculation type '{type}'.", exception.Message);
        }
    }
}
