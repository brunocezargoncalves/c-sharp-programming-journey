namespace Encapsulation
{
    // Filho reconhecido (está próximois da class Subcelebrity - relação de herança)
    class RecognizedSon : Subcelebrity
    {
        public new void MyAccesses()
        {
            Console.WriteLine("Filho reconhecido...");

            Console.WriteLine(PublicInformation);
            Console.WriteLine(EyeColor);
            Console.WriteLine(PhoneNumber);
            Console.WriteLine(WayOfSpeaking);
            Console.WriteLine(FamilySecret);
            //Console.WriteLine(IUsePhotoshopALot);
        }
    }
}
