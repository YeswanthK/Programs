using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TimeServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TimeService : ITimeService
    {
        private CityTime cityTime = null;

        public CityTime GetTime(string city)
        {
            cityTime = new CityTime();
            switch (city)
            {
                case "Eden Prairie":
                    cityTime.City = "Eden Prairie";
                    cityTime.LocalTime = DateTime.UtcNow.AddHours(-6);
                    cityTime.TimeZone = "(GMT-6:00) Central Time(US & Canada)";
                    break;
                case "Redmond":
                    cityTime.City = "Redmond";
                    cityTime.LocalTime = DateTime.UtcNow.AddHours(-8);
                    cityTime.TimeZone = "(GMT-8:00) Pacific Time(US & Canada)";
                    break;
                case "London":
                    cityTime.City = "London";
                    cityTime.LocalTime = DateTime.UtcNow;
                    cityTime.TimeZone = "(GMT) Greenwich Mean Time: Dublin, Edinburgh, Lisbon, London";
                    break;
                default :
                    cityTime.City = "Unknown";
                    cityTime.LocalTime = DateTime.UtcNow;
                    cityTime.TimeZone = "Unknown";
                    break;
            }
            return cityTime;
                
        }
    }
}
