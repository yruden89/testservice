using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;
using TestService.Providers.CommonTypes;
using TestService.Providers.Interfaces;

namespace TestService.Providers
{
    public class OperationsProvider: IOperationsProvider
    {
        public OperationsProvider()
        {

        }

        public decimal ExecuteOperation(decimal firstNumber, decimal secondNumber, OperationType operationType)
        {
            switch (operationType)
            {
                case OperationType.Addition: return firstNumber + secondNumber;
                case OperationType.Subtraction: return firstNumber - secondNumber;
                case OperationType.Multiplication: return firstNumber * secondNumber;
                case OperationType.Division: return firstNumber / secondNumber;
                case OperationType.Equality:
                    if (secondNumber == 0)
                    {
                        return firstNumber;
                    }
                    return secondNumber;
                default:
                    throw new UnknownOperationException();
            }
        }
    }
}