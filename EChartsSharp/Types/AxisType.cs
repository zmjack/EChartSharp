using NStandard.Text.Json;

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
    public AxisType Value { get; } = option;

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

    public static implicit operator AxisTypeValue(AxisType value) => new(value);
}
