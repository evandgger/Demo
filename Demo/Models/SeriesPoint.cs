namespace Demo.Models
{
    // наш клас що описує просту точку у двовимірному просторі
    public class SeriesPoint
    {
        public SeriesPoint(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }
    }
}