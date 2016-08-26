using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TimeServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ITimeService
    {
        [OperationContract]
        CityTime GetTime(string city);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CityTime
    {
        private string CityValue;
        [DataMember()]
        public string City
        {
            get
            { return CityValue;}
            set
            { CityValue = value;}
        }
        private DateTime LocalTimeValue;
        [DataMember()]
        public DateTime LocalTime
        {
            get { return LocalTimeValue; }
            set { LocalTimeValue = value; }
        }
        private string TimeZoneValue;
        [DataMember()]
        public string TimeZone
        {
            get { return TimeZoneValue; }
            set { TimeZoneValue = value; }
        }
    }
}
