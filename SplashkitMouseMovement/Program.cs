using SplashKitSDK;

namespace MouseMovement
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Mouse Movement", 800, 600);
            double hue = 0.8;
            double saturation = 0.8;
            double brightness = 0.8;

            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();

                Vector2D movement = SplashKit.MouseMovement();

                if (SplashKit.MouseDown(MouseButton.LeftButton))
                {
                    hue += movement.X / SplashKit.ScreenWidth();
                }

                if (SplashKit.MouseDown(MouseButton.RightButton))
                {
                    saturation += movement.Y / SplashKit.ScreenHeight();
                }

                SplashKit.ClearScreen(SplashKit.HSBColor(hue, saturation, brightness));

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}