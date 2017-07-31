using System;

namespace Sandbox.DesignPatterns.Factory
{
    public class FactoryStart
    {
        public void FactoryExample()
        {
            MammalShopFactory mammalShop = new MammalShopFactory();
            BirdShopFactory birdShop = new BirdShopFactory();
            Animal animal = mammalShop.GetAnimal("Dog");
            Console.WriteLine(animal.GetSpecies());
            animal = birdShop.GetAnimal("Parrot");
            Console.WriteLine(animal.GetSpecies());
            Console.ReadLine();          
        }
    }
}
