using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    interface Point
    {
        void Move(double delta);
    }

    // struct é uma estrutura de dados
    struct Coordinate : Point
    {
        public double X;
        public double Y;

        public Coordinate(double x, double y)
        {
            X = x;
            Y = y;
        }

        public void Move(double delta)
        {
            X += delta;
            Y += delta;
        }
    }


    class ExempleStruct
    {
        public static void Execute()
        {
            Coordinate initialCoordinate;
            initialCoordinate.X = 2;
            initialCoordinate.Y = 2;

            Console.WriteLine("Coordenada inicial: ");
            Console.WriteLine("X = {0}", initialCoordinate.X);
            Console.WriteLine("Y = {0}", initialCoordinate.Y);

            var finalCoordinate = new Coordinate(x: 9, y: 1);
            finalCoordinate.Move(10);

            Console.WriteLine("Coordenada final: ");
            Console.WriteLine("X = {0}", finalCoordinate.X);
            Console.WriteLine("Y = {0}", finalCoordinate.Y);
        }
    }
}
