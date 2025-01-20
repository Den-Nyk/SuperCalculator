namespace SuperCalculator.Exceptions
{
    public class UnknownCalculationTypeException : Exception
    {
        public UnknownCalculationTypeException(string type)
            : base($"Error: Unknown calculation type '{type}'.")
        {
        }
    }
}
