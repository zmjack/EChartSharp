using EChartsSharp.Types;

namespace EChartsSharp.Interfaces;

public interface ILabel
{
    bool? Show { get; set; }
    object? Distance { get; set; }
    string? Formatter { get; set; }
    Color? Color { get; set; }
    string? FontStyle { get; set; }
    string? FontWeight { get; set; }
    string? FontFamily { get; set; }
    int? FontSize { get; set; }
    int? LineHeight { get; set; }
    Color? BackgroundColor { get; set; }
    Color? BorderColor { get; set; }
    int? BorderWidth { get; set; }
    string? BorderType { get; set; }
    int? BorderDashOffset { get; set; }
    int? BorderRadius { get; set; }
    int? Padding { get; set; }
    Color? ShadowColor { get; set; }
    int? ShadowBlur { get; set; }
    int? ShadowOffsetX { get; set; }
    int? ShadowOffsetY { get; set; }
    int? Width { get; set; }
    int? Height { get; set; }
    Color? TextBorderColor { get; set; }
    int? TextBorderWidth { get; set; }
    string? TextBorderType { get; set; }
    int? TextBorderDashOffset { get; set; }
    Color? TextShadowColor { get; set; }
    int? TextShadowBlur { get; set; }
    int? TextShadowOffsetX { get; set; }
    int? TextShadowOffsetY { get; set; }
    string? Overflow { get; set; }
    string? Ellipsis { get; set; }
    object? Rich { get; set; }
}
