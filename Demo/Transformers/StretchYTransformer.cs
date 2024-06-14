using System.Windows.Forms.DataVisualization.Charting;

namespace Demo.Transformers
{
    public class StretchYTransformer: ITransformer
    {
        public void Transform(Series series, double coefficient)
        {
            foreach (var point in series.Points)
            {
                var yValue = point.YValues.First();

                double y = coefficient < 0
                    ? yValue * Math.Abs(coefficient)
                    : yValue / coefficient;

                point.YValues = new[] { y };
            }
        }
    }
}
