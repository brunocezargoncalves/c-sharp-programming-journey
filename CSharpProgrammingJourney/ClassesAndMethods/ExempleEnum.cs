using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    // Lista fechada de elementos (elementos pré-definidos)
    public enum Gender { Acao, Aventura, Terror, Animacao, Comedia };

    public class Movie
    {
        public string Title;
        public Gender MovieGender;
    }

    class ExempleEnum
    {
        public static void Execute()
        {
            int id = (int)Gender.Animacao;
            Console.WriteLine(id);

            var familyMovie = new Movie();
            familyMovie.Title = "Sharknardo 17";
            familyMovie.MovieGender = Gender.Comedia;

            Console.WriteLine("{0} é {1}!", familyMovie.Title, familyMovie.MovieGender);
        }
    }
}
