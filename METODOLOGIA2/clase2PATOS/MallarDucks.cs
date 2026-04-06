using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapsimultor
{
    public class MallarDucks: Ducks
    {

        public override void quack()
        {
            Console.WriteLine("Mallard duck quack!");

        }
        public override void swim()
        {
            Console.WriteLine("Mallar duck swiming...");
        }
        public override void display()
        {
            Console.WriteLine("I am  a Mallrd Duck!");
        }
    }
}
