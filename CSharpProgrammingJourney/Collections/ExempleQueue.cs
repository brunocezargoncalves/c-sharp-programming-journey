using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharpProgrammingJourney.Collections
{
    // Principio FIFO
    class ExempleQueue
    {
        public static void Execute()
        {
            var queueGeneric = new Queue<string>();
            queueGeneric.Enqueue("Bruno");
            queueGeneric.Enqueue("Amanda");
            queueGeneric.Enqueue("Arthur");
            queueGeneric.Enqueue("Aurora");
            queueGeneric.Enqueue("Ruby");
            queueGeneric.Enqueue("Pandora");

            Console.WriteLine(queueGeneric.Peek());
            Console.WriteLine(queueGeneric.Count);
            Console.WriteLine(queueGeneric.Dequeue());
            Console.WriteLine(queueGeneric.Count);

            var queue = new Queue();
            queue.Enqueue("Bruno");
            queue.Enqueue(36);
            queue.Enqueue('M');
            queue.Enqueue(true);

            Console.WriteLine(queue.Contains("Bruno"));

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
