using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace vse_taq
{
    internal class vse_taq
    {
        static void PrintHeader()
        {
            Console.WriteLine("----------");
            Console.WriteLine("Аз успях");
            Console.WriteLine("Аз съм пълен бот");
        }
        static void Az(int a)
        {
            Console.WriteLine(a*a);
        }
        static void Main(string[] args)
        {
            PrintHeader();
            Az(5);
            Spasen(4, 2.2);
        }
        static void Spasen(int b, double c)
        { 
        double A=b*c;
            Console.WriteLine("A= " + A);
        }

    }
}
