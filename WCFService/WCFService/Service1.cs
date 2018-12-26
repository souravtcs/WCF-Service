using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public string SayHello(string name)
        {
            string msg = string.Empty;
            if (DateTime.Now.ToString("tt") == "AM")
                msg = "Good morning " + name;
            else if (DateTime.Now.ToString("tt") == "PM")
                msg = "Good afternoon " + name;
            return msg;
        }
        public string TodayProgram(string name)
        {
            string msg = string.Empty;
            if ((DateTime.Now.DayOfWeek == DayOfWeek.Saturday) || (DateTime.Now.DayOfWeek == DayOfWeek.Sunday))
                msg = "Happy weekend " + name;
            else
                msg = "Happy weekday " + name;
            return msg;
        }

    }
}
