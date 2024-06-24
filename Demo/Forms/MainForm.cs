using Demo.Enums;
using Demo.Helpers;
using Demo.Models;
using OfficeOpenXml;

namespace Demo.Forms
{
    public partial class MainForm : Form
    {
        public double? RandomMinimum { get; set; }

        public double? RandomMaximum { get; set; }

        public string? CustomFormula { get; set; }

        public MainForm()
        {
            InitializeComponent();

            SetUpCheckBoxes();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            var isConfigurationValid = Configure(out var startRange, out var endRange, out var step);

            if (isConfigurationValid)
            {
                ClearSeries();
                ValidateRange(ref startRange, ref endRange);
                ValidateStep(ref step);
                EnsureCheckBoxChecked();

                var xPoints = GetXPoints(startRange, endRange, step);
                var details = GetSeriesDetails(xPoints);
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

        private bool Configure(out double startRange, out double endRange, out double step)
        {
            var startRangeText = StartRangeInput.Text;
            var endRangeText = EndRangeInput.Text;
            var stepRangeText = StepInput.Text;

            var isStartValid = InputHelper.ParseDoubleInput(startRangeText, StartRangeLabel.Text, out startRange);
            var isEndValid = InputHelper.ParseDoubleInput(endRangeText, EndRangeLabel.Text, out endRange);
            var isStepValid = InputHelper.ParseDoubleInput(stepRangeText, StepLabel.Text, out step);

            return isStartValid && isEndValid && isStepValid;
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
                RandomMinimum = RandomMinimum,
                CustomFormula = CustomFormula
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

        private List<double> GetXPoints(double start, double end, double step)
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
                ProcessRandomRangeForm();
            }
            else
            { 
                ResetRandomRangeAppearance();
            }
        }

        public void ProcessRandomRangeForm()
        {
            var randomNumberForm = new RandomNumbersForm();

            var isRangeValid = false;

            randomNumberForm.FormClosed += (o, args) =>
            {
                if (randomNumberForm.RandomMinimum.HasValue && randomNumberForm.RandomMaximum.HasValue)
                {
                    RandomMinimum = randomNumberForm.RandomMinimum;
                    RandomMaximum = randomNumberForm.RandomMaximum;
                    isRangeValid = true;
                }
            };

            randomNumberForm.ShowDialog();

            if (isRangeValid)
            {
                RandomRangeLabel.Text = $"({RandomMinimum};{RandomMaximum})";
                RandomRangeLabel.Visible = true;
            }
            else
            {
                RandomCheckBox.Checked = false;
            }
        }

        public void ResetRandomRangeAppearance()
        {
            RandomMinimum = null;
            RandomMaximum = null;
            RandomRangeLabel.Text = string.Empty;
            RandomRangeLabel.Visible = false;
        }

        private void TransformButton_Click(object sender, EventArgs e)
        {
            var checkedSeries = GetListOfCheckedSeries();

            if (!checkedSeries.Any() || !DoesSeriesExist())
            {
                MessageBox.Show("Створіть хоча б один графік");
                return;
            }

            var coefficientInput = TransformationInput.Text;
            var isCoefficientValid = InputHelper.ParseDoubleInput(coefficientInput, TransformationLabel.Text, out var coefficient);

            if (isCoefficientValid)
            {
                foreach (var seriesName in checkedSeries)
                {
                    var series = DataChart.Series[seriesName];

                    var controls = TransformationGroupBox.Controls;

                    foreach (var control in controls)
                    {
                        if (control is CheckBox checkBox && checkBox.Checked)
                        {
                            var transformer = Configuration.TransformMappings[checkBox.Name];

                            transformer.Transform(series, coefficient);
                        }
                    }
                }

                DataChart.Invalidate();

            }
            else
            {
                MessageBox.Show("Перевірьте коефіцієнт");
            }
        }


        private bool DoesSeriesExist()
        {
            var result = false;

            foreach (var series in DataChart.Series)
            {
                if (series.Points.Any())
                {
                    result = true;

                    break; 
                }
            }

            return result;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var aboutForm = new AboutForm();

            //aboutForm.ShowDialog();

            // open form with info
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new SaveFileDialog())
                {
                    dialog.OverwritePrompt = true;
                    dialog.Title = Constants.DialogTitle;
                    dialog.Filter = Constants.DialogFormat; 

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        var filePath = dialog.FileName;

                        if (File.Exists(filePath))
                        {
                            File.Delete(filePath);
                        }

                        SaveExcelFile(filePath);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void SaveExcelFile(string filePath)
        {
            var fileInfo = new FileInfo(filePath);

            using (var excelPackage = new ExcelPackage(fileInfo))
            {
                var checkedSeries = GetListOfCheckedSeries();

                foreach (var seriesName in checkedSeries)
                {
                    var series = DataChart.Series[seriesName];

                    var worksheet = excelPackage.Workbook.Worksheets.Add(seriesName);

                    var row = Constants.ExcelStartRow;

                    worksheet.Cells[row, Constants.XValueInExcel].Value = Constants.XColumnTitle;
                    worksheet.Cells[row, Constants.YValueInExcel].Value = Constants.YColumnTitle;

                    row++;

                    var seriesPoints = series.Points;

                    foreach (var point in seriesPoints)
                    {
                        worksheet.Cells[row, Constants.XValueInExcel].Value = point.XValue;
                        worksheet.Cells[row, Constants.YValueInExcel].Value = point.YValues.First();

                        row++;
                    }
                }

                excelPackage.SaveAs(fileInfo);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Title = Constants.DialogTitle;
                    dialog.Filter = Constants.DialogFormat;

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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void LoadSeriesFromWorksheet(ExcelWorksheet excelWorksheet)
        {
            var series = DataChart.Series[excelWorksheet.Name];

            var points = new List<SeriesPoint>();

            var maxRows = excelWorksheet.Dimension.Rows;

            for (var row = Constants.ExcelReadStartRow; row <= maxRows; row++)
            {
                if (string.IsNullOrWhiteSpace(excelWorksheet.Cells[row, Constants.XValueInExcel].Value?.ToString()))
                    throw new InvalidOperationException("File contains empty rows");

                var x = Convert.ToDouble(excelWorksheet.Cells[row, Constants.XValueInExcel].Value);
                var y = Convert.ToDouble(excelWorksheet.Cells[row, Constants.YValueInExcel].Value);

                var point = new SeriesPoint(x, y);

                points.Add(point);
            }

            foreach (var point in points)
            {
                series.Points.AddXY(point.X, point.Y);
            }
        }

        private void CustomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomCheckBox.Checked)
            {
                ProcessCustomExpressionForm();
            }
            else
            {
                ResetCustomFormulaAppearance();
            }
        }

        public void ProcessCustomExpressionForm()
        {
            var customExpressionForm = new CustomExpressionForm();
            var isFormulaValid = false;

            customExpressionForm.FormClosed += (o, args) =>
            {
                if (!string.IsNullOrWhiteSpace(customExpressionForm.Formula))
                {
                    CustomFormula = customExpressionForm.Formula;
                    isFormulaValid = true;
                }
                else
                {
                    CustomCheckBox.Checked = false;
                }
            };

            customExpressionForm.ShowDialog();

            if (isFormulaValid)
            {
                CustomFormulaLabel.Text = @$"f(x) = {CustomFormula}";
                CustomFormulaLabel.Visible = true;
            }
        }

        public void ResetCustomFormulaAppearance()
        {
            CustomFormulaLabel.Text = string.Empty;
            CustomFormulaLabel.Visible = false;
            CustomFormula = null;
        }
    }
}
