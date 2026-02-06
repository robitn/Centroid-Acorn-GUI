using Avalonia;
using System;
using Ab4d.SharpEngine.Licensing;

namespace CentroidAcornGUI;

class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        // Set Ab4d.SharpEngine license
        // Get a trial license from https://www.ab4d.com/SharpEngineLicense.aspx
        // SetLicense(licenseOwner: "YourName", licenseType: "TrialLicense", license: "your-license-key");

        BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);
    }

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UsePlatformDetect()
            .LogToTrace();
}