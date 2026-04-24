using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class SimpleComputadorasFactory
    {
        public  TipoCompu CreateComputadoras(string type)
        {
            if (type.Equals("All in One", StringComparison.OrdinalIgnoreCase))
                return new AllinOne();
            if (type.Equals("Gamers", StringComparison.OrdinalIgnoreCase))
                return new Gamers();
            if (type.Equals("Idepads", StringComparison.OrdinalIgnoreCase))
                return new Idepads();
            if (type.Equals("Notebooks", StringComparison.OrdinalIgnoreCase))
                return new Notebooks();
            if (type.Equals("Oficina", StringComparison.OrdinalIgnoreCase))
                return new Oficina();

            Console.WriteLine($"{Environment.NewLine}Lo siento, pero no tenemos {type}.");
            return null;

        }
    }
}
