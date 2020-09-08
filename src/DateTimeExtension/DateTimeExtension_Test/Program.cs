using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTimeExtension;

namespace DateTimeExtension_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            
            Console.WriteLine("StartOfDay()");
            Console.WriteLine(now.StartOfDay());

            Console.WriteLine("EndOfDay()");
            Console.WriteLine(now.EndOfDay());

            Console.WriteLine("StartOfMonth()");
            Console.WriteLine(now.StartOfMonth());
                  
            Console.WriteLine("EndOfMonth()");
            Console.WriteLine(now.EndOfMonth());

            Console.ReadLine();

        }
    }
}
