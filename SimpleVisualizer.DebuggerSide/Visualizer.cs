using Microsoft.VisualStudio.DebuggerVisualizers;

namespace SimpleVisualizer.DebuggerSide;

public class Visualizer :
    DialogDebuggerVisualizer
{
    protected override void Show(
        IDialogVisualizerService windowService,
        IVisualizerObjectProvider objectProvider)
    {
        var window = new MainWindow
        {
            DataContext = new ViewModel
            {
                UseAsyncProvider = true,
                ObjectProvider = objectProvider
            }
        };

        window.ShowDialog();
    }
}
