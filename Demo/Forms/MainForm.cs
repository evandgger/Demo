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

        public MainForm()
        {
            InitializeComponent();

            // проставляємо ім'я чекбоксів, щоб вони співпадали з іменем графіків

            SetUpCheckBoxes();
        }

        private void BuildButton_Click(object sender, EventArgs e)
        {
            #region Загальна інформація

            /* 

            var ~ auto in C++. Автоматично встановлює тип змінної відповідно до виразу справа
            List<тип> = список, який складається з об'єктів заданого типу. Тобто List<double> буде містити список значень типу double і нічого більше

            ref - аналог &variable у C++. Передає змінну не за значенням, а за посиланням, що дозволяє модифікувати її усередині функції
            out var = дозволяє вам передати зміну, значення якої обов'язково має бути проставленим усередині функції. Тип також автоматично визначається усередині функції. 
            ref і out схожі між собою, але є певна відмінність.
            ref - усередині може змінюватися, а може не змінюватися.out - усередині має змінюватися 

            */

            #endregion

            // у нашому випадку функція проставить у змінні значення double
            // Помістили зчитування усіх вихідних полів у єдиний метод, щоб зробити головну функцію більш стисло
            var isConfigurationValid = Configure(out var startRange, out var endRange, out var step);
            
            if (isConfigurationValid) // якщо усі три поля введено правильно
            {
                // перед побудовою графіків необхідно витерти усі попередні точки. Інакше нові точки додадуться до існуючих і намалюють щось дивне

                ClearSeries();

                // перевіряємо відрізок, щоб його кінцеві точки були від меншого до більшого. Також перевіряємо що наш крок має позитивне значення і він не дорівнює нулю
                ValidateRange(ref startRange, ref endRange);
                ValidateStep(ref step);

                // перевіряємо, що хоча б один графік було обрано. Якщо ні - обрати графік за замовченням
                EnsureCheckBoxChecked();

                // створюємо точки на координатній осі X на відрізку [A;B] з кроком H 
                var xPoints = GetXPoints(startRange, endRange, step);

                // створюємо об'єкт, який містить інформацію про точки Х, а також додаткові дані необхідні для побудови графіків. У нашому випадку це границі випадкових чисел
                var details = GetSeriesDetails(xPoints);

                // дістаємо імена усіх натиснутих графіків
                var checkedSeries = GetListOfCheckedSeries();

                // проходимося по кожному з них
                foreach (var seriesName in checkedSeries)
                {
                    // дістаємо відповідний графік з нашого графічного компонента
                    var series = DataChart.Series[seriesName];

                    // дістаємо відповідний йому процессор
                    var processor = Configuration.SeriesMappings[seriesName];

                    // виконуємо процес побудови списку точок (X, Y)
                    var points = processor.Process(details);

                    // наносимо точки на відповідний графік
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
            // зчитуємо три поля вводу. Перевіряємо їх зміст. Повертаємо true, коли усі три введені правильно

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

            // можна звернутися до певного GroupBox і дістати всі його дочірні елементи.
            var controls = VisualizationGroupBox.Controls;

            // проходимося по кожному
            foreach (var control in controls)
            {
                // конструкція is Checkbox перевіряє тип змінної control. Якщо це чекбокс - створює змінну типу CheckBox з нашою назвою, у якої можна перевірити, чи відмічена вона
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    isChecked = true;
                    break;
                }
            }

            // Якщо ми перевірили усі чекбокси і жодний не є обраним
            if (!isChecked)
            {
                // встановлюємо лінійний графік за замовченням
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

            // можна звернутися до певного GroupBox і дістати всі його дочірні елементи.
            var groupBoxControls = VisualizationGroupBox.Controls;

            // проходимося по кожному
            foreach (var control in groupBoxControls)
            {
                // конструкція is Checkbox перевіряє тип змінної control. Якщо це чекбокс - створює змінну типу CheckBox з нашою назвою, у якої можна перевірити, чи відмічена вона
                if (control is CheckBox checkbox && checkbox.Checked)
                {
                    result.Add(checkbox.Text);
                }
            }

            return result;
        }

        private void ClearSeries()
        {
            // проходимося по кожному графіку у графічному елементі. Видаляємо його точки
            var allSeries = DataChart.Series;

            foreach (var series in allSeries)
            {
                series.Points.Clear();
            }
        }

        // створюємо точки на осі X на відрізку [A;B] з кроком step
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
                // аналог swap (&a, &b) у C++
                (start, end) = (end, start);

                StartRangeInput.Text = start.ToString();
                EndRangeInput.Text = end.ToString();

                // @ - рядок не містить символів \w, \n, \t та тому подібних
                // $ дозволяє інтерполювати текст за допомогою змінних з коду
                MessageBox.Show(@$"Проміжок ({end};{start}) змінений на ({start};{end})");
            }
        }

        // перевіряємо крок. Він не може бути від'ємним та нульовим
        private void ValidateStep(ref double step)
        {
            if (step == 0)
            {
                throw new InvalidDataException("Крок не може бути 0.");
            }


            // якщо він від'ємний, беремо його абсолютне значення (за модулем) і повідомляємо про це користувача
            if (step < 0)
            {
                step = Math.Abs(step);

                StepInput.Text = step.ToString();

                MessageBox.Show(@$"Крок змінено з -{step} на {step}");
            }
        }


        // реакція на зміну типу візуалізації графіків
        private void ChartTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // дістаємо усі графіки
            var allSeries = DataChart.Series;

            // дістаємо індекс обраного елементу. Аналог select & options у HTML. 
            var selectedType = ChartTypeComboBox.SelectedIndex;

            // знаходимо визначений нами тип графіку
            var type = (ChartSeriesDisplayType)selectedType;

            // для нашої опції з випадаючого списку дістаємо відповідний тип графіку у ChartArea
            var relatedChartType = Configuration.TypeMappings[type];

            foreach (var item in allSeries)
            {
                // проставляємо для кожного графіку стиль відображення
                item.ChartType = relatedChartType;
            }
        }

        // подія при натисканні на чекбокс з рандомним графіком
        private void RandomCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // якщо елемент став натиснутим - відкриваємо форму
            if (RandomCheckBox.Checked)
            {
                // створюємо нову форму
                var randomNumberForm = new RandomNumbersForm();

                // визначаємо операцію, яку необхідно виконати після зачинення форми. Нам необхідно зчитати уведені користувачем дані
                randomNumberForm.FormClosed += (o, args) =>
                {
                    RandomMinimum = randomNumberForm.RandomMinimum;
                    RandomMaximum = randomNumberForm.RandomMaximum;
                };

                // показуємо форму
                randomNumberForm.ShowDialog();

                // коли вона зачинилася, відображаємо текст з діапазоном випадкових значень
                RandomRangeLabel.Text = $"({RandomMinimum};{RandomMaximum})";
                RandomRangeLabel.Visible = true;
            }
            // якщо вимкнули, треба обнулити попередні дані
            else
            {
                RandomMinimum = null;
                RandomMaximum = null;
                RandomRangeLabel.Text = string.Empty;
                RandomRangeLabel.Visible = false;
            }
        }


        // застосувати перенос по осям, або стиснення
        private void TransformButton_Click(object sender, EventArgs e)
        {
            // обираємо назви графіків, які необхідно перевірити
            var checkedSeries = GetListOfCheckedSeries();

            // якщо графіків немає, або жодний з них не обраний для модифікації - пишемо повідомлення і нічого далі не робимо
            if (!checkedSeries.Any() || !DoesSeriesExist())
            {
                MessageBox.Show("Створіть хоча б один графік");

                return;
            }

            // зчитуємо введений коефіцієнт

            var coefficientInput = TransformationInput.Text;

            var isCoefficientValid = InputHelper.ParseDoubleInput(coefficientInput, TransformationLabel.Text, out var coefficient);

            // якщо він правильний - робимо перетворення
            if (isCoefficientValid)
            {
                foreach (var seriesName in checkedSeries)
                {
                    // дістаємо графік за його ім'ям
                    var series = DataChart.Series[seriesName];

                    // дістаємо усі елементи управління з блоку транформування
                    var controls = TransformationGroupBox.Controls;

                    foreach (var control in controls)
                    {
                        // якщо це натиснутий чекбокс
                        if (control is CheckBox checkBox && checkBox.Checked)
                        {
                            // за ім'ям чекбоксу знаходимо відповідний механізм обробки
                            var transformer = Configuration.TransformMappings[checkBox.Name];

                            // виконуємо перетворення точок
                            transformer.Transform(series, coefficient);
                        }                        
                    }
                }

                // перебудовуємо графік
                DataChart.Invalidate();

            }
            // інакше повідомляємо користувача
            else
            {
                MessageBox.Show("Перевірьте коефіцієнт");
            }
        }


        // перевіряємо, чи існує хоч один графік у якого є намальовані точки
        private bool DoesSeriesExist()
        {
            var result = false;

            // проходимося по кожному графіку
            foreach (var series in DataChart.Series)
            {
                // якщо є хоч одна точка. Any() повертає 1, якщо є елменти у колекції, або 0 якщо колекція пуста
                if (series.Points.Any())
                {
                    result = true;
                    break; // зупиняємо цикл. Нам достатньо хоча б одного графіку
                }
            }

            return result;
        }


        // тут ви маєте реалізувати відчинення вашої форми. Створіть її самостійно і напишіть код, який буде її закривати
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var aboutForm = new AboutForm();

            //aboutForm.ShowDialog();

            // open form with info
        }

        // механізм збереження наших графіків до Excel файлу
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // намагаємося виконати код у фігурних скобках. Якщо виникне помилка - програма автоматично продовжиться у блоці catch
            try
            {
                // відкриваємо провідник файлів, щоб користувач обрав місце і вписав назву новому файлу
                using (var dialog = new SaveFileDialog())
                {
                    dialog.OverwritePrompt = true;          // дозволяємо виводити вікно з підтвердженням перезапису файла
                    dialog.Title = Constants.DialogTitle;   // встановлюємо текст вікна
                    dialog.Filter = Constants.DialogFormat; // встановлюємо тип файлу, який збережеться. У нашому випадку це excel

                    // якщо користувач ввів назву, натиснув на кнопку зберегти. Якщо він закриє вікно, або щось інше - повернеться інший статус
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // отримуємо шлях, куди нам необхідно покласти новий файл, а також його ім'я
                        var filePath = dialog.FileName;

                        // якщо такий самий файл вже існує - його треба перезаписати. У windows перезапис фактично виконує 2 операції: видалення і створення
                        if (File.Exists(filePath))
                        {
                            // видаляємо файл
                            File.Delete(filePath);
                        }

                        // зберігаємо новий
                        SaveExcelFile(filePath);
                    }
                }
            }
            // сюди надійде інформація про виключення, яке сталося під час обробки файлу
            catch (Exception exception)
            {
                // кажемо про це користувачеві
                MessageBox.Show(exception.Message);
            }
        }

        // механізм побудови ексель файлу
        private void SaveExcelFile(string filePath)
        {
            // дістаємо метадані файлу
            var fileInfo = new FileInfo(filePath);

            // створюємо новий ексель файл. using у C# викликає після завершення блоку коду операцію звільнення. Це аналог того, як ви на C++ писали delete[]arr, але тут це автоматично
            using (var excelPackage = new ExcelPackage(fileInfo))
            {
                // беремо усі обрані графіки
                var checkedSeries = GetListOfCheckedSeries();

                foreach (var seriesName in checkedSeries)
                {
                    // дістаємо графік за ім'ям
                    var series = DataChart.Series[seriesName];

                    // створюємо у файлі вкладку з ім'ям нашого графіку
                    var worksheet = excelPackage.Workbook.Worksheets.Add(seriesName);

                    var row = Constants.ExcelStartRow;

                    // пишемо назву колонок у першому рядку
                    worksheet.Cells[row, Constants.XValueInExcel].Value = Constants.XColumnTitle;
                    worksheet.Cells[row, Constants.YValueInExcel].Value = Constants.YColumnTitle;

                    // переходимо на новий рядок
                    row++;

                    // дістаємо усі наявні точки графіку
                    var seriesPoints = series.Points;

                    // кожну точку записуємо у окремий рядок
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

        // механізм відкривання збереженого файлу
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // намагаємося виконати вказаний фрагмент коду
            try
            {
                // відкриваємо діалог де користувач має обрати файл
                using (var dialog = new OpenFileDialog())
                {
                    dialog.Title = Constants.DialogTitle;   // встановлюємо повідомлення
                    dialog.Filter = Constants.DialogFormat; // дозволяємо завантажити тільки excel файли

                    if (dialog.ShowDialog() == DialogResult.OK) // якщо файл успішно обраний
                    {
                        var filePath = dialog.FileName; // зчитуємо шлях та ім'я обраного файлу
                         
                        var fileInfo = new FileInfo(filePath); // дістаємо метадані файлу

                        using (var excelPackage = new ExcelPackage(fileInfo)) // завантажуємо excel файл
                        {
                            ClearSeries(); // очищаємо наші точки на графіку

                            // дістаємо усі вкладки у файлі
                            var worksheets = excelPackage.Workbook.Worksheets;

                            // проходимося по кожній
                            foreach (var worksheet in worksheets)
                            {
                                // завантажуємо графік з вкладки у наш графічний компонент
                                LoadSeriesFromWorksheet(worksheet);
                            }

                            // оновлюємо графічник компонент
                            DataChart.Invalidate();
                        }
                    }
                }
            }
            // Якщо виникла помилка - нотифікуємо користувача
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        // механізм зчитування excel файлу
        private void LoadSeriesFromWorksheet(ExcelWorksheet excelWorksheet)
        {
            // дістаємо графік за назвою вкладки, вони мають співпадати
            var series = DataChart.Series[excelWorksheet.Name];

            // сюди ми будемо записувати отримані з файлу точки
            var points = new List<SeriesPoint>();

            // дивимося максимальну кількість точок у вкладці
            var maxRows = excelWorksheet.Dimension.Rows;

            // проходимося від початку таблиці до кінця, рядок за рядком
            for (var row = Constants.ExcelReadStartRow; row <= maxRows; row++)
            {
                // якщо ми ще не дочитали файл, але зустріли пусту клітинку - повідомляємо про помилку
                if (string.IsNullOrWhiteSpace(excelWorksheet.Cells[row, Constants.XValueInExcel].Value?.ToString()))
                    throw new InvalidOperationException("File contains empty rows");

                // за замовченням в клітинках знаходиться текст. Нам необхідно перетворити його на тип double
                var x = Convert.ToDouble(excelWorksheet.Cells[row, Constants.XValueInExcel].Value);
                var y = Convert.ToDouble(excelWorksheet.Cells[row, Constants.YValueInExcel].Value);

                // створюємо нашу точку
                var point = new SeriesPoint(x, y);

                // додаємо до списку
                points.Add(point);
            }

            // після того, як ми зчитали усі точки з файлу - додаємо їх до відповідного графіку
            foreach (var point in points)
            {
                series.Points.AddXY(point.X, point.Y);
            }
        }
    }
}
