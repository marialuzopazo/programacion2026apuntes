using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class Gamers : TipoCompu
    {
       
            public Gamers()
            {
                Console.WriteLine($"{Environment.NewLine}Creando la super mega archi compu pa ti");
            }
        public override void Instalacion ()
        {
            Console.WriteLine("-instalando todo bonito con luces gamer ");
        }


        public override void Conectar ()
            {
                Console.WriteLine("-conectando a la mega ultra red ");
            }
        
    }
}
