using System.Threading;
using System.Threading.Tasks;

using Microsoft.VisualStudio.DebuggerVisualizers;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using SimpleVisualizer.DebuggeeSide;

namespace SimpleVisualizer.DebuggerSide;

[INotifyPropertyChanged]
public partial class ViewModel
{
    internal IVisualizerObjectProvider ObjectProvider { get; init; }

    internal bool UseAsyncProvider { get; init; }

    [ObservableProperty]
    public string? message;

    [RelayCommand]
    public async Task Loaded(
        CancellationToken cancellationToken)
    {
        CustomObject target;

        if (this.UseAsyncProvider)
        {
            var asyncProvider = (IAsyncVisualizerObjectProvider)this.ObjectProvider;
            var obj = await asyncProvider.GetDeserializableObjectAsync(cancellationToken);
            target = obj.ToObject<CustomObject>();
        }
        else
        {
            target = (CustomObject)this.ObjectProvider.GetObject();
        }

        this.Message = target.Message;
    }
}
