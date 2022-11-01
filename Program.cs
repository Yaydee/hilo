using Hilo.game;

namespace Hilo.game // Note actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            director.StartGame();
        }
    }
}