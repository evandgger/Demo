using Demo.Enums;

namespace Demo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            SetUpCheckBoxes();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            var startRangeText = StartRangeInput.Text;
            var endRangeText = EndRangeInput.Text;
            var stepRangeText = StepInput.Text;

            var isStartValid = ParseDoubleInput(startRangeText, StartRangeLabel.Text, out var startRange);
            var isEndValid = ParseDoubleInput(endRangeText, EndRangeLabel.Text, out var endRange);
            var isStepValid = ParseDoubleInput(stepRangeText, StepLabel.Text, out var step);

            var isConfigurationValid = isStartValid && isEndValid && isStepValid;

            if (isConfigurationValid)
            {
                ClearSeries();

                ValidateRange(ref startRange, ref endRange);
                ValidateStep(ref step);

                var range = GetRange(startRange, endRange, step);

                var checkedSeries = GetListOfCheckedSeries();

                foreach (var seriesName in checkedSeries)
                {
                    var series = DataChart.Series[seriesName];

                    var processor = Configuration.SeriesMappings[seriesName];

                    var points = processor.Process(range);

                    foreach (var point in points)
                    {
                        series.Points.AddXY(point.X, point.Y);
                    }
                }
            }
            else
            {
                MessageBox.Show("Перевірьте, будь ласка, дані");
            }
        }

        private void SetUpCheckBoxes()
        {
            LinearCheckBox.Text = Constants.LinearSeries;
            SquareCheckBox.Text = Constants.SquareSeries;
            SinCheckBox.Text = Constants.SinSeries;
        }

        private List<string> GetListOfCheckedSeries()
        {
            var result = new List<string>();

            var groupBoxControls = VisualizationGroupBox.Controls;

            foreach (var control in groupBoxControls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    result.Add(checkbox.Text);
                }
            }

            return result;
        }

        private void ClearSeries()
        {
            var allSeries = DataChart.Series;

            foreach (var series in allSeries)
            {
                series.Points.Clear();
            }
        }


        private List<double> GetRange(double start, double end, double step)
        {
            var result = new List<double>();

            for (var xPoint = start; xPoint <= end; xPoint += step)
            {
                result.Add(xPoint);
            }

            return result;
        }

        private bool ParseDoubleInput(string input, string nameOfField, out double value)
        {
            var isValid = double.TryParse(input, out value);

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{nameOfField} не може бути пустим");
            }

            if (!isValid)
            {
                MessageBox.Show($"{nameOfField} не може містити букви");
            }

            return isValid;
        }

        private void ValidateRange(ref double start, ref double end)
        {
            if (start > end)
            {
                (start, end) = (end, start);

                StartRangeInput.Text = start.ToString();
                EndRangeInput.Text = end.ToString();

                MessageBox.Show(@$"Проміжок ({end};{start}) змінений на ({start};{end})");
            }
        }

        private void ValidateStep(ref double step)
        {
            if (step == 0)
            {
                throw new InvalidDataException("Крок не може бути 0.");
            }

            if (step < 0)
            {
                step = Math.Abs(step);

                StepInput.Text = step.ToString();

                MessageBox.Show(@$"Крок змінено з -{step} на {step}");
            }
        }

        private void ChartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var allSeries = DataChart.Series;
            var selectedType = ChartTypeComboBox.SelectedIndex;

            var type = (ChartSeriesDisplayType)selectedType;
            var relatedChartType = Configuration.TypeMappings[type];

            foreach (var item in allSeries)
            {
                item.ChartType = relatedChartType;
            }
        }

        private void SinCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
