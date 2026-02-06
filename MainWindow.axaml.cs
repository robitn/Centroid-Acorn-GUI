using Avalonia.Controls;
using Ab4d.SharpEngine;
using Ab4d.SharpEngine.Cameras;
using Ab4d.SharpEngine.Common;
using Ab4d.SharpEngine.SceneNodes;
using Ab4d.SharpEngine.Materials;
using Ab4d.SharpEngine.Core;
using System.Numerics;
using Ab4d.SharpEngine.AvaloniaUI;
using Ab4d.SharpEngine.Lights;
using Ab4d.SharpEngine.Utilities;

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
        // The SharpEngineSceneView automatically creates Scene and SceneView
        var scene = SceneView.Scene;
        var sceneView = SceneView.SceneView;

        // Create camera
        var camera = new TargetPositionCamera()
        {
            TargetPosition = new Vector3(0, 0, 0),
            Distance = 100,
            Heading = 30,
            Attitude = -20,
            Bank = 0
        };

        sceneView.Camera = camera;

        // Add lights
        scene.Lights.Add(new DirectionalLight(new Vector3(-1, -0.3f, 0)));
        scene.SetAmbientLight(intensity: 0.3f);

        // TODO: Enable mouse camera control with PointerCameraController

        // Add grid on XY plane
        var gridLines = CreateGrid(50, 10);
        scene.RootNode.Add(gridLines);

        // Add origin widget
        var originWidget = CreateOriginWidget();
        scene.RootNode.Add(originWidget);

        // TODO: Add ViewCube
    }

    private GroupNode CreateGrid(float size, float step)
    {
        var group = new GroupNode();

        var color = new Color3(0.5f, 0.5f, 0.5f); // gray

        for (float i = -size; i <= size; i += step)
        {
            // X lines
            var line1 = new LineNode(new Vector3(i, -size, 0), new Vector3(i, size, 0), color, 1f, null);
            group.Add(line1);

            // Y lines
            var line2 = new LineNode(new Vector3(-size, i, 0), new Vector3(size, i, 0), color, 1f, null);
            group.Add(line2);
        }

        return group;
    }

    private GroupNode CreateOriginWidget()
    {
        var group = new GroupNode();

        // X axis - red
        var xAxis = new LineNode(new Vector3(0, 0, 0), new Vector3(10, 0, 0), new Color3(1, 0, 0), 2f, null);
        group.Add(xAxis);

        // Y axis - green
        var yAxis = new LineNode(new Vector3(0, 0, 0), new Vector3(0, 10, 0), new Color3(0, 1, 0), 2f, null);
        group.Add(yAxis);

        // Z axis - blue
        var zAxis = new LineNode(new Vector3(0, 0, 0), new Vector3(0, 0, 10), new Color3(0, 0, 1), 2f, null);
        group.Add(zAxis);

        return group;
    }
}