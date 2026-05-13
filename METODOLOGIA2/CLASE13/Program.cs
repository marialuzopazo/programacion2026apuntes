using COMMAND;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("donet run -- Servivio Accion");
                Pausa();
                SalirError();
            }
            else
            {
                string selector = args[0].ToUpper();
                string accion = args[1].ToUpper();

                if (!accion.Equals("SI") && !accion.Equals("NO"))
                {
                    Console.WriteLine("La acciondebe ser SI o NO");
                    Pausa();
                    SalirError();
                }
            }

            ControlRemoto controlremoto = new ControlRemoto();

            if (selector.Equals("LUCES"))
            {
                Luces luces = new Luces();
                if (accion.Equals("SI"))
                {
                    controlremoto.CargarComando(new PrenderLuces(luces));
                    controlremoto.ApretarBoton();
                }
                else if (accion.Equals("NO"))
                {
                    controlremoto.CargarComando(new ApagarLuces(luces));
                    controlremoto.ApretarBoton();
                }
                else if (slector.Equals("ALARMA"))
                {
                    Alarma alarma = new Alarma();
                    if (accion.Equals("SI"))
                    {
                        controlremoto.CargarComando(new PonerAlarma(alarma);
                        controlremoto.ApretarBoton();
                    }
                    else if (accion.Equals("NO"))
                    {
                        controlremoto.CargarComando(new SacarAlarma(alarma);
                        controlremoto.ApretarBoton();
                    }
                }
                else
                {
                    Console.WriteLine($"Aun no tenemos acceso a {selector}");
                }

                Pausa();
                SalirOK();
            }
        }
    }
    private static void SalirOK()
    {
        Environment.Exit(0);
    }

    private static void SalirError()
    {
        Environment.Exit(1);
    }
}
