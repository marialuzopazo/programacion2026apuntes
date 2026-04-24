using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computadoras
{
    public class ComputadorasStore
    {
        private readonly SimpleComputadorasFactory factory;

        public ComputadorasStore (SimpleComputadorasFactory factory)
        {
            this.factory = factory;
        }

        public TipoCompu OrderComputadoras(string type)
        {
            TipoCompu tipocompu = factory.CreateComputadoras(type);

            if (tipocompu != null)
            {
               tipocompu.Preparacion();
                tipocompu.Instalacion();
                tipocompu.Ensamblaje();
                tipocompu.Conectar();
            } 
            return tipocompu;
        }
    }
}
