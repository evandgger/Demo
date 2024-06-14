using Demo.Models;

namespace Demo.SeriesProcessors;

public class SquareProcessor : ISeriesProcessor
{
    public List<SeriesPoint> Process(SeriesDetails details)
    {
        var result = new List<SeriesPoint>();

        foreach (var x in details.XPoints)
        {
            var y = Math.Pow(x, 2);

            result.Add(new SeriesPoint(x, y));
        }

        return result;
    }
}