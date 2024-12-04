using System;

namespace CSharpProgrammingJourney.OO
{
    public class Food
    {
        public double Weight;

        public Food(double weight)
        {
            Weight = weight;
        }

        public Food()
        {
        }
    }

    public class Bean2 : Food
    {
    }

    public class Rice2 : Food
    {
    }

    public class Meat2 : Food
    {
    }

    public class Peson2
    {
        public double Weight;
        
        public void Eat(Food food)
        {
            Weight += food.Weight;
        }
    }

    class WithPolymorphism
    {
        public static void Execute()
        {
            Bean2 bean = new Bean2();
            bean.Weight = 0.3;

            Rice2 rice = new Rice2();
            rice.Weight = 0.25;

            Meat2 meat = new Meat2();
            meat.Weight = 0.3;

            Peson2 person = new Peson2();
            person.Weight = 80.2;
            person.Eat(bean);
            person.Eat(rice);
            person.Eat(meat);

            Console.WriteLine($"Agora o peso da pessoa é {person.Weight}Kg!");
        }
    }
}
