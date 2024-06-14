using System.Windows.Forms.DataVisualization.Charting;

namespace Demo.Transformers
{
    public class StretchXTransformer: ITransformer
    {
        public void Transform(Series series, double coefficient)
        {
            foreach (var point in series.Points)
            {
                double x = coefficient < 0
                    ? point.XValue * Math.Abs(coefficient)
                    : point.XValue / coefficient;

                point.XValue = x;
            }
        }
    }
}
