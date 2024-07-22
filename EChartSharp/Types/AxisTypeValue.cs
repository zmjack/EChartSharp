using EChartSharp.Option;
using NStandard.Text.Json;
using System.Text.Json;

namespace EChartSharp.Types;

[JsonValue<AxisTypeValue>]
public struct AxisTypeValue(AxisType value) : IJsonValue
{
    public AxisType Value { get; set; } = value;

    object? IJsonValue.Value
    {
        get
        {
            return Value switch
            {
                AxisType.Value => "value",
                AxisType.Category => "category",
                AxisType.Time => "time",
                AxisType.Log => "log",
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
                "value" => AxisType.Value,
                "category" => AxisType.Category,
                "time" => AxisType.Time,
                "log" => AxisType.Log,
                _ => throw new NotImplementedException(),
            };
        }
    }

    public static implicit operator AxisTypeValue(AxisType value) => new(value);
}
