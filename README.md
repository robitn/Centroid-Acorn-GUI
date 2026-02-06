# Centroid-Acorn-GUI

A cross-platform GUI application built with Avalonia and .NET 8.0.

## Description

Centroid-Acorn-GUI is a desktop application developed using the Avalonia UI framework, providing a modern and responsive user interface across multiple platforms including Windows, & macOS.

## Prerequisites

- .NET 8.0 SDK or later
- Avalonia UI framework (automatically installed via NuGet)

## Installation

1. Clone the repository:

   ```bash
   git clone <repository-url>
   cd Centroid-Acorn-GUI
   ```

2. Restore dependencies:

   ```bash
   dotnet restore
   ```

3. Build the project:
   ```bash
   dotnet build
   ```

## Usage

To run the application:

```bash
dotnet run
```

The application will launch with the main window interface.

## Development

### Building for Different Platforms

- **Windows**: `dotnet publish -c Release -r win-x64`
- **macOS**: `dotnet publish -c Release -r osx-x64`

### Project Structure

- `App.axaml` / `App.axaml.cs`: Application entry point and configuration
- `MainWindow.axaml` / `MainWindow.axaml.cs`: Main application window
- `Program.cs`: Program startup logic

## Contributing

1. Fork the repository
2. Create a feature branch
3. Make your changes
4. Submit a pull request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
