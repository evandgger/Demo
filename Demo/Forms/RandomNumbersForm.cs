using Demo.Helpers;

namespace Demo.Forms
{
    public partial class RandomNumbersForm : Form
    {
        public RandomNumbersForm()
        {
            InitializeComponent();
        }

        public double RandomMinimum { get; set; }

        public double RandomMaximum { get; set; }

        private void ApplyRandomButton_Click(object sender, EventArgs e)
        {
            var randomMinimalText = RandomMinimumInput.Text;
            var randomMaximumText = RandomMaximumInput.Text;

            var isRandomMinimalValid = InputHelper.ParseDoubleInput(randomMinimalText, RandomMinimumLabel.Text, out var randomMinimum);
            var isRandomMaximumValid = InputHelper.ParseDoubleInput(randomMaximumText, RandomMaximumLabel.Text, out var randomMaximum);

            if (isRandomMinimalValid && isRandomMaximumValid)
            {
                ValidateRange(ref randomMinimum, ref randomMaximum);

                RandomMinimum = randomMinimum;
                RandomMaximum = randomMaximum;

                Close();
            }
            else
            {
                MessageBox.Show("Перевірьте дані, будь ласка");
            }
        }

        private void ValidateRange(ref double start, ref double end)
        {
            if (start > end)
            {
                (start, end) = (end, start);

                RandomMinimumInput.Text = start.ToString();
                RandomMaximumInput.Text = end.ToString();

                MessageBox.Show(@$"Проміжок ({end};{start}) змінений на ({start};{end})");
            }
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
    }
}
