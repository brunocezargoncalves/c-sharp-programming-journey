using System;

namespace CSharpProgrammingJourney.OO
{
    sealed class NoChild
    {
        public double ValueOfFortune()
        {
            return 1_407_033.65;
        }
    }

    //class IamSon : noChild
    //{

    //}

    class Grandmother
    {
        public virtual bool honorFamilyName()
        {
            return true;
        }
    }

    class Father : Grandmother
    {
        public override sealed bool honorFamilyName()
        {
            return true;
        }
    }

    class RebelliousSon : Father
    {
        // não permite sobrescrever
        //public override bool honorFamilyName()
        //{
        //    return false;
        //}
    }

    // Classe selada não permite herança e seus métodos não podem ser sobrescritos
    class Sealed
    {
        public static void Execute()
        {
            NoChild noChild = new NoChild();
            Console.WriteLine(noChild.ValueOfFortune());

            RebelliousSon rebelliousSon = new RebelliousSon();
            Console.WriteLine(rebelliousSon.honorFamilyName());
        }
    }
}
