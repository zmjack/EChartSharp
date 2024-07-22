using EChartSharp.Option;
using NStandard.Text.Json;
using System.Text.Json;

namespace EChartSharp.Types;

[JsonValue<OrientValue>]
public struct OrientValue(Orient value) : IJsonValue
{
    public Orient Value { get; set; } = value;

    object? IJsonValue.Value
    {
        get
        {
            return Value switch
            {
                Orient.Horizontal => "horizontal",
                Orient.Vertical => "vertical",
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
                "horizontal" => Orient.Horizontal,
                "vertical" => Orient.Vertical,
                _ => throw new NotImplementedException(),
            };
        }
    }

    public static implicit operator OrientValue(Orient value) => new(value);
}
