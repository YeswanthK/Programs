using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WindowsClient.TemperatureService;

namespace WindowsClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WeatherReportClient proxy = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            proxy = new WeatherReportClient("WSHttpBinding_WeatherReport");
        }

        private void getTempButton_Click(object sender, EventArgs e)
        {
            temperatureLabel.Text = String.Format("The temperature is {0}", proxy.GetCurrentTemp(cityTextBox.Text));
        }

        private void getForecastButton_Click(object sender, EventArgs e)
        {
            var forecast = new TemperatureService.Forecast();
            forecast = proxy.Getforecast(cityTextBox.Text);

            day1LowTextBox.Text = forecast.Day1Low.ToString();
            day1HighTextBox.Text = forecast.Day1High.ToString();
            day1DetailsTextBox.Text = forecast.Day1Details.ToString();
            day2LowTextBox.Text = forecast.Day2Low.ToString();
            day2HighTextBox.Text = forecast.Day2High.ToString();
            day2DetailsTextBox.Text = forecast.Day2Details.ToString();
            authorTextBox.Text = forecast.Author.ToString();
        }

        private void saveForecastButton_Click(object sender, EventArgs e)
        {
            var forecast = new TemperatureService.Forecast();

            forecast.city = cityTextBox.Text;
            forecast.Day1Low = Convert.ToDouble(day1LowTextBox.Text);
            forecast.Day1High = Convert.ToInt32(day1HighTextBox.Text);
            forecast.Day1Details = day1DetailsTextBox.Text;
            forecast.Day2Low = Convert.ToInt32(day2LowTextBox.Text);
            forecast.Day2High = Convert.ToInt32(day2HighTextBox.Text);
            forecast.Day2Details = day2DetailsTextBox.Text;
            forecast.Author = authorTextBox.Text;

            proxy.SaveForecast(forecast);
        }
    }
}
