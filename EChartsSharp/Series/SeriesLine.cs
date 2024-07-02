using EChartsSharp.Interfaces;
using EChartsSharp.Types;

namespace EChartsSharp.Series;

public partial class SeriesLine : ISeries
{
    public string Type => "line";

    public string? Name { get; set; }
    public SeriesDataValue? Data { get; set; }
    public Color? Color { get; set; }
    public bool? Smooth { get; set; }
    public string? Stack { get; set; }

    public SeriesLabel? Label { get; set; }
    public ItemStyle? ItemStyle { get; set; }
    public MarkLine? MarkLine { get; set; }

}
