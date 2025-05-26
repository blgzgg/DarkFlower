using ImGuiNET;
using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using System.Numerics;
using Vector2 = System.Numerics.Vector2;

namespace DarkFlower;

public class EditorWindow : GameWindow
{
    private ImGuiController _imguiController;

    public EditorWindow(GameWindowSettings gameWindowSettings, NativeWindowSettings nativeWindowSettings)
        : base(gameWindowSettings, nativeWindowSettings)
    {
    }

    protected override void OnLoad()
    {
        base.OnLoad();
        GL.ClearColor(0.1f, 0.1f, 0.1f, 1.0f);
        _imguiController = new ImGuiController(Size.X, Size.Y);
    }

    protected override void OnRenderFrame(FrameEventArgs args)
    {
        base.OnRenderFrame(args);

        GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

        _imguiController.Update(this, (float)args.Time);

        ImGui.DockSpaceOverViewport();

        ImGui.Begin("Top (XY)");
        ImGui.Text("Top view - placeholder");
        ImGui.End();

        ImGui.Begin("Front (XZ)");
        ImGui.Text("Front view - placeholder");
        ImGui.End();

        ImGui.Begin("Side (YZ)");
        ImGui.Text("Side view - placeholder");
        ImGui.End();

        ImGui.Begin("3D View");
        ImGui.Text("3D perspective view - placeholder");
        ImGui.End();

        _imguiController.Render();
        SwapBuffers();
    }

    protected override void OnResize(ResizeEventArgs e)
    {
        base.OnResize(e);
        GL.Viewport(0, 0, Size.X, Size.Y);
        _imguiController.WindowResized(Size.X, Size.Y);
    }
}