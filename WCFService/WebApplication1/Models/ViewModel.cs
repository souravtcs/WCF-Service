using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ViewModel
    {
        public InvokeModel HttpInvoke { get; set; }
        public InvokeModel TCPInvoke { get; set; }
    }
    public class InvokeModel
    {
        public string SayHello { get; set; }
        public string SayToday { get; set; }
    }
}