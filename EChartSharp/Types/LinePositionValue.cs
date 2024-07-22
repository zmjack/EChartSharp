using EChartSharp.Option;
using NStandard.Text.Json;
using System.Text.Json;

namespace EChartSharp.Types;

[JsonValue<LinePositionValue>]
public struct LinePositionValue(LinePosition value) : IJsonValue
{
    public LinePosition Value { get; set; } = value;

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
    JsonElement IJsonValue.RawValue
    {
        set
        {
            var _value = value.Deserialize<string>();
            Value = _value switch
            {
                "start" => LinePosition.Start,
                "middle" => LinePosition.Middle,
                "end" => LinePosition.End,
                "insideStartTop" => LinePosition.InsideStartTop,
                "insideStartBottom" => LinePosition.InsideStartBottom,
                "insideMiddleTop" => LinePosition.InsideMiddleTop,
                "insideMiddleBottom" => LinePosition.InsideMiddleBottom,
                "insideEndTop" => LinePosition.InsideEndTop,
                "insideEndBottom" => LinePosition.InsideEndBottom,
                _ => throw new NotImplementedException(),
            };
        }
    }

    public static implicit operator LinePositionValue(LinePosition value) => new(value);
}
