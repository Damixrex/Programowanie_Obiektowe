using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Telewizor jeden = new Telewizor("Philips",100,21);
            Console.Write(jeden.marka);
            Console.Write("\n");
            Console.Write(jeden.cena);
            Console.Write("\n");
            Console.Write(jeden.ekran);
            Console.ReadKey();
        }
    }
}
