using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TemperatureServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name ="WeatherReport",Namespace ="http://www.ia.com/wcf")]
    public interface ITemperatureService
    {
        [OperationContract]
        int GetCurrentTemp(string city);

        [OperationContract]
        Forecast Getforecast(string city);

        [OperationContract]
        void SaveForecast(Forecast forecast);
        // TODO: Add your service operations here
    }
    [DataContract(Namespace = "http://www.ia.com/wcf")]
    public class Forecast
    {
        [DataMember]
        public string city { get; set; }

        [DataMember(Name = "Day1Low")]
        public double Day1LowTemp { get; set; }

        [DataMember(Name = "Day1High")]
        public int Day1HighTemp { get; set; }

        [DataMember]
        public string Day1Details { get; set; }

        [DataMember(Name = "Day2Low")]
        public int Day2LowTemp { get; set; }

        [DataMember(Name = "Day2High")]
        public int Day2HighTemp { get; set; }

        [DataMember]
        public string Day2Details { get; set; }

        [DataMember]
        public string Author { get; set; }

    }
}


