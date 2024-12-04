using System;

namespace CSharpProgrammingJourney.MethodsAndFunctions
{
    class Lambda
    {
        public static void Execute()
        {
            // Sem parâmetro de entrada e sem retorno
            Action somethingInTheConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            somethingInTheConsole();

            // Com parâmetro de entrada e sem retorno
            Action<string> somethingInTheConsole2 = (text) =>
            {
                Console.WriteLine("Lambda com C#... {0}", text);
            };

            // Com retorno
            Func<int> playDice = () =>
            {
                Random random = new Random();
                return (int)random.Next(1, 7);
            };

            Console.WriteLine(playDice());

            // Com entrada e retorno
            Func<int, string> hexConvert = number => number.ToString("X");
            Console.WriteLine($"{hexConvert(1234)}");

            // Com multiplas entradas e retorno (implícito porque é uma sentença, logo não precisa da palavra return)
            Func<int, int, int, string> dateFormat = (dia, mes, ano) =>
                String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);

            Console.WriteLine(dateFormat(1, 1, 2019));
        }
    }
}
