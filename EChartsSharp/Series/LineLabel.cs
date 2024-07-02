using EChartsSharp.Interfaces;
using EChartsSharp.Types;

namespace EChartsSharp.Series;

public class LineLabel : ILabel
{
    public LinePositionValue? Position { get; set; }

    public bool? Show { get; set; }
    public object? Distance { get; set; }
    public string? Formatter { get; set; }
    public Color? Color { get; set; }
    public string? FontStyle { get; set; }
    public string? FontWeight { get; set; }
    public string? FontFamily { get; set; }
    public int? FontSize { get; set; }
    public int? LineHeight { get; set; }
    public Color? BackgroundColor { get; set; }
    public Color? BorderColor { get; set; }
    public int? BorderWidth { get; set; }
    public string? BorderType { get; set; }
    public int? BorderDashOffset { get; set; }
    public int? BorderRadius { get; set; }
    public int? Padding { get; set; }
    public Color? ShadowColor { get; set; }
    public int? ShadowBlur { get; set; }
    public int? ShadowOffsetX { get; set; }
    public int? ShadowOffsetY { get; set; }
    public int? Width { get; set; }
    public int? Height { get; set; }
    public Color? TextBorderColor { get; set; }
    public int? TextBorderWidth { get; set; }
    public string? TextBorderType { get; set; }
    public int? TextBorderDashOffset { get; set; }
    public Color? TextShadowColor { get; set; }
    public int? TextShadowBlur { get; set; }
    public int? TextShadowOffsetX { get; set; }
    public int? TextShadowOffsetY { get; set; }
    public string? Overflow { get; set; }
    public string? Ellipsis { get; set; }
    public object? Rich { get; set; }
}
