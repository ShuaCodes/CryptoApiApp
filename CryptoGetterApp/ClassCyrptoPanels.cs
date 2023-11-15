using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCryptoApp
{
    internal class CryptoPanel
    {
        public ComboBox CoinSelectBox { get; set; }
        public ComboBox CurrencySelectBox { get; set; }
        public Label PriceLabel { get; set; }
        public ListView HistoricalPriceListView { get; set; }
        public Panel DisplayPanel { get; set; }

        public CryptoPanel(ComboBox coinBox, ComboBox currencyBox, Label priceLabel, ListView historicalView, Panel displayPanel)
        {
            CoinSelectBox = coinBox;
            CurrencySelectBox = currencyBox;
            PriceLabel = priceLabel;
            HistoricalPriceListView = historicalView;
            DisplayPanel = displayPanel;

            InitializeCoinComboBox(new CoinSymbols().GetAllCoins());
            InitializeCurrencyComboBox(new CurrencySymbols().GetAllCurrencies());

        }

        public void InitializeCoinComboBox(List<string> coinList)
        {
            if (CoinSelectBox != null)
            {

                CoinSelectBox.DataSource = coinList;
            }
        }

        public void InitializeCurrencyComboBox(List<string> currencyList)
        {
            if (CurrencySelectBox != null)
            {
                CurrencySelectBox.DataSource = currencyList;
            }
        }
    }
}
