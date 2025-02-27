using Calc.Business.Core;

namespace Calc.Business.Operations;

public class MultiplyOperation : IOperation
{
    public double Execute(double a, double b) => a * b;
}
