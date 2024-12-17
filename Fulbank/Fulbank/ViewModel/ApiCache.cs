using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

public static class ApiCache
{
    private static Dictionary<string, (decimal price, DateTime timestamp)> cache = new Dictionary<string, (decimal, DateTime)>();
    private static readonly TimeSpan cacheDuration = TimeSpan.FromMinutes(5); // Durée du cache

    public static async Task<decimal> GetCryptoPrice(string crypto, string currency)
    {
        string key = $"{crypto}-{currency}";
        if (cache.ContainsKey(key) && (DateTime.Now - cache[key].timestamp) < cacheDuration)
        {
            return cache[key].price; // Retourne le prix depuis le cache
        }

        decimal price = await FetchCryptoPrice(crypto, currency); // Appelle l'API
        cache[key] = (price, DateTime.Now); // Met à jour le cache
        return price;
    }

    private static async Task<decimal> FetchCryptoPrice(string crypto, string currency)
    {
        string url = $"https://api.coingecko.com/api/v3/simple/price?ids={crypto}&vs_currencies={currency}&precision=full";

        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();
            JObject json = JObject.Parse(responseBody);

            if (json[crypto] == null || json[crypto][currency] == null)
            {
                throw new Exception($"Les données pour {crypto} en {currency} ne sont pas disponibles.");
            }

            decimal price = json[crypto][currency].Value<decimal>();
            return price;
        }
    }
}
