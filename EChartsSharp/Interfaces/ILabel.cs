using NStandard.Drawing;

namespace EChartsSharp.Interfaces;

public interface ILabel
{
    bool? Show { get; set; }
    object? Distance { get; set; }
    string? Formatter { get; set; }
    RgbaColor? Color { get; set; }
    string? FontStyle { get; set; }
    string? FontWeight { get; set; }
    string? FontFamily { get; set; }
    int? FontSize { get; set; }
    int? LineHeight { get; set; }
    RgbaColor? BackgroundColor { get; set; }
    RgbaColor? BorderColor { get; set; }
    int? BorderWidth { get; set; }
    string? BorderType { get; set; }
    int? BorderDashOffset { get; set; }
    int? BorderRadius { get; set; }
    int? Padding { get; set; }
    RgbaColor? ShadowColor { get; set; }
    int? ShadowBlur { get; set; }
    int? ShadowOffsetX { get; set; }
    int? ShadowOffsetY { get; set; }
    int? Width { get; set; }
    int? Height { get; set; }
    RgbaColor? TextBorderColor { get; set; }
    int? TextBorderWidth { get; set; }
    string? TextBorderType { get; set; }
    int? TextBorderDashOffset { get; set; }
    RgbaColor? TextShadowColor { get; set; }
    int? TextShadowBlur { get; set; }
    int? TextShadowOffsetX { get; set; }
    int? TextShadowOffsetY { get; set; }
    string? Overflow { get; set; }
    string? Ellipsis { get; set; }
    object? Rich { get; set; }
}
