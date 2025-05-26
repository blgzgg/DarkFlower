using OpenTK.Windowing.Desktop;

namespace DarkFlower;

internal static class Program
{
    public static void Main()
    {
        var nativeWindowSettings = new NativeWindowSettings()
        {
            Size = new OpenTK.Mathematics.Vector2i(1280, 720),
            Title = "DarkFlower Map Editor"
        };

        using var window = new EditorWindow(GameWindowSettings.Default, nativeWindowSettings);
        window.Run();
    }
}


// ImGuiController.cs (basic wrapper for ImGui.NET + OpenTK - stub or integrate existing code)
// For now, you can use the ImGui.NET OpenTK sample: https://github.com/mellinoe/ImGui.NET/tree/main/src/ImGui.NET.SampleProgram
