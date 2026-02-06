using Avalonia.Controls;
using HelixToolkit.Avalonia;

namespace CentroidAcornGUI;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        Setup3DScene();
    }

    private void Setup3DScene()
    {
        // Set up camera
        Viewport.Camera = new PerspectiveCamera
        {
            Position = new Point3D(0, 0, 100),
            LookDirection = new Vector3D(0, 0, -100),
            UpDirection = new Vector3D(0, 1, 0),
            FieldOfView = 45
        };

        // Add lights
        Viewport.Children.Add(new DirectionalLight3D { Direction = new Vector3D(-1, -1, -1) });
        Viewport.Children.Add(new AmbientLight3D { Color = System.Windows.Media.Color.FromRgb(50, 50, 50) });

        // Add grid
        var grid = new GridLinesVisual3D
        {
            Width = 100,
            Length = 100,
            MinorDistance = 5,
            MajorDistance = 10,
            Thickness = 0.5
        };
        Viewport.Children.Add(grid);

        // Add coordinate system
        var coordinateSystem = new CoordinateSystemVisual3D { ArrowLengths = 10 };
        Viewport.Children.Add(coordinateSystem);
    }
}