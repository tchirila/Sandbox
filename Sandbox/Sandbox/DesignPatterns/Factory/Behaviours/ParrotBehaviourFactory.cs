using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Factory.Behaviours
{
    public class ParrotBehaviourFactory : IBehaviourFactory
    {
        public Eat CreateEat()
        {
            return new EatCrackers();
        }
    }
}
