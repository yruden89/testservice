using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestService.Providers.CommonTypes;

namespace TestService.Providers.Interfaces
{
    public interface IOperationsProvider
    {
        decimal ExecuteOperation(decimal fistNumber, decimal secondNumber, OperationType operationType);
    }
}