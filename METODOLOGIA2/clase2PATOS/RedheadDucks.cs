using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapsimultor
{
    public class RedheadDucks : Ducks
    {
        public override void quack()
        {
            Console.WriteLine("RedHead duck quak!");
        }

        public override void swim()
        {
            Console.WriteLine("ReadHea duck swimmiing");
        }

        public override void display()
        {
            Console.WriteLine("I am a RedHed Duck!");
        }




    }
}
