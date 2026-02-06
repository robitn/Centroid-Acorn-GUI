You are scaffolding an Avalonia desktop cross-platform app. App is the frontend of a CNC interface. Target is MacOS and Windows 10/11.

- Grid is 2 rows by 3 columns. Bottom row spans 3 columns.
- Left & right cells are fixed ~400; center cell expands.
- Top row expands; bottom row (footer) fixed at 60.

Goal #1:

- Scaffold an Avalonia desktop app.

Goal #2:

- Top row center cell contains Tool Path Visualizer (TVP).
- TVP is implemented using Ab4d.SharpEngine.
- TVP presents a CNC Mill work 3D volume. Right-Handed-Rule: X-axis left- to right+, Y-axis hither- to yon+, Z-axis up+ to origin(0).
- Presents a visible grid on XY plane. An Origin X Y Z widget (red, green, blue respectively). A ViewCube at top-right corner.
- ViewCube follows workspace orientation and receives mouse-clicks to orient iso views. Cube is shaded with face labels that are uv texture mapped on cube faces. Cube faces background color is White & 80% opacity. A light blue texture indicates clickable areas on each face. User will click center face, edge, or corner to orient workspace view.
- The workspace allows orbiting and zooming the Origin with mouse gestures. The scene responds as if spinning an arcball.
