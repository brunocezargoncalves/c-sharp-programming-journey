using Encapsulation;
using System;
using static CSharpProgrammingJourney.OO.UnrecognizedChild;

namespace CSharpProgrammingJourney.OO
{
    public class UnrecognizedChild : Subcelebrity
    {
        public new void MyAccesses()
        {
            Console.WriteLine("Filho não reconhecido...");

            Console.WriteLine(PublicInformation);
            Console.WriteLine(EyeColor);
            //Console.WriteLine(PhoneNumber);
            Console.WriteLine(WayOfSpeaking);
            //Console.WriteLine(FamilySecret);
            //Console.WriteLine(IUsePhotoshopALot);
        }

        public class DistantFriend
        {
            // Relação de composição
            public readonly Subcelebrity friend = new Subcelebrity();

            public void MyAccesses()
            {
                Console.WriteLine("Filho reconhecido...");

                Console.WriteLine(friend.PublicInformation);
                //Console.WriteLine(friend.EyeColor);
                //Console.WriteLine(friend.PhoneNumber);
                //Console.WriteLine(friend.WayOfSpeaking);
                //Console.WriteLine(friend.FamilySecret);
                //Console.WriteLine(friend.IUsePhotoshopALot);
            }
        }
    }

    class Encapsulation
    {
        public static void Execute()
        {
            Subcelebrity subcelebrity = new Subcelebrity();
            subcelebrity.MyAccesses();

            new RecognizedSon().MyAccesses(); // Filho reconhecido
            new CloseFriend().MyAccesses(); // Amigo próximo
            new UnrecognizedChild().MyAccesses(); // Filho não reconhecido
            new DistantFriend().MyAccesses(); // Amigo distante
        }
    }
}
