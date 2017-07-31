
namespace Sandbox.DesignPatterns.Factory
{
    public abstract class AnimalShop
    {
        public Animal GetAnimal(string species)
        {
            Animal animal;
            animal = createAnimal(species); // by replacing 'new' with a method we move towards abstraction (GOOD)
            return animal;
        }

        protected abstract Animal createAnimal(string species);
    }
}
