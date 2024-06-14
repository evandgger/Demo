using System.Windows.Forms.DataVisualization.Charting;
using Demo.Enums;
using Demo.SeriesProcessors;

namespace Demo
{
    public static class Configuration
    {
        public static Dictionary<ChartSeriesDisplayType, SeriesChartType> TypeMappings =

            new Dictionary<ChartSeriesDisplayType, SeriesChartType>
            {
                { ChartSeriesDisplayType.Point, SeriesChartType.Point },
                { ChartSeriesDisplayType.Column, SeriesChartType.Column },
                { ChartSeriesDisplayType.Spline, SeriesChartType.Spline }
            };


        public static Dictionary<string, ISeriesProcessor> SeriesMappings =

            new Dictionary<string, ISeriesProcessor>
            {
                { Constants.LinearSeries,  new LinearProcessor() },
                { Constants.SquareSeries,  new SquareProcessor() },
                { Constants.SinSeries,  new SinProcessor() },
                { Constants.RandomSeries,  new RandomProcessor() },
            };
    }
}
