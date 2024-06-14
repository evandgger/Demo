using Demo.Enums;
using Demo.Forms;
using Demo.Helpers;
using Demo.Models;
using OfficeOpenXml;

namespace Demo
{
    public partial class MainForm : Form
    {
        public double? RandomMinimum { get; set; }

        public double? RandomMaximum { get; set; }

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

            var isStartValid = InputHelper.ParseDoubleInput(startRangeText, StartRangeLabel.Text, out var startRange);
            var isEndValid = InputHelper.ParseDoubleInput(endRangeText, EndRangeLabel.Text, out var endRange);
            var isStepValid = InputHelper.ParseDoubleInput(stepRangeText, StepLabel.Text, out var step);

            var isConfigurationValid = isStartValid && isEndValid && isStepValid;

            if (isConfigurationValid)
            {
                ClearSeries();

                ValidateRange(ref startRange, ref endRange);
                ValidateStep(ref step);

                EnsureCheckBoxChecked();

                var range = GetRange(startRange, endRange, step);

                var details = GetSeriesDetails(range);

                var checkedSeries = GetListOfCheckedSeries();

                foreach (var seriesName in checkedSeries)
                {
                    var series = DataChart.Series[seriesName];

                    var processor = Configuration.SeriesMappings[seriesName];

                    var points = processor.Process(details);

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

        private void EnsureCheckBoxChecked()
        {
            var isChecked = false;

            var controls = VisualizationGroupBox.Controls;

            foreach (var control in controls)
            {
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    isChecked = true;
                    break;
                }
            }

            if (!isChecked)
            {
                LinearCheckBox.Checked = true;
            }
        }

        private SeriesDetails GetSeriesDetails(List<double> xPoints)
        {
            return new SeriesDetails
            {
                XPoints = xPoints,
                RandomMaximum = RandomMaximum,
                RandomMinimum = RandomMinimum
            };
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

        private void RandomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (RandomCheckBox.Checked)
            {
                var randomNumberForm = new RandomNumbersForm();

                randomNumberForm.FormClosed += (o, args) =>
                {
                    RandomMinimum = randomNumberForm.RandomMinimum;
                    RandomMaximum = randomNumberForm.RandomMaximum;
                };

                randomNumberForm.ShowDialog();

                var minimum = RandomMinimum;
                var maximum = RandomMaximum;
            }
        }

        private void TransformButton_Click(object sender, EventArgs e)
        {
            var coefficientInput = TransformationInput.Text;

            var isCoefficientValid = InputHelper.ParseDoubleInput(coefficientInput, TransformationLabel.Text, out var coefficient);

            var checkedSeries = GetListOfCheckedSeries();

            if (isCoefficientValid)
            {
                foreach (var seriesName in checkedSeries)
                {
                    var series = DataChart.Series[seriesName];

                    if (ShiftXCheckBox.Checked)
                    {
                        foreach (var point in series.Points)
                        {
                            var x = point.XValue + coefficient;

                            point.XValue = x;
                        }
                    }

                    if (ShiftYCheckBox.Checked)
                    {
                        foreach (var point in series.Points)
                        {
                            var x = point.XValue;
                            var y = point.YValues.First() + coefficient;

                            point.YValues = new[] { y };
                        }
                    }

                    if (StretchXCheckBox.Checked)
                    {
                        foreach (var point in series.Points)
                        {
                            double x = coefficient < 0
                                ? point.XValue * Math.Abs(coefficient)
                                : point.XValue / coefficient;

                            point.XValue = x;
                        }
                    }

                    if (StretchYCheckBox.Checked)
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

                DataChart.Invalidate();

            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open form with info
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new SaveFileDialog())
            {
                dialog.Title = "Оберіть файл";

                dialog.Filter = "Excel Files|*.xlsx";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = dialog.FileName;

                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                    
                    dialog.OverwritePrompt = true;

                    var fileInfo = new FileInfo(filePath);

                    using (var excelPackage = new ExcelPackage(fileInfo))
                    {

                        var checkedSeries = GetListOfCheckedSeries();

                        foreach (var seriesName in checkedSeries)
                        {
                            var series = DataChart.Series[seriesName];

                            var worksheet = excelPackage.Workbook.Worksheets.Add(seriesName);

                            var row = 1;

                            worksheet.Cells[row, 1].Value = "X";
                            worksheet.Cells[row, 2].Value = "Y";

                            row++;

                            var seriesPoints = series.Points;

                            foreach (var point in seriesPoints)
                            {
                                worksheet.Cells[row, 1].Value = point.XValue;
                                worksheet.Cells[row, 2].Value = point.YValues.First();

                                row++;
                            }
                        }

                        excelPackage.SaveAs(fileInfo);
                    }
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog())
            {
                dialog.Title = "Оберіть файл";

                dialog.Filter = "Excel Files|*.xlsx";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var filePath = dialog.FileName;

                    var fileInfo = new FileInfo(filePath);

                    using (var excelPackage = new ExcelPackage(fileInfo))
                    {
                        ClearSeries();

                        var worksheets = excelPackage.Workbook.Worksheets;

                        foreach (var worksheet in worksheets)
                        {
                            LoadSeriesFromWorksheet(worksheet);
                        }

                        DataChart.Invalidate();
                    }
                }
            }
        }

        private void LoadSeriesFromWorksheet(ExcelWorksheet excelWorksheet)
        {
            var series = DataChart.Series[excelWorksheet.Name];

            var points = new List<SeriesPoint>();
            
            for (var row = 2;; row++)
            {
                if (!string.IsNullOrEmpty(excelWorksheet.Cells[row, 1]?.Value?.ToString()))
                {
                    var x = Convert.ToDouble(excelWorksheet.Cells[row, 1].Value);
                    var y = Convert.ToDouble(excelWorksheet.Cells[row, 2].Value);

                    var point = new SeriesPoint(x, y);

                    points.Add(point);
                }
                else
                {
                    break;
                }
            }

            foreach (var point in points)
            {
                series.Points.AddXY(point.X, point.Y);
            }
        }
    }
}
