using Sandbox.DesignPatterns.Factory.Behaviours;

namespace Sandbox.DesignPatterns.Factory
{
    public class MammalShopFactory : AnimalShop
    {
        protected override Animal createAnimal(string species)
        {
            Animal animal = null;
            IBehaviourFactory dogBehaviourFactory = new DogBehaviourFactory();
            IBehaviourFactory catBehaviourFactory = new CatBehaviourFactory();

            switch (species)
            {
                case ("Dog"):
                    animal = new Dog(dogBehaviourFactory); // without 'dogBehaviourFactory' this is Factory Method
                    break;
                case ("Cat"):
                    animal = new Cat(catBehaviourFactory); // with 'catBehaviourFactory' it is Abstract Factory Method???
                    break;
                default:
                    break;
            }

            return animal;
        }
    }
}
