using System;

namespace CSharpProgrammingJourney.Exceptions
{
    public class Account
    {
        double Balance;

        public Account(double balance)
        {
            Balance = balance;
        }

        public void Withdrawal(double value)
        {
            if (value > Balance)
            {
                throw new ArgumentException("Saldo insuficiente!");
            }

            Balance -= value;
        }
    }
    class FirstException
    {
        public static void Execute()
        {
            var account = new Account(1_234.21);

            try
            {
                account.Withdrawal(1600);
                Console.WriteLine("Saque realizado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finalizado!");
            }
        }
    }
}
