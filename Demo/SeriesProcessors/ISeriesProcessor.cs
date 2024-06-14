using Demo.Models;

namespace Demo.SeriesProcessors
{
    public interface ISeriesProcessor
    {
        public List<SeriesPoint> Process(SeriesDetails details);
    }
}