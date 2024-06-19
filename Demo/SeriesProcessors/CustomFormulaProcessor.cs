using Demo.Models;
using NCalc;

namespace Demo.SeriesProcessors;

public class CustomFormulaProcessor : ISeriesProcessor
{
    public List<SeriesPoint> Process(SeriesDetails details)
    {
        var result = new List<SeriesPoint>();

        if (string.IsNullOrWhiteSpace(details.CustomFormula))
            throw new InvalidOperationException("Формула невизначена.");

        var expression = new Expression(details.CustomFormula);

        foreach (var x in details.XPoints)
        {
            expression.Parameters["x"] = x;

            var value = expression.Evaluate();

            var y = Convert.ToDouble(value);

            result.Add(new SeriesPoint(x, y));
        }

        return result;
    }
}