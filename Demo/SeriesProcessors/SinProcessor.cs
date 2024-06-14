using Demo.Models;

namespace Demo.SeriesProcessors;

public class SinProcessor : ISeriesProcessor
{
    public List<SeriesPoint> Process(SeriesDetails details)
    {
        var result = new List<SeriesPoint>();

        foreach (var x in details.XPoints)
        {
            var y = Math.Sin(x);

            result.Add(new SeriesPoint(x, y));
        }

        return result;
    }
}