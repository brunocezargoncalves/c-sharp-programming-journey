using System;
using System.Collections.Generic;

namespace CSharpProgrammingJourney.Collections
{
    class ExempleDictionary
    {
        public static void Execute()
        {
            var movies = new Dictionary<int, string>();
            movies.Add(2000, "Gladiador");
            movies.Add(2002, "Homem-Aranha");
            movies.Add(2004, "Os Incríveis");
            movies.Add(2006, "O Grande Truque");

            if (movies.ContainsKey(2004))
            {
                Console.WriteLine($"2004 - {movies[2004]}");
                Console.WriteLine($"2004 - {movies.Values}");
            }

            Console.WriteLine(movies.ContainsValue("Aminésia"));
            Console.WriteLine($"Removeu? {movies.Remove(2004)}");

            foreach (var movie in movies.Keys)
            {
                Console.WriteLine(movie);
            }

            foreach (var movie in movies.Values)
            {
                Console.WriteLine(movie);
            }

            foreach (KeyValuePair<int, string> movie in movies)
            {
                Console.WriteLine($"{movie.Value} é de {movie.Key}");
            }

            foreach (var movie in movies)
            {
                Console.WriteLine($"{movie.Value} é de {movie.Key}");
            }
        }
    }
}
