using Sandbox.DesignPatterns.Factory.Animals;
using Sandbox.DesignPatterns.Factory.Behaviours;

namespace Sandbox.DesignPatterns.Factory
{
    public class BirdShopFactory : AnimalShop
    {
        protected override Animal createAnimal(string species)
        {
            Animal animal = null;
            IBehaviourFactory parrotBehaviourFactory = new ParrotBehaviourFactory();
            IBehaviourFactory canaryBehaviourFactory = new CanaryBehaviourFactory();

            switch (species)
            {
                case ("Parrot"):
                    animal = new Parrot(parrotBehaviourFactory);
                    break;
                case ("Canary"):
                    animal = new Canary(canaryBehaviourFactory);
                    break;
                default:
                    break;
            }

            return animal;
        }
    }
}
