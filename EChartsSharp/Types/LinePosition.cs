using NStandard.Text.Json;

namespace EChartsSharp.Types;

public enum LinePosition
{
    Start,
    Middle,
    End,
    InsideStartTop,
    InsideStartBottom,
    InsideMiddleTop,
    InsideMiddleBottom,
    InsideEndTop,
    InsideEndBottom,
}

[JsonValue<LinePositionValue>]
public struct LinePositionValue(LinePosition option) : IJsonValue
{

    public LinePosition Value { get; } = option;

    object? IJsonValue.Value
    {
        get
        {
            return Value switch
            {
                LinePosition.Start => "start",
                LinePosition.Middle => "middle",
                LinePosition.End => "end",
                LinePosition.InsideStartTop => "insideStartTop",
                LinePosition.InsideStartBottom => "insideStartBottom",
                LinePosition.InsideMiddleTop => "insideMiddleTop",
                LinePosition.InsideMiddleBottom => "insideMiddleBottom",
                LinePosition.InsideEndTop => "insideEndTop",
                LinePosition.InsideEndBottom => "insideEndBottom",
                _ => throw new NotImplementedException(),
            };
        }
    }

    public static implicit operator LinePositionValue(LinePosition value) => new(value);
}
