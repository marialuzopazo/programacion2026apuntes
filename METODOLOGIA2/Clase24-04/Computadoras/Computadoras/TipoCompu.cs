using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class TipoCompu
    {
        public virtual void Preparacion()
        {
            Console.WriteLine("-Preparando");
        }
        public virtual void Instalacion()
        {
            Console.WriteLine("-Instalando");
        }
        public virtual void Ensamblaje()
        {
            Console.WriteLine("-Ensamblando");
        }
        public virtual void Conectar()
        {
            Console.WriteLine("-Conectando");
        }
    }
}
