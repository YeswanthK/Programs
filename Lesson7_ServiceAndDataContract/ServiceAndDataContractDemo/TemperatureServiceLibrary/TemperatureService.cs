using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;

namespace TemperatureServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TemperatureService : ITemperatureService
    {
        public int GetCurrentTemp(string city)
        {
            var RandomNumber = new Random();
            int currentTemp = 0;

            switch (city)
            {
                case "Eden Prairie":
                    currentTemp = RandomNumber.Next(20, 40);
                    break;
                case "Redmond":
                    currentTemp = RandomNumber.Next(41, 60);
                    break;
                default:
                    currentTemp = RandomNumber.Next(61, 80);
                    break;
            }
            return currentTemp;

        }

        public Forecast Getforecast(string city)
        {
            var forecast = new Forecast();
            var randomNumber = new Random();

            forecast.city = city;
            switch (city)
            {
                case "Eden Prairie":
                    forecast.Day1LowTemp = randomNumber.Next(20, 30) * .82D;
                    forecast.Day1HighTemp = randomNumber.Next(30, 40);
                    forecast.Day1Details = "cold, windy, snowy";
                    forecast.Day2LowTemp = randomNumber.Next(10, 20);
                    forecast.Day2HighTemp = randomNumber.Next(20, 30);
                    forecast.Day2Details = "Colder, windier, snowier";
                    forecast.Author = "YashwantSigns";
                    break;
                case "Redmond":
                    forecast.Day1LowTemp = randomNumber.Next(40, 50) * .82D;
                    forecast.Day1HighTemp = randomNumber.Next(50, 60);
                    forecast.Day1Details = "Rain turning to showers";
                    forecast.Day2LowTemp = randomNumber.Next(30, 40);
                    forecast.Day2HighTemp = randomNumber.Next(40, 50);
                    forecast.Day2Details = "Showers turning to rain";
                    forecast.Author = "KrishnaSigns";
                    break;
                default:
                    forecast.Day1LowTemp = randomNumber.Next(60, 70) * .82D;
                    forecast.Day1HighTemp = randomNumber.Next(70, 80);
                    forecast.Day1Details = "Sunny and warm";
                    forecast.Day2LowTemp = randomNumber.Next(60, 70);
                    forecast.Day2HighTemp = randomNumber.Next(70, 80);
                    forecast.Day2Details = "Sunny and warm";
                    forecast.Author = "AlokSigns";
                    break;
            }
            return forecast;
        }

        public void SaveForecast(Forecast forecast)
        {
            var cityForecast = new XDocument(
                                    new XDeclaration("1.0", "utf-8", "yes"),
                                    new XElement("Forecast",
                                        new XElement("city", forecast.city),
                                        new XElement("Day1",
                                            new XElement("Low", forecast.Day1LowTemp),
                                            new XElement("High", forecast.Day1HighTemp),
                                            new XElement("Details", forecast.Day1Details)),
                                        new XElement("Day2",
                                            new XElement("Low", forecast.Day2LowTemp),
                                            new XElement("High", forecast.Day2HighTemp),
                                            new XElement("Details", forecast.Day2Details)),
                                        new XElement("Author", forecast.Author))
                                             );
            cityForecast.Save(String.Format(
                @"C:\Users\Yeswanth\Desktop\SourceInfotech\WCF\Programs\Lesson7_ServiceAndDataContract\Forecast for {0}.xml", forecast.city));
        }
    }
}
