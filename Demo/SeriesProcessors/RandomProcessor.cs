using Demo.Models;

namespace Demo.SeriesProcessors
{
    public class RandomProcessor: ISeriesProcessor
    {
        public List<SeriesPoint> Process(SeriesDetails details)
        {
            var result = new List<SeriesPoint>();

            var random = new Random();

            if (!details.RandomMinimum.HasValue || !details.RandomMaximum.HasValue)
                throw new InvalidOperationException("Границі випадкового числа не визначені");

            var range = details.RandomMaximum.Value - details.RandomMinimum.Value;

            foreach (var x in details.XPoints)
            {
                var randomNumber = random.NextDouble();

                var y = randomNumber * (range) + details.RandomMinimum.Value;

                result.Add(new SeriesPoint(x, y));
            }

            return result;
        }
    }
}
