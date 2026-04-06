using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miapsimultor
{
    public abstract class Ducks

    {
        public Ducks() { }
        public abstract void display();
        public abstract void swim();
        public abstract void quack();
        public virtual void fly()
        {
            Console.WriteLine("I am a duck n i can fly! it up!");
        }

    }


    
    
}
