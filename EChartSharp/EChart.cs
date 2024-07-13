using EChartSharp.Interfaces;
using EChartSharp.Series;

namespace EChartSharp;

public partial class EChart
{
    public Title? Title { get; set; }
    public Tooltip? Tooltip { get; set; }
    public Legend? Legend { get; set; }
    public Axis? XAxis { get; set; }
    public Axis? YAxis { get; set; }
    public ISeries[]? Series { get; set; }
}
