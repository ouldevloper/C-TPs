using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace regexx
{
    class Program
    {
        public static void numVer(string x)
        {
            Regex r = new Regex("^(([+]\\d{1,3}\\d{1})|([0]\\d{1}))\\d{8,16}$");
            Match m = r.Match(x);
            if (m.Success)
                Console.WriteLine("mach");
            else
                Console.WriteLine("not match");
        }

        public static void verUrl(string x)
        {
            Regex r = new Regex("(([https]|[http])[://www\\.]|[www\\.])[a-z0-9_\\.]{3,}[\\.][a-z0-9]{2,}$");
            Match m = r.Match(x);
            if (m.Success)
                Console.WriteLine("URL mach\n");
            else
                Console.WriteLine("URL not match\n");

        }

        public static void verEmail(string x)
        {
            Regex r = new Regex("[a-zA-Z]{3,}[\\@][A-Za-z0-9]{2,}[\\.][a-zA-Z0-9]{2,}$");
            Match m = r.Match(x);
            if (m.Success)
                Console.WriteLine("Email mach\n");
            else
                Console.WriteLine("Email not match\n");
        }

       /* public static void verIp(string x)
        {
            Regex r = new Regex("[0-9]{1,3}[:][]{}");
            Match m = r.Match(x);
            if (m.Success)
                Console.WriteLine("Email mach\n");
            else
                Console.WriteLine("Email not match\n");
        }*/

        static void Main(string[] args)
        {
            string x = Console.ReadLine();
            verUrl(x);
            verEmail(x);
            Console.ReadLine();
        }
    }
}
