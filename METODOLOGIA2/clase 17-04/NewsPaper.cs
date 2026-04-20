using System.Runtime.CompilerServices;

namespace Observer
{
    internal class NewsPaper : ISubscriber
    {
        public void Update (string news)
        {
            Console.WriteLine($"Object Id: {RuntimeHelpers.GetHashCode(this)} - {news}");
            Console.WriteLine("---------------------------------------------------");
        }
    }
}