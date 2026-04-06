using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapsimultor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MallarDucks mallard = new MallarDucks();
            Console.WriteLine("================================");
            mallard.display();
            mallard.swim();
            mallard.quack();
            mallard.fly();

            RubberDucks rubber = new RubberDucks();
            Console.WriteLine("================================");
            rubber.display();
            rubber.swim();
            rubber.quack();
            rubber.fly();

            RedheadDucks redhead = new RedheadDucks();
            Console.WriteLine("================================");
            redhead.display(); 
            redhead.swim();
            redhead.quack();
            redhead.fly();

            PatoCriollo patoCriollo = new PatoCriollo();
            Console.WriteLine("================================");
            patoCriollo.display();
            patoCriollo.swim();
            patoCriollo.quack();
            patoCriollo.fly();

            Console.ReadKey();


        }
    }
}
