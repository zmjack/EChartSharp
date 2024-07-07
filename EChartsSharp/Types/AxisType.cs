using NStandard.Text.Json;
using System.Text.Json;

namespace EChartsSharp.Types;

public enum AxisType
{
    Value,
    Category,
    Time,
    Log,
}

[JsonValue<AxisTypeValue>]
public struct AxisTypeValue(AxisType option) : IJsonValue
{
    public AxisType Value { get; set; } = option;

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
