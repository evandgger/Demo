namespace Demo.SeriesProcessors;

public class LinearProcessor : ISeriesProcessor
{
    public List<SeriesPoint> Process(List<double> xPoints)
    {
        var result = new List<SeriesPoint>();

        foreach (var x in xPoints)
        {
            var y = x;

            result.Add(new SeriesPoint(x, y));
        }

        return result;
    }
}