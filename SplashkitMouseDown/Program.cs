using SplashKitSDK;

namespace MouseInputs
{
    public class Program
    {
        public static void Main()
        {
            Window window = SplashKit.OpenWindow("Mouse Inputs", 800, 600);

            while (!SplashKit.WindowCloseRequested(window))
            {
                SplashKit.ProcessEvents();

                if (SplashKit.MouseDown(MouseButton.LeftButton))
                {
                    SplashKit.ClearScreen(Color.Red);
                }
                else if (SplashKit.MouseDown(MouseButton.RightButton))
                {
                    SplashKit.ClearScreen(Color.Yellow);
                }
                else
                {
                    SplashKit.ClearScreen(Color.White);
                }

                SplashKit.RefreshScreen(60);
            }

            SplashKit.CloseAllWindows();
        }
    }
}