using EChartSharp.Option;
using EChartSharp.Series;

namespace EChartSharp;

public class EChart
{
    public Title? Title { get; set; }
    public Tooltip? Tooltip { get; set; }
    public Legend? Legend { get; set; }

    public Axis? XAxis { get; set; }
    public Axis? YAxis { get; set; }
    public ISeries[]? Series { get; set; }

    public EChart Line(Orient orient, DataFrame frame)
    {
        frame.ApplyAxis(this, orient);
        Series =
        [
            new SeriesLine
            {
                Data = new(frame.Data)
            }
        ];
        return this;
    }

    public EChart Bar(Orient orient, DataFrame frame)
    {
        frame.ApplyAxis(this, orient);
        Series =
        [
            new SeriesBar
            {
                Data = new(frame.Data)
            }
        ];
        return this;
    }

    public EChart Pie(DataFrame frame)
    {
        Series =
        [
            new SeriesPie
            {
                Data = new(
                [
                    ..
                    from zip in frame.Categories.Zip(frame.Data)
                    select new DataElement
                    {
                        Name = zip.First.ToString(),
                        Value = zip.Second
                    }
                ])
            }
        ];
        return this;
    }
}
