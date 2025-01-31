using SplashKitSDK;

namespace MouseLocation
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Mouse Location", 800, 600);

            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();

                SplashKit.ClearScreen(Color.White);

                Point2D mousePosition = SplashKit.MousePosition();
                SplashKit.FillCircle(Color.LightBlue, mousePosition.X, mousePosition.Y, 20);

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}