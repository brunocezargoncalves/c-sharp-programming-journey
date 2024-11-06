using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    class CommonCalculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }

        public int Subtraction(int x, int y)
        {
            return x - y;
        }

        public int Multiplication(int x, int y)
        {
            return x * y;
        }

        public int Division(int x, int y)
        {
            return x / y;
        }
    }

    class ChainCalculator
    {
        int memory;

        public ChainCalculator Sum(int x)
        {
            memory += x;
            return this;
        }

        public ChainCalculator Subtraction(int x)
        {
            memory -= x;
            return this;
        }

        public ChainCalculator Multiplication(int x)
        {
            memory *= x;
            return this;
        }

        public ChainCalculator Division(int x)
        {
            memory /= x;
            return this;
        }

        public ChainCalculator Clean()
        {
            memory = 0;
            return this;
        }

        public ChainCalculator Print()
        {
            Console.WriteLine(memory);
            return this;
        }

        public int Result()
        {
            return memory;
        }
    }

    class MethodsWithReturn
    {
        public static void Execute()
        {
            var commonCalculator = new CommonCalculator();
            var result = commonCalculator.Sum(5, 5);

            Console.WriteLine(result);
            Console.WriteLine(commonCalculator.Subtraction(2, 7));
            Console.WriteLine(commonCalculator.Multiplication(4, 4));
            Console.WriteLine(commonCalculator.Division(10, 3));

            var chainCalculator = new ChainCalculator();
            chainCalculator.Sum(10).Multiplication(2).Print().Clean().Print();

            result = chainCalculator.Sum(50).Multiplication(2).Result();
            Console.WriteLine(result);
        }
    }
}
