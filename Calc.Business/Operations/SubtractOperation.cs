using Calc.Business.Core;

namespace Calc.Business.Operations;

public class SubtractOperation : IOperation
{
    public double Execute(double a, double b) => a - b;
}