using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheritance
{
    public class Human  //BASE CLASS
    {
        public void eat()
        {
            Console.WriteLine("Human can eat"+"     Base class - Human");
            Console.WriteLine("-------------------------------------------");

        }
    }

    public class Man:Human  //CHILD CLASS1
    {
        public void smile()
        {
            Console.WriteLine("He is smiling"+"     Child class - man");
            Console.WriteLine("                          ");
        }
    }

    public class Woman : Human    //CHILD CLASS2
    {
        public void walk()
        {
            Console.WriteLine("She is walking"+"    child class - woman");
        }
    }

    class InheritHuman
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            man.eat();
            man.smile();

            Woman woman = new Woman();
            woman.walk();
            Console.ReadKey();    
        }
        
    }
}
