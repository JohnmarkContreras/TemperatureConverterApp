using Microsoft.Maui.Controls;

namespace TemperatureConverterApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnConvertClicked(object sender, EventArgs e)
        {
            double temp;
            if (!double.TryParse(temperatureEntry.Text, out temp))
            {
                resultLabel.Text = "Invalid temperature!";
                return;
            }

            switch (conversionPicker.SelectedIndex)
            {
                case 0: // Celsius to Fahrenheit
                    resultLabel.Text = $"Temperature in Fahrenheit: {CelsiusToFahrenheit(temp)}";
                    break;
                case 1: // Fahrenheit to Celsius
                    resultLabel.Text = $"Temperature in Celsius: {FahrenheitToCelsius(temp)}";
                    break;
                case 2: // Celsius to Kelvin
                    resultLabel.Text = $"Temperature in Kelvin: {CelsiusToKelvin(temp)}";
                    break;
                case 3: // Kelvin to Celsius
                    resultLabel.Text = $"Temperature in Celsius: {KelvinToCelsius(temp)}";
                    break;
                case 4: // Fahrenheit to Kelvin
                    resultLabel.Text = $"Temperature in Kelvin: {FahrenheitToKelvin(temp)}";
                    break;
                case 5: // Kelvin to Fahrenheit
                    resultLabel.Text = $"Temperature in Fahrenheit: {KelvinToFahrenheit(temp)}";
                    break;
                default:
                    resultLabel.Text = "Invalid conversion!";
                    break;
            }
        }

        // Temperature conversion methods
        private double CelsiusToFahrenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        private double FahrenheitToCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) * 5 / 9;
        }

        private double CelsiusToKelvin(double celsius)
        {
            return celsius + 273.15;
        }

        private double KelvinToCelsius(double kelvin)
        {
            return kelvin - 273.15;
        }

        private double FahrenheitToKelvin(double fahrenheit)
        {
            return (fahrenheit + 459.67) * 5 / 9;
        }

        private double KelvinToFahrenheit(double kelvin)
        {
            return kelvin * 9 / 5 - 459.67;
        }
    }
}
