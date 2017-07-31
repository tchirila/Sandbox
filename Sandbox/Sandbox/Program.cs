using Sandbox.DesignPatterns.Command;
using Sandbox.DesignPatterns.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandStart command = new CommandStart();
            command.CommandExample();

            //FactoryStart factory = new FactoryStart();
            //factory.FactoryExample();

            //// Timers
            //Time time = new Time();
            //Console.WriteLine(time.GetCurrentTime());
            //time.CompareTime();

            //// Dictionaries
            //Dictionary<string, string> dict = new Dictionary<string, string>() 
            //{
            //    {"Name", "John"},
            //    {"Surname", "Arryn"}
            //};

            //dict["Name"] = dict["Surname"];
            //Console.WriteLine(dict["Name"]);

            //// Polymorphism
            //Rectangle polyOverr = new Rectangle(2, 5);
            //polyOverr.PrintArea();

            //PolymorphismOverloading polymorph = new PolymorphismOverloading();
            //polymorph.FunctionOverloading();

            //// Generics
            //Generics<string> list = new Generics<string>();
            //list.AddElementToList("Hello");
            //list.AddElementToList("There");

            //Generics<int> number = new Generics<int>();
            //number.SetValue(1);
            //Generics<string> name = new Generics<string>();
            //name.SetValue("Bob");          
            //Console.WriteLine(list.GetElementFromIndex(0));            
            //Console.WriteLine(number.GetValue());
            //Console.WriteLine(name.GetValue());
            //Console.ReadLine();

        }
    }
}
