using NStandard.Drawing;

namespace EChartsSharp.Series;

public class ItemStyle
{
    public RgbaColor? Color { get; set; }
    public RgbaColor? BorderColor { get; set; }
    public int? BorderWidth { get; set; }
    public string? BorderType { get; set; }
    public int? BorderDashOffset { get; set; }
    public string? BorderCap { get; set; }
    public string? BorderJoin { get; set; }
    public int? BorderMiterLimit { get; set; }
    public int? ShadowBlur { get; set; }
    public RgbaColor? ShadowColor { get; set; }
    public int? ShadowOffsetX { get; set; }
    public int? ShadowOffsetY { get; set; }
    public double? Opacity { get; set; }
}
