using System;

namespace Centipede
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Centipede())
                game.Run();
        }
    }
}
