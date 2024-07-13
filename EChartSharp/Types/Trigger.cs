using NStandard.Text.Json;
using System.Text.Json;
namespace EChartSharp.Types;

public enum Trigger
{
    Item,
    Axis,
    None,
}

[JsonValue<TriggerValue>]
public struct TriggerValue(Trigger option) : IJsonValue
{
    public Trigger Value { get; } = option;

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
    JsonElement IJsonValue.RawValue { set => throw new NotImplementedException(); }

    public static implicit operator TriggerValue(Trigger value) => new(value);
}
