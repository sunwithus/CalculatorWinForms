using System.Linq.Expressions;
using Calc.Business.Core;
using Calc.Business.Services;

namespace WinFormsCalc
{


    public partial class FormCalc : Form
    {
        private readonly CalculatorEngine _calculator = new();

        public FormCalc()
        {
            InitializeComponent();
             WireAllButtons(Controls);
        }

        // Обработка всех числовых кнопок через один метод (паттерн Наблюдатель)
        private void WireAllButtons(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Button button && char.IsDigit(button.Text[0]))
                {
                    button.Click += NumberButton_Click;
                }
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            var button = (Button)sender;
            richTextBox1.Text += button.Text;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            _calculator.Clear();
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    _calculator.SetFirstNumber(double.Parse(richTextBox1.Text));
                    _calculator.SetOperation(((Button)sender).Text);
                    richTextBox1.Clear();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(richTextBox1.Text))
                {
                    var secondNumber = double.Parse(richTextBox1.Text);
                    var result = _calculator.Calculate(secondNumber);
                    richTextBox1.Text = result.ToString();
                }
            }
            catch (Exception ex)
            {
                HandleError(ex);
            }
        }

        private void HandleError(Exception ex)
        {
            richTextBox1.Text = "Error";
            MessageBox.Show(ex.Message, "Calculation Error",
                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            _calculator.Clear();
        }

        private void About_Click(object sender, EventArgs e)
        {
            var formAbout = new FormAbout();
            formAbout.Show();
        }

    }
}
