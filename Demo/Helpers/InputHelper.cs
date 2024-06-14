namespace Demo.Helpers
{
    // статичний клас, до якого можна звернутися з будь-якого місця у рамках цього проекту. У подібні класи потрібно виносити речі, які можуть бути уживаними багато де
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
