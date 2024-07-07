using NStandard.Text.Json;
using System.Text.Json;

namespace EChartsSharp.Series;

public struct SeriesDataElement
{
    public string? Name { get; set; }
    public double? Value { get; set; }
    public string? GroupId { get; set; }
    public string? ChildGroupId { get; set; }
    public string? Symbol { get; set; }
    public int? SymbolSize { get; set; }
    public int? SymbolRotate { get; set; }
    public bool? SymbolKeepAspect { get; set; }
    public int[]? SymbolOffset { get; set; }
    public SeriesLabel? Label { get; set; }
}

[JsonValue<SeriesDataValue>]
public struct SeriesDataValue : IJsonValue
{
    public enum UnderlyingType
    {
        Array,
        Array2D,
        Elements,
    }

    public UnderlyingType Type { get; }
    public double[] Array { get; }
    public double[,] Array2D { get; }
    public SeriesDataElement[] Elements { get; }

    public SeriesDataValue(double[] value)
    {
        Type = UnderlyingType.Array;
        Array = value;
    }

    public SeriesDataValue(double[,] value)
    {
        Type = UnderlyingType.Array2D;
        Array2D = value;
    }

    public SeriesDataValue(SeriesDataElement[] value)
    {
        Type = UnderlyingType.Elements;
        Elements = value;
    }

    object? IJsonValue.Value
    {
        get
        {
            return Type switch
            {
                UnderlyingType.Array => Array,
                UnderlyingType.Array2D => Array2D,
                UnderlyingType.Elements => Elements,
                _ => throw new NotImplementedException(),
            };
        }
    }
    JsonElement IJsonValue.RawValue
    {
        set
        {
            throw new NotImplementedException();
        }
    }
}
