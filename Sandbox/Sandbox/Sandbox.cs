using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class PolymorphismOverloading
    {       
        public void FunctionOverloading()
        {
            Print("one");
            Print(1);
        }

        private void Print(string value)
        {
            Console.WriteLine("The value is a string: {0}", value);
        }

        private void Print(int value)
        {
            Console.WriteLine("The value is an integer: {0}", value);
        }
    }

    class Generics<T>
    {
        List<T> list = new List<T>();
        T number;

        public void AddElementToList(T value)
        {
            list.Add(value);
        }

        public T GetElementFromIndex(int index)
        {
            return list[index];
        }

        public void SetValue(T value)
        {
            number = value;
        }

        public T GetValue()
        {
            return number;
        }
    }
}
