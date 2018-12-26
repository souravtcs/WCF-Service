using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Mvc;
using WCFService;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewModel m = new ViewModel();
            return View(m);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult InvokeHttp()
        {
            Service1 obj = new Service1();
            ViewModel m = new ViewModel();
            m.HttpInvoke = new InvokeModel();
            m.HttpInvoke.SayHello = obj.SayHello("raju");
            m.HttpInvoke.SayToday = obj.TodayProgram("raju");
            return View("Index", m);
        }
        public ActionResult InvokeTCP()
        {
            //ServiceHost m_svcHost;
            //Uri adrbase = new Uri("net.tcp://localhost:8734/Service1");
            //m_svcHost = new ServiceHost(typeof(Service1), adrbase);
            //NetTcpBinding tcpb = new NetTcpBinding();

            //ServiceMetadataBehavior mBehave = new ServiceMetadataBehavior();
            //m_svcHost.Description.Behaviors.Add(mBehave);
            //m_svcHost.AddServiceEndpoint(typeof(IMetadataExchange),
            //  MetadataExchangeBindings.CreateMexTcpBinding(), "mex2");

            //m_svcHost.AddServiceEndpoint(typeof(Service1), tcpb, "net.tcp://localhost:8734/IService1");
            //m_svcHost.Open();
            


            Service1 obj = new Service1();
            ViewModel m = new ViewModel();
            m.TCPInvoke = new InvokeModel();
            m.TCPInvoke.SayHello = obj.SayHello("raju");
            m.TCPInvoke.SayToday = obj.TodayProgram("raju");
            return View("Index", m);
        }
    }
}