namespace Computadoras
{
    public class Program
    {
        static void Main(string[] args)
        {
            ComputadorasStore store = new ComputadorasStore(new SimpleComputadorasFactory());
            TipoCompu AllinOne = store.OrderComputadoras("All in One");
            TipoCompu Gamers = store.OrderComputadoras("Gamer");
            TipoCompu Idepads = store.OrderComputadoras("Idepads");
            TipoCompu Notebooks = store.OrderComputadoras("Notebooks");
            TipoCompu Oficina = store.OrderComputadoras("Oficina");

            Console.ReadKey();

        }
    }
}