namespace Demo.SeriesProcessors;

public class SquareProcessor : ISeriesProcessor
{
    public List<SeriesPoint> Process(List<double> xPoints)
    {
        var result = new List<SeriesPoint>();

        foreach (var x in xPoints)
        {
            var y = Math.Pow(x, 2);

            result.Add(new SeriesPoint(x, y));
        }

        return result;
    }
}