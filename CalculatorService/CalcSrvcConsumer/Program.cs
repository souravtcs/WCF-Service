using CalculatorService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSrvcConsumer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number:");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number:");
            int n2 = Convert.ToInt32(Console.ReadLine());            
            Console.WriteLine("Please enter operation type:\n");
            Console.WriteLine("1:Add");
            Console.WriteLine("2:Substract");
            Console.WriteLine("3:Multiply");
            Console.WriteLine("4:Divide");
            int operation = Convert.ToInt32(Console.ReadLine());
            switch (operation)
            {
                case 1:
                    Add(n1, n2);
                    break;
                case 2:
                    Substract(n1, n2);
                    break;
                case 3:
                    Multiply(n1, n2);
                    break;
                case 4:
                    Divide(n1, n2);
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }
        private static void Add(int n1, int n2)
        {
            Calc c = new Calc();            
            Console.WriteLine("Result is : {0}",c.Add(n1, n2).ToString());
        }
        private static void Substract(int n1, int n2)
        {
            Calc c = new Calc();
            Console.WriteLine("Result is : {0}", c.Subtract(n1, n2).ToString());
        }
        private static void Multiply(int n1, int n2)
        {
            Calc c = new Calc();
            Console.WriteLine("Result is : {0}", c.Multiply(n1, n2).ToString());
        }
        private static void Divide(int n1, int n2)
        {
            Calc c = new Calc();
            Console.WriteLine("Result is : {0}", c.Divide(n1, n2).ToString());
        }
    }
}

