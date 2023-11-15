using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace MyCryptoApp
{
    public class Crypto
    {
        private readonly HttpClient _httpClient;

        public Crypto()
        {
            // Initialize HttpClient
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri("https://api.coingecko.com/api/v3/");
        }

        public string GetURI()
        {
            return _httpClient.BaseAddress.ToString();
        }

        public async Task<double> GetCryptoPricesAsync(string cryptoID, string selectedCurrencyCode)
        {
            try
            {
                // Define the API endpoint to get the current crypto price
                string endpoint = $"simple/price?ids={cryptoID}&vs_currencies={selectedCurrencyCode}";

                // Submit API request
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);

                if (response.IsSuccessStatusCode)
                {
                    // Parse the JSON response
                    var responseContent = await response.Content.ReadAsStringAsync();
                    var cryptoData = JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, double>>>(responseContent);

                    // Extract the price
                    if (cryptoData.TryGetValue(cryptoID, out var cryptoInfo))
                    {
                        // Extract the price for the selected currency
                        if (cryptoInfo.TryGetValue(selectedCurrencyCode.ToLower(), out var price))
                        {

                            return price;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            return 0.0;
        }

    }
}
