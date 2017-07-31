using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.DesignPatterns.Factory.Behaviours
{
    public class CatBehaviourFactory : IBehaviourFactory
    {
        public Eat CreateEat()
        {
            return new EatMice();
        }
    }
}
