using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web;
using TestService.Models;

namespace TestService.Providers.Interfaces
{
    public interface IConverterService
    {
        Task<ConvertResult> Convert(decimal amount, string currencyFrom, string currencyTo);
    }
}