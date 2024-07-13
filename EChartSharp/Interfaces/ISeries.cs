using EChartSharp.Series;
using NStandard.Drawing;
using NStandard.Text.Json;
using System.Text.Json.Serialization;

namespace EChartSharp.Interfaces;

[JsonPolymorphic(UnknownDerivedTypeHandling = JsonUnknownDerivedTypeHandling.FallBackToNearestAncestor)]
[JsonDerivedType(typeof(SeriesBar), nameof(SeriesBar))]
[JsonDerivedType(typeof(SeriesLine), nameof(SeriesLine))]
public interface ISeries
{
    string Type { get; }
    string? Name { get; }
    SeriesDataValue? Data { get; }
    RgbaColor? Color { get; }
    bool? Smooth { get; }
    string? Stack { get; }
}
