using EChartSharp.Option;
using NStandard.Text.Json;
using System.Text.Json;

namespace EChartSharp.Types;

[JsonValue<PositionValue>]
public struct PositionValue(Position value) : IJsonValue
{
    public Position Value { get; private set; } = value;

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
    JsonElement IJsonValue.RawValue
    {
        set
        {
            var _value = value.Deserialize<string>();
            Value = _value switch
            {
                "top" => Position.Top,
                "left" => Position.Left,
                "right" => Position.Right,
                "bottom" => Position.Bottom,
                "inside" => Position.Inside,
                "insideLeft" => Position.InsideLeft,
                "insideRight" => Position.InsideRight,
                "insideTop" => Position.InsideTop,
                "insideBottom" => Position.InsideBottom,
                "insideTopLeft" => Position.InsideTopLeft,
                "insideBottomLeft" => Position.InsideBottomLeft,
                "insideTopRight" => Position.InsideTopRight,
                "insideBottomRight" => Position.InsideBottomRight,
                _ => throw new NotImplementedException(),
            };
        }
    }

    public static implicit operator PositionValue(Position value) => new(value);
}
