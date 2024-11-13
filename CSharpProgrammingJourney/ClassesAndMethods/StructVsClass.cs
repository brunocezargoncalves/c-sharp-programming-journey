using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    public struct SPoint
    {
        public int X;
        public int Y;
    }

    public class CPoint
    {
        public int X;
        public int Y;
    }    

    class StructVsClass
    {
        public static void Execute()
        {
            SPoint sPoint = new SPoint { X = 1, Y = 3 };
            SPoint sPointCopy = sPoint; // Atribuição por VALOR - cria uma nova alocação de memória (conceito do paradgma funcional)
            sPoint.X = 2;

            Console.WriteLine("Struct:");
            Console.WriteLine("X de sPoint = {0}", sPoint.X);
            Console.WriteLine("X de sPointCopy = {0}", sPointCopy.X);

            CPoint cPoint = new CPoint { X = 1, Y = 3 };
            CPoint cPointCopy = cPoint; // Atribuição por REFERÊCIA - altera o valor em memória
            cPoint.X = 2;

            Console.WriteLine("\nClass:");
            Console.WriteLine("X de cPoint = {0}", cPoint.X);
            Console.WriteLine("X de cPointCopy = {0}", cPointCopy.X);
        }
    }
}
