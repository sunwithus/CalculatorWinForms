using Calc.Business.Operations;
using Calc.Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc.Business.Core;

public class CalculatorEngine
{
    private double _firstNumber;
    private IOperation _currentOperation;

    public void SetFirstNumber(double number) => _firstNumber = number;

    public void SetOperation(string operationKey) =>
        _currentOperation = OperationFactory.GetOperation(operationKey);

    public double Calculate(double secondNumber)
    {
        if (_currentOperation == null)
            throw new InvalidOperationException("No operation selected");

        return _currentOperation.Execute(_firstNumber, secondNumber);
    }

    public void Clear()
    {
        _firstNumber = 0;
        _currentOperation = null;
    }

    public void SetOperation(AddOperation addOperation)
    {
        throw new NotImplementedException();
    }
}
