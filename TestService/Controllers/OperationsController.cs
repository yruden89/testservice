using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using TestService.Models;
using TestService.Providers.Interfaces;

namespace TestService.Controllers
{
    public class OperationsController : ApiController
    {
        private IOperationsProvider operationsProvider;

        public OperationsController(IOperationsProvider operationsProvider)
        {
            this.operationsProvider = operationsProvider;
        }

        [System.Web.Http.HttpPost]
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        public OperationResult Index(OperationViewModel operationViewModel)
        {
            if (!ModelState.IsValid)
            {
                return new OperationResult() { IsSuccessfull = false, Result = 0};
            }

            var result = operationsProvider.ExecuteOperation(operationViewModel.FirstNumber,
                operationViewModel.SecondNumber, operationViewModel.OperationType);

            return new OperationResult()
            {
                IsSuccessfull = true,
                Result = result
            };

        }

    }
}
