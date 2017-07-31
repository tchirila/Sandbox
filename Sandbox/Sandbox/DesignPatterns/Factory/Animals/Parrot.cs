
using Sandbox.DesignPatterns.Factory.Behaviours;
namespace Sandbox.DesignPatterns.Factory.Animals
{
    public class Parrot : Animal
    {
        string species = "Parrot";
        IBehaviourFactory _factory;

        public Parrot()
        {

        }

        public Parrot(IBehaviourFactory factory)
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
