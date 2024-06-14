namespace Demo.Helpers
{
    public static class InputHelper
    {
        public static bool ParseDoubleInput(string input, string nameOfField, out double value)
        {
            var isValid = double.TryParse(input, out value);

            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show($"{nameOfField} не може бути пустим");
            } 
            else if (!isValid)
            {
                MessageBox.Show($"{nameOfField} не може містити букви");
            }

            return isValid;
        }
    }
}
