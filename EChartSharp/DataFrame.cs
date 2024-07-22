using EChartSharp.Option;

namespace EChartSharp;

public partial class DataFrame
{
    public object[] Categories { get; set; }
    public double[] Data { get; set; }

    public DataFrame(IEnumerable<object> categories, IEnumerable<double> data)
    {
        Categories = categories.ToArray();
        Data = data.ToArray();
    }

    public void ApplyAxis(EChart chart, Orient category)
    {
        if (category == Orient.Horizontal)
        {
            chart.XAxis = new()
            {
                Type = AxisType.Category,
                Data = Categories,
            };
            chart.YAxis = new()
            {
                Type = AxisType.Value,
            };
        }
        else if (category == Orient.Vertical)
        {
            chart.XAxis = new()
            {
                Type = AxisType.Value,
            };
            chart.YAxis = new()
            {
                Type = AxisType.Category,
                Data = Categories,
            };
        }
        else throw new NotImplementedException();
    }
}
