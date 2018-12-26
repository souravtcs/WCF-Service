using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFService;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Service1 obj = new Service1();

            Console.WriteLine(obj.SayHello("Raju"));
            Console.WriteLine(obj.TodayProgram("Raju"));

            Console.ReadLine();
        }
    }
}
