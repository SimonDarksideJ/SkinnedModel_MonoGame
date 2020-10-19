using System;

namespace SkinningSample
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new SkinningSampleGame())
                game.Run();
        }
    }
}
