using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class Notebooks : TipoCompu
    {
        public Notebooks()
        {
            Console.WriteLine($"{Environment.NewLine}Creando la Notebook");
        }

        public override void Preparacion()
        {
            Console.WriteLine("-Preparando la Notebook");
        }

    }
}
