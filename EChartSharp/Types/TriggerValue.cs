using EChartSharp.Option;
using NStandard.Text.Json;
using System.Text.Json;
namespace EChartSharp.Types;

[JsonValue<TriggerValue>]
public struct TriggerValue(Trigger value) : IJsonValue
{
    public Trigger Value { get; private set; } = value;

    object? IJsonValue.Value
    {
        get
        {
            return Value switch
            {
                Trigger.Item => "item",
                Trigger.Axis => "axis",
                Trigger.None => "none",
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
                "item" => Trigger.Item,
                "axis" => Trigger.Axis,
                "none" => Trigger.None,
                _ => throw new NotImplementedException(),
            };
        }
    }

    public static implicit operator TriggerValue(Trigger value) => new(value);
}
