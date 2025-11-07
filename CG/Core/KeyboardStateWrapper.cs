using OpenTK.Windowing.GraphicsLibraryFramework;

namespace DinoGame
{
    public static class KeyboardStateWrapper
    {
        private static KeyboardState lastState;
        private static KeyboardState currentState;

        public static void Update(KeyboardState newState)
        {
            lastState = currentState;
            currentState = newState;
        }

        public static bool IsKeyPressed(Keys key)
        {
            return currentState.IsKeyDown(key) && !lastState.IsKeyDown(key);
        }
    }
}