using System;

using Microsoft.VisualStudio.DebuggerVisualizers;

using SimpleVisualizer.DebuggeeSide;
using SimpleVisualizer.DebuggerSide;

static class Program
{
    [STAThread]
    static void Main()
    {
        var target = new CustomObject("Hello");

        var host = new VisualizerDevelopmentHost(
            target,
            typeof(Visualizer),
            typeof(DataSource),
            false);

        host.ShowVisualizer();
    }
}
