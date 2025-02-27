using System.Linq.Expressions;
using System.Windows.Forms;
using Calc.Business.Core;
using Calc.Business.Services;

namespace Calc.WinForms;

public partial class FormCalc : Form
{
    private readonly CalculatorEngine _calculator = new();
    private string _currentExpression = "";

    public FormCalc()
    {
        InitializeComponent();
         WireAllButtons(Controls);
    }

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
        _currentExpression += button.Text;
        string text = ResultTextBox.Text;
        if (text.EndsWith("+") || text.EndsWith("-") || text.EndsWith("*") || text.EndsWith("/"))
        {
            ResultTextBox.Text += _currentExpression;
        }
        else
        {
            ResultTextBox.Text = _currentExpression;
        }
    }

    private void ClearButton_Click(object sender, EventArgs e)
    {
        ResultTextBox.Clear();
        _currentExpression = "";
        _calculator.Clear();
    }

    private void OperationButton_Click(object sender, EventArgs e)
    {
        try
        {
            if (!string.IsNullOrEmpty(ResultTextBox.Text))
            {
                _calculator.SetFirstNumber(double.Parse(_currentExpression));
                _calculator.SetOperation(((Button)sender).Text);
                _currentExpression = "";
                ResultTextBox.Text = ((Button)sender).Text;
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
            if (!string.IsNullOrEmpty(ResultTextBox.Text) && _calculator.HasFirstNumber())
            {
                if(_currentExpression != "")
                {
                    var secondNumber = double.Parse(_currentExpression);
                    var result = _calculator.Calculate(secondNumber);
                    _currentExpression = result.ToString();
                }
                ResultTextBox.Text = _currentExpression;
            }
        }
        catch (Exception ex)
        {
            HandleError(ex);
        }
    }

    private void About_Click(object sender, EventArgs e)
    {
        var formAbout = new FormAbout();
        formAbout.Show();
    }
    private void HandleError(Exception ex)
    {
        ResultTextBox.Text = "Error";
        _currentExpression = "";
        MessageBox.Show(ex.Message, "Calculation Error",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
        _calculator.Clear();
    }

}
