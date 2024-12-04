using System;

namespace CSharpProgrammingJourney.MethodsAndFunctions
{
    class DelegatesWithAnonymousFunctions
    {
        delegate string StringOperation(string s);

        public static void Execute()
        {
            StringOperation inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("C# É SHOW!"));
        }
    }
}
