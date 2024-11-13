using System;
using System.Collections;

namespace CSharpProgrammingJourney.Collections
{
    class ExempleArrayList
    {
        public static void Execute()
        {
            var arrayList = new ArrayList
            {
                "Palavra",
                1,
                true
            };

            arrayList.Add(3.14);

            foreach (var item in arrayList)
            {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
        }
    }
}
