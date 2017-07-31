using Sandbox.DesignPatterns.Factory.Behaviours;

namespace Sandbox.DesignPatterns.Factory.Animals
{
    public class Canary : Animal
    {
        string species = "Canary";
        IBehaviourFactory _factory;

        public Canary()
        {

        }

        public Canary(IBehaviourFactory factory)
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
