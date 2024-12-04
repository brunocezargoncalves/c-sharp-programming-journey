using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.OO
{
    public class Car
    {
        protected readonly int MaximumSpeed;
        int CurrentSpeed;

        public Car(int maximumSpeed)
        {
            MaximumSpeed = maximumSpeed;
        }

        // O protected prove a capacidade do método ser transmitido por herança
        protected int ChangeSpeed(int delta)
        {
            int newSpeed = CurrentSpeed + delta;

            if (newSpeed < 0)
            {
                CurrentSpeed = 0;
            }
            else if (newSpeed > MaximumSpeed)
            {
                CurrentSpeed += MaximumSpeed;
            }
            else
            {
                CurrentSpeed = newSpeed;
            }

            return CurrentSpeed;
        }

        public virtual int Accelerate()
        {
            return ChangeSpeed(5);
        }

        public int Brake()
        {
            return ChangeSpeed(-5);
        }
    }

    public class Uno : Car
    {
        // Inicialmente dá erro, pois a classe base não tem definido um construtor padrão
        // Aí é necessário indicar explicitamente o construtor
        public Uno() : base(200)
        {
        }
    }

    public class Ferrari : Car
    {
        public Ferrari() : base(350)
        {
        }

        // Fica disponível para instância
        public override int Accelerate()
        {
            return ChangeSpeed(15);
        }

        // Estratégia para não utilizar o modificador "virtual" e ocultar o método da classe pai
        // Aqui se o objeto for do tipo pai ele não vai ser utilizado
        public new int Brake()
        {
            return ChangeSpeed(-15);
        }
    }

    class Inheritance
    {
        public static void Execute()
        {
            Console.WriteLine("Uno...");
            Uno car1 = new Uno();
            Console.WriteLine(car1.Accelerate());
            Console.WriteLine(car1.Accelerate());
            Console.WriteLine(car1.Brake());
            Console.WriteLine(car1.Brake());

            Console.WriteLine("\nFerrari...");
            Ferrari car2 = new Ferrari();
            Console.WriteLine(car2.Accelerate());
            Console.WriteLine(car2.Accelerate());
            Console.WriteLine(car2.Brake());
            Console.WriteLine(car2.Brake());

            Console.WriteLine("\nFerrari com tipo carro...");
            Car car3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(car3.Accelerate());
            Console.WriteLine(car3.Accelerate());
            Console.WriteLine(car3.Brake());
            Console.WriteLine(car3.Brake());
            Console.WriteLine(car3.Brake());
        }                        
    }
}
