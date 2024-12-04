using System;

namespace CSharpProgrammingJourney.OO
{
    public class Bean1
    {
        public double Weight;
    }

    public class Rice1
    {
        public double Weight;
    }

    public class Meat1
    {
        public double Weight;
    }

    public class Peson1
    {
        public double Weight;

        public void Eat(Bean1 bean)
        {
            Weight += bean.Weight;
        }

        public void Eat(Rice1 rice)
        {
            Weight += rice.Weight;
        }

        public void Eat(Meat1 meat)
        {
            Weight += meat.Weight;
        }
    }

    class NoPolymorphism
    {
        public static void Execute()
        {
            Bean1 bean = new Bean1();
            bean.Weight = 0.3;

            Rice1 rice = new Rice1();
            rice.Weight = 0.25;

            Meat1 meat = new Meat1();
            meat.Weight = 0.3;

            Peson1 person = new Peson1();
            person.Weight = 80.2;
            person.Eat(bean);
            person.Eat(rice);
            person.Eat(meat);

            Console.WriteLine($"Agora o peso da pessoa é {person.Weight}Kg!");
        }
    }
}
