using System;

namespace VariasStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "C:\\Users\\jamar\\TRABALHOSLP01\\LP1Semana01";
            string s2 = @"C:\Users\jamar\TRABALHOSLP01\LP1Semana01";
            string d = "\"String original entre aspas\"";
            string d2 = @"""String ainda mais original entre aspas""";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
        }
    }
}
