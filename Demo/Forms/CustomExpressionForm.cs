using NCalc;

namespace Demo.Forms
{
    public partial class CustomExpressionForm : Form
    {
        public string Formula { get; set; } = null!;

        public CustomExpressionForm()
        {
            InitializeComponent();
        }

        private void EvaluateExpressionButton_Click(object sender, EventArgs e)
        {
            var formula = ExpressionInput.Text;

            var expression = new Expression(formula);

            try
            {
                expression.Parameters.Add("x", 1);

                if (expression.HasErrors())
                {
                    throw new InvalidOperationException(expression.Error);
                }

                var value = expression.Evaluate();
                
                Formula = formula;

                Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
