using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapsimultor
{
    public class PatoCriollo : Ducks
    {
        public override void quack()
        {
            Console.WriteLine("PatoCriollo hace quak!");

        }
        public override void swim()
        {
            Console.WriteLine("PatoCriollo está nadando...");
        }
        public override void display()
        {
            Console.WriteLine("Yo soy un Pato Criollo!");
        }

        public override void fly()
        {
            Console.WriteLine("Soy un Pato y puedo volar! alto!");
        }
    }
}
