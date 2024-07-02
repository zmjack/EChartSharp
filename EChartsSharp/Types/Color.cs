using NStandard.Text.Json;

namespace EChartsSharp.Types;

[JsonValue<Color>]
public struct Color : IJsonValue
{
    public string Value { get; set; }

    public Color(string color)
    {
        Value = color;
    }

    public Color(byte red, byte green, byte blue)
    {
        Value = $"rgb({red},{green},{blue})";
    }

    public Color(byte red, byte green, byte blue, double alpha)
    {
        Value = $"rgba({red},{green},{blue},{Math.Clamp(alpha, 0, 1)})";
    }

    object? IJsonValue.Value => Value;
}
