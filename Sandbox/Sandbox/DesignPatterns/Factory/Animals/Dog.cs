using Sandbox.DesignPatterns.Factory.Behaviours;

namespace Sandbox.DesignPatterns.Factory
{
    public class Dog : Animal
    {
        string species = "Dog";
        IBehaviourFactory _factory;

        public Dog()
        {

        }

        public Dog(IBehaviourFactory factory)
        {
            _factory = factory;
        }

        public override string GetSpecies()
        {
            return species;
        }

        public override void SetBehaviours()
        {
            eat = _factory.CreateEat();
        }
    }
}
