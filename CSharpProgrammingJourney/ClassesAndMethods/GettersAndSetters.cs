using System;

namespace CSharpProgrammingJourney.ClassesAndMethods
{
    public class Motorcycle
    {
        private string Brand;
        private string Model;
        private uint CylinderCapacity;

        public Motorcycle(string brand, string model, uint cylinderCapacity)
        {
            Brand = brand;
            Model = model;
            CylinderCapacity = cylinderCapacity;
        }

        public Motorcycle()
        {

        }

        // Técnica de encapsulamento via métodos para tratar ou criar regras as propriedades da instância do objeto da classe
        // Modelo controverso - Martin Fowler diz ser anemico
        public string GetBrand() { return Brand; }
        public void SetBrand(string brand) { Brand = brand; }
        public string GetModel() { return Model; }
        public void SetModel(string model) { Model = model; }
        public uint GetCylinderCapacity() { return CylinderCapacity; }                
        public void SetCylinderCapacity(uint cylinderCapacity) { CylinderCapacity = cylinderCapacity; }
    }

    class GettersAndSetters
    {
        public static void Execute()
        {
            Motorcycle motorcycle1 = new Motorcycle();
            motorcycle1.SetBrand("Marca 1");
            motorcycle1.SetModel("Modelo 1");
            motorcycle1.SetCylinderCapacity(125);
            Console.WriteLine("Moto 1: {0} {1} {2}", motorcycle1.GetBrand(), motorcycle1.GetModel(), motorcycle1.GetCylinderCapacity());

            var motorcycle2 = new Motorcycle("Marca 2", "Modelo 2", 300);            
            Console.WriteLine("Moto 2: {0} {1} {2}", motorcycle2.GetBrand(), motorcycle2.GetModel(), motorcycle2.GetCylinderCapacity());
        }
    }
}
