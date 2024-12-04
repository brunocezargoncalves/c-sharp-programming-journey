using System;
using System.Collections;

namespace CSharpProgrammingJourney.Collections
{
    class ExempleStack
    {
        public static void Execute()
        {
            var stack = new Stack();
            stack.Push(3);
            stack.Push("a");
            stack.Push(true);
            stack.Push(3.14f);

            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPop: {stack.Pop()}\n");

            foreach (var item in stack)
            {
                Console.WriteLine($"{item}");
            }

            Console.WriteLine($"\nPeek: {stack.Peek()}\n");
            Console.WriteLine(stack.Count);
        }
    }
}
