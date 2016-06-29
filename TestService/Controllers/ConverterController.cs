using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web.Http;
using TestService.Models;
using TestService.Providers.Interfaces;

namespace TestService.Controllers
{
    public class ConverterController : ApiController
    {
        private IConverterService convertService;

        public ConverterController(IConverterService converterService)
        {
            this.convertService = converterService;
        }

        [HttpPost]
        public async Task<ConvertResult> Index(ConvertViewModel convertViewModel)
        {
            if (!ModelState.IsValid)
               return new ConvertResult() {IsSuccessfull = false};

            return await convertService.Convert(convertViewModel.Amount, convertViewModel.From, convertViewModel.To);
        }
    }
}
