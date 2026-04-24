using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class Oficina: TipoCompu
    
    {
            public Oficina ()
            {
                Console.WriteLine($"{Environment.NewLine}Creando la super profesional pc de oficina");
            }

            public override void Preparacion()
            {
                Console.WriteLine("-Preparandola, va a ser la mas linda del trabajo ");
            }
    }
}
