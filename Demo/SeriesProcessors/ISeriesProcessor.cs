namespace Demo.SeriesProcessors
{
    public interface ISeriesProcessor
    {
        public List<SeriesPoint> Process(List<double> xPoints);
    }
}