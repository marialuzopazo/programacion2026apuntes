using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapsimultor
{
    public class RubberDucks : Ducks
    {
        public override void quack()
        {
            Console.WriteLine("Rubber duck quack!");
        }

        public override void swim()
        {
            Console.WriteLine("Rubber duck swimming...");
        }

        public override void display()
        {
            Console.WriteLine("I am a Rubber Ducks!");
        }
    }
}
