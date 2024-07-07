using NStandard.Text.Json;
using System.Text.Json;

namespace EChartsSharp.Types;

public enum Position
{
    Top,
    Left,
    Right,
    Bottom,
    Inside,
    InsideLeft,
    InsideRight,
    InsideTop,
    InsideBottom,
    InsideTopLeft,
    InsideBottomLeft,
    InsideTopRight,
    InsideBottomRight,
}

[JsonValue<PositionValue>]
public struct PositionValue(Position option) : IJsonValue
{
    public Position Value { get; } = option;

    object? IJsonValue.Value
    {
        get
        {
            return Value switch
            {
                Position.Top => "top",
                Position.Left => "left",
                Position.Right => "right",
                Position.Bottom => "bottom",
                Position.Inside => "inside",
                Position.InsideLeft => "insideLeft",
                Position.InsideRight => "insideRight",
                Position.InsideTop => "insideTop",
                Position.InsideBottom => "insideBottom",
                Position.InsideTopLeft => "insideTopLeft",
                Position.InsideBottomLeft => "insideBottomLeft",
                Position.InsideTopRight => "insideTopRight",
                Position.InsideBottomRight => "insideBottomRight",
                _ => throw new NotImplementedException(),
            };
        }
    }
    JsonElement IJsonValue.RawValue { set => throw new NotImplementedException(); }

    public static implicit operator PositionValue(Position value) => new(value);
}
