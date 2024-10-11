using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        private string[] quotes = { "Dzień dobry", "Good morning", "Buenos dias" };
        private int currentQuoteIndex = 0;


        public MainPage()
        {
            InitializeComponent();
        }

        private void OnSliderValueChanged(object sender, ValueChangedEventArgs e)
        {
            int fontSize = (int)e.NewValue;
            quoteLabel.FontSize = fontSize;

            // Ustawiamy wartość na etykiecie "Rozmiar:"
            fontSizeLabel.Text = $"Rozmiar: {fontSize}";
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            currentQuoteIndex = (currentQuoteIndex + 1) % quotes.Length;
            quoteLabel.Text = quotes[currentQuoteIndex];
        }
    }
}
