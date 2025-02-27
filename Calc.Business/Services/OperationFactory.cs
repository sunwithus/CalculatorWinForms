using Calc.Business.Operations;
using Calc.Business.Core;

namespace Calc.Business.Services;

public static class OperationFactory
{
    private static readonly Dictionary<string, IOperation> _operations = new()
        {
            { "+", new AddOperation() },
            { "-", new SubtractOperation() },
            { "*", new MultiplyOperation() },
            { "/", new DivideOperation() }
        };

    public static IOperation GetOperation(string key)
    {
        if (_operations.TryGetValue(key, out var operation))
            return operation;
        throw new ArgumentException("Invalid operation");
    }
}
