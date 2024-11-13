using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    // Exemplo de como implementar os conceitos de get/set somente quando necessário
    public class CarOption
    {
        double discount = 0.1;

        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Propriedade autoimplementada
        public double Price { get; set; }

        // Somente leitura
        public double PriceWithDiscount
        {
            get => Price - (discount * Price); // Lambda

            //get
            //{
            //    return Price - (discount * Price);
            //}
        }

        public CarOption() { }
    }
    
    class Props
    {
        public static void Execute()
        {
            CarOption carOption = new CarOption();
            carOption.Name = "Direção Elétrica";
            carOption.Price = 2354.9;

            Console.WriteLine(carOption.PriceWithDiscount);
            //carOption.PriceWithDiscount = 3000;
        }
    }
}
