using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Razor;
using Newtonsoft.Json.Linq;
using TestService.Models;
using TestService.Providers.Interfaces;

namespace TestService.Providers
{
    public class ConverterService: IConverterService
    {
        private string uriTemplate =
            "http://www.apilayer.net/api/live?access_key=ed601e6d57682ed640283d41fdb32396&from={0}&to={1}&amount={2}";

        public async Task<ConvertResult> Convert(decimal amount, string currencyFrom, string currencyTo)
        {
            var uri = string.Format(uriTemplate, currencyFrom, currencyTo, amount);
            using (HttpClient httpClient = new HttpClient())
            {
                var response = await httpClient.GetAsync(uri);
                var jsonString = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(jsonString);
                string ratetString;
                try
                {
                    ratetString = json.SelectToken(String.Format("$.quotes.{0}{1}", currencyFrom.ToUpper(), currencyTo.ToUpper())).ToString();
                }
                catch (Exception e)
                {
                    return new ConvertResult() { IsSuccessfull = false };
                }

                decimal rate = 0;
                Decimal.TryParse(ratetString, out rate);

                if (rate == 0)
                {
                    return new ConvertResult() {IsSuccessfull = false};
                }

                return new ConvertResult() {IsSuccessfull = true, Result = rate*amount};
            }
        }
    }
}