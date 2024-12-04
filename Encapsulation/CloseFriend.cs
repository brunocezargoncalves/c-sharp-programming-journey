namespace Encapsulation
{
    class CloseFriend
    {
        // Relação de composição
        public readonly Subcelebrity friend = new Subcelebrity();

        public void MyAccesses()
        {
            Console.WriteLine("Filho reconhecido...");

            Console.WriteLine(friend.PublicInformation);
            //Console.WriteLine(friend.EyeColor);
            Console.WriteLine(friend.PhoneNumber);
            Console.WriteLine(friend.WayOfSpeaking);
            //Console.WriteLine(friend.FamilySecret);
            //Console.WriteLine(friend.IUsePhotoshopALot);
        }
    }
}
