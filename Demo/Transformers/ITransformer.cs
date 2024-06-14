using System.Windows.Forms.DataVisualization.Charting;

namespace Demo.Transformers;

public interface ITransformer
{
    public void Transform(Series series, double coefficient);
}