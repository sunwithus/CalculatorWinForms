using Calc.Business.Core;

namespace Calc.Business.Operations;

public class DivideOperation : IOperation
{
    public double Execute(double a, double b)
    {
        if (b == 0) throw new DivideByZeroException("Division by zero is not allowed");
        return a / b;
    }
}