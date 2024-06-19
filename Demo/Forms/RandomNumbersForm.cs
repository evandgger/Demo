using Demo.Helpers;

namespace Demo.Forms
{
    public partial class RandomNumbersForm : Form
    {
        public RandomNumbersForm()
        {
            InitializeComponent();
        }

        // Властивості нашої форми, які будуть видимі для батьківських форм
        public double? RandomMinimum { get; set; }

        public double? RandomMaximum { get; set; }

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

                // руками зачиняємо вікно, коли усе обрано
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
    }
}
