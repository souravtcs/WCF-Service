using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService_IIS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        List<JobOpening> data;
        public Service1()
        {
            data = new List<JobOpening>();
            data.Add(new JobOpening { JobId = 1, JobName="Job1", Role="Role1"});
            data.Add(new JobOpening { JobId = 2, JobName = "Job2", Role = "Role2" });
            data.Add(new JobOpening { JobId = 3, JobName = "Job3", Role = "Role3" });
            data.Add(new JobOpening { JobId = 4, JobName = "Job4", Role = "Role4" });
        }
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

        public List<JobOpening> GetOpeningJobs()
        {
            return data;
        }
        
        public List<JobOpening> GetOpeningJobsByRole(string Role)
        {
            return data.Where(s=>s.Role==Role).ToList();
        }
    }
}
