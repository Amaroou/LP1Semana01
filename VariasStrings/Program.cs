using System;

namespace VariasStrings
{
    
    class Program
    {
        static void Main(string[] args)
        {
            double xx= 0.12345;
            int ii = 18;
            string s = "C:\\Users\\jamar\\TRABALHOSLP01\\LP1Semana01";
            string s2 = @"C:\Users\jamar\TRABALHOSLP01\LP1Semana01";
            string d = "\"String original entre aspas\"";
            string d2 = @"""String ainda mais original entre aspas""";
            Console.WriteLine(s);
            Console.WriteLine(s2);
            Console.WriteLine(d);
            Console.WriteLine(d2);
            Console.WriteLine("{0:f2} e {0:p1}", xx, xx);
            Console.WriteLine("{0:x0} e {0:c0}", ii, ii);
        }
    }
}
