using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailPrac
{
    class Program
    {
        static void Main(string[] args)
        {
            EmailHandler.SendEmail("bitf15m001@pucit.edu.pk", "Testing", "Good Night <3 ");
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
