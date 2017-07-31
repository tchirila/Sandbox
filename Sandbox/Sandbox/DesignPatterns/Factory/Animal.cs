using Sandbox.DesignPatterns.Factory.Behaviours;

namespace Sandbox.DesignPatterns.Factory
{
    public abstract class Animal
    {
        protected Eat eat;
        protected string behaviour;

        public abstract string GetSpecies();
        public abstract void SetBehaviours();
    }
}
