using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twic.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Example example = new Example(2137912);

            Console.WriteLine(example.Number);
            Console.WriteLine();

            Console.WriteLine("English : " + example.English);
            Console.WriteLine("Spanish : " + example.Spanish);
            Console.WriteLine("French : " + example.French);

            Console.ReadLine();
        }
    }
}
