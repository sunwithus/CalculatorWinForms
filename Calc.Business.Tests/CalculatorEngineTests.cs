using Calc.Business.Core;
using Calc.Business.Operations;

namespace Business.Tests;

public class CalculatorEngineTests
{
    [Fact]
    public void Divide_ByZero_ThrowsException()
    {
        var engine = new CalculatorEngine();
        engine.SetFirstNumber(10);
        engine.SetOperation("/");
        Assert.Throws<DivideByZeroException>(() => engine.Calculate(0));
    }

    [Theory]
    [InlineData(5, 3, "+", 8)]
    [InlineData(5, 3, "-", 2)]
    [InlineData(5, 3, "*", 15)]
    [InlineData(100, 2, "/", 50)]
    public void Calculate_TwoNumbers_ReturnsCorrectResult(double a, double b, string op, double expected)
    {
        var engine = new CalculatorEngine();
        engine.SetFirstNumber(a);
        engine.SetOperation(op);
        var result = engine.Calculate(b);
        Assert.Equal(expected, result);
    }
}
