using EChartsSharp.Series;
using NStandard.Drawing;
using NStandard.Text.Json;

namespace EChartsSharp.Interfaces;

[JsonImpl<ISeries>]
public interface ISeries
{
    string Type { get; }
    string? Name { get; }
    SeriesDataValue? Data { get; }
    RgbaColor? Color { get; }
    bool? Smooth { get; }
    string? Stack { get; }
}
