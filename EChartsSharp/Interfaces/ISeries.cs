using EChartsSharp.Series;
using EChartsSharp.Types;
using NStandard.Text.Json;

namespace EChartsSharp.Interfaces;

[JsonImpl<ISeries>]
public interface ISeries
{
    string Type { get; }
    string? Name { get; }
    SeriesDataValue? Data { get; }
    Color? Color { get; }
    bool? Smooth { get; }
    string? Stack { get; }
}
