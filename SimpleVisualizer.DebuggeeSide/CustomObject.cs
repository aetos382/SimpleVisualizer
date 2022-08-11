using System;

namespace SimpleVisualizer.DebuggeeSide;

[Serializable]
public class CustomObject
{
    public string Message { get; }

    public CustomObject(
        string message)
    {
        this.Message = message;
    }
}
