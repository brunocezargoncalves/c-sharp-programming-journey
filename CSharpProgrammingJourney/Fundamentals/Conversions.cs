using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.Fundamentals
{
    class Conversions
    {
        public static void Execute()
        {
            // Implícita
            int number = 10;
            double numberDouble = number;
            Console.WriteLine(numberDouble);

            // Toda conversão que houver perda de informações deve fazer convesão explícita
            // Gera cache
            double grade = 9.7;
            int gradeInt = (int)grade;
            Console.WriteLine("Nota truncada: {0}", gradeInt);

            Console.WriteLine("Digite sua idade: ");
            string age = Console.ReadLine();
            int ageInt = int.Parse(age);
            Console.WriteLine("Idade inserida: {0}", ageInt);

            ageInt = Convert.ToInt32(age);
            Console.WriteLine("Resultado: {0}", ageInt);

            Console.WriteLine("Digite um número");
            string word = Console.ReadLine();
            int numberWord;
            int.TryParse(word, out numberWord);
            Console.WriteLine("Resulta {0}: ", numberWord);
        }
    }
}
