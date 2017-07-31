using Sandbox.DesignPatterns.Factory.Behaviours;

namespace Sandbox.DesignPatterns.Factory
{
    public class Cat : Animal
    {
        string species = "Cat";
        IBehaviourFactory _factory;

        public Cat()
        {

        }

        public Cat(IBehaviourFactory factory)
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
