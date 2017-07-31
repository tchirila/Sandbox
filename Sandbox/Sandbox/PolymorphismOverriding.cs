using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    /// <summary>
    /// This is an example of Liskov Substitution too!!!
    /// </summary>

    abstract class Shape
    {
        public abstract void PrintArea();
    }

    class Rectangle : Shape
    {
        int length;
        int width;

        public Rectangle(int l, int w)
        {
            length = l;
            width = w;
        }

        public override void PrintArea()
        {
            Console.WriteLine("The area is: {0}", (length * width));
        }
    }
}
