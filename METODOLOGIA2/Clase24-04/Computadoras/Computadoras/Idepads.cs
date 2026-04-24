using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class Idepads : TipoCompu
    {
        public Idepads()
        {
            Console.WriteLine($"{Environment.NewLine}Creando el Idepads");
        }

        public override void Preparacion()
        {
            Console.WriteLine("-Preparando el Idepadas");
        }
    }
}
