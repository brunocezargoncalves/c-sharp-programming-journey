using System;

namespace CSharpProgrammingJourney.Exceptions
{
    public class NegativeException : Exception
    {
        public NegativeException() { }

        public NegativeException(string message) : base(message) { }

        public NegativeException(string message, Exception inner) : base(message, inner) { }
    }

    public class UnpairedException : Exception
    {
        public UnpairedException(string message) : base(message) { }
    }

    class CustomException
    {
        public static int PositiveAndEven()
        {
            Random random = new Random();
            int value = random.Next(-1, 30);

            if(value < 0)
            {
                throw new NegativeException("Número negativo...");
            }

            if (value % 2 == 1)
            {
                throw new UnpairedException("Valor impar...");
            }

            return value;
        }

        public static void Execute()
        {
            try
            {
                Console.WriteLine(PositiveAndEven());
            }
            catch (NegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (UnpairedException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
