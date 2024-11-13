using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Fulbank.ViewModel
{
    internal class ApiUsage
    {
        public static async Task<decimal> Ethereum(string desire)
        {
            string url = "https://api.coingecko.com/api/v3/simple/price?ids=ethereum&vs_currencies=usd,eur&precision=full";

            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();

                JObject json = JObject.Parse(responseBody);
                decimal usdPrice = json["ethereum"]["usd"].Value<decimal>();
                decimal eurPrice = json["ethereum"]["eur"].Value<decimal>();
                if (desire == "eur")
                {
                    return eurPrice;
                }
                else
                {
                    return usdPrice;
                }
            }
        }

        public static async Task<decimal> Bitcoin(string desire)
        {
            string url = "https://api.coingecko.com/api/v3/simple/price?ids=bitcoin&vs_currencies=usd,eur&precision=full";
            using (HttpClient client = new HttpClient())
            {
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);
                decimal usdPrice = json["bitcoin"]["usd"].Value<decimal>();
                decimal eurPrice = json["bitcoin"]["eur"].Value<decimal>();
                if (desire == "eur")
                {
                    return eurPrice;
                }
                else
                {
                    return usdPrice;
                }
            }

        }
    }
}
