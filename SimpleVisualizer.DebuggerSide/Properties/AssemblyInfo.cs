using System;
using System.Diagnostics;
using SimpleVisualizer.DebuggeeSide;
using SimpleVisualizer.DebuggerSide;

[assembly: CLSCompliant(false)]

[assembly: DebuggerVisualizer(
    typeof(Visualizer),
    typeof(DataSource),
    Target = typeof(CustomObject))]
