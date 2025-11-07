using OpenTK.Windowing.Desktop;

namespace DinoGame
{
    internal static class Program
    {
        static void Main()
        {
            var nativeSettings = new NativeWindowSettings()
            {
                ClientSize = new OpenTK.Mathematics.Vector2i(800, 600),
                Title = "Dino Game - OpenTK 4.x"
            };

            using (var game = new DinoGame(GameWindowSettings.Default, nativeSettings))
                game.Run();
        }
    }
}