namespace MyCryptoApp
{
    public class CurrencySymbols
    {
        public Dictionary<string, string> CurrencySymbolMap { get; }

        public CurrencySymbols()
        {
            CurrencySymbolMap = new Dictionary<string, string>
            {
                { "USD", "$" },
                { "EUR", "€" },
                { "JPY", "¥" },
                { "GBP", "£" },
                { "AUD", "$" },
                { "CAD", "$" },
                { "CNY", "¥" },
                { "INR", "₹" },
                { "SGD", "$" },
            };
        }

        public string GetSymbol(string currencyCode)
        {
            if (CurrencySymbolMap.TryGetValue(currencyCode, out var symbol))
            {
                return symbol;
            }

            return string.Empty; // Return an empty string if the currency code is not found
        }

        public List<string> GetAllCurrencies()
        {
            return CurrencySymbolMap.Keys.ToList();
        }

    }

    public class CoinSymbols
    {
        private Dictionary<string, string> _coinSymbols;

        public CoinSymbols()
        {
            _coinSymbols = new Dictionary<string, string>
            {
                //define available coins
                //api uses all lowercase values
                {"Bitcoin", "BTC" },
                {"Ethereum", "ETH" },
                {"Loopring", "LRC" },
                {"Litecoin", "LTC" },
                {"Cardano", "ADA" },
                {"Solana", "SOL" },
                {"Dogecoin", "DODGE" },
                {"Shiba-Inu", "SHIB" },
                {"Ripple", "XRP" }
            };
        }
        
        public List<string> GetAllCoins()
        {
            return _coinSymbols.Keys.ToList();
        }

        public string GetSymbol(string currency)
        {
            if (_coinSymbols.TryGetValue(currency, out var symbol))
            {
                return symbol;
            }
            return string.Empty;
        }
    }
}
