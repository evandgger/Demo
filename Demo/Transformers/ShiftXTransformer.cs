using System.Windows.Forms.DataVisualization.Charting;

namespace Demo.Transformers;

public class ShiftXTransformer : ITransformer
{
    public void Transform(Series series, double coefficient)
    {
        foreach (var point in series.Points)
        {
            var x = point.XValue + coefficient;

            point.XValue = x;
        }
    }
}