using System;

namespace Encapsulation
{
    // Subcelebridade
    public class Subcelebrity
    {
        // Atributos com diferentes níveis de visibilidade
        // A combinação de modificadores está disponível a partir da versão do C# 7.2

        // Acessado por todos 
        public string PublicInformation = "Tenho um Instagram!";

        // Acessado por herança
        protected string EyeColor = "Verde";

        // Acessado no mesmo projeto (assembly)
        internal ulong PhoneNumber = 5511999999999;

        // Acessado por herança ou no mesmo projeto
        protected internal string WayOfSpeaking = "Com muitas gírias";

        // Acessado na mesma classe ou herança no mesmo projeto
        private protected string FamilySecret = "Nenhum segredo";

        // acesso privado é o padrão
        bool IUsePhotoshopALot = true;

        public void MyAccesses()
        {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(PublicInformation);
            Console.WriteLine(EyeColor);
            Console.WriteLine(PhoneNumber);
            Console.WriteLine(WayOfSpeaking);
            Console.WriteLine(FamilySecret);
            Console.WriteLine(IUsePhotoshopALot);
        }
    }
}
