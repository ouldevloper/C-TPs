using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace tp9
{
    class Program
    {
        /*public static void caal()
        {
            Console.WriteLine("Enter ur nembers {x + y * w ...} : ");
            string s = Console.ReadLine();
            //Regex reg = new Regex(@"(\d|(\d{1,},\d{1,}))((+|-|*|/)(\d{1,}|(\d{1,},\d{1,})))*$");
            Regex reg = new Regex(@"^(\d)+([+|-|*|/]\d+)+$");
            Match m = reg.Match(s);
            //Console.Write(s.Length);
            /*if (m.Success)
            {
                string[] entier = s.Split('+', '-', '*', '/');
                string[] sm = Regex.Split(s, @"\d");
                
            }
            if (m.Success)
            {
                string[] entier = s.Split('+','-','*','/');
                string[] sm = Regex.Split(s,@"\d");
                double sum = Convert.ToDouble(entier[0]);
                for (int j = 0; j < entier.Length && j + 1 < entier.Length; j++)
                {
                   
                        switch (sm[j])
                        {
                            case "+":
                                {
                                    sum += Convert.ToDouble(entier[j+1]);
                                    break;
                                  
                                }
                            case "-":
                                {
                                    sum -= Convert.ToDouble(entier[j+1]);
                                    break;
                                 
                                }
                            case "*":
                                {
                                    sum *= Convert.ToDouble(entier[j+1]);
                                    
                                    break;
                                   
                                }
                            case "/":
                                {
                                    sum/= Convert.ToDouble(entier[j+1]);
                                    break;
                               
                                }
                    }
                }
                Console.WriteLine(sum);
            }

        }*/
        public static void matrecul()
        {
            Console.WriteLine("Enter ur matrecule : ");
            string s = Console.ReadLine();
            Regex reg = new Regex("[1-9]{1}[0-9]{0,3}[a-zA-Z]{1,3}((0[0-9]{1})|([1-9]{1}[0-9]{1})|(2a)|(2b))$");
            Match m = reg.Match(s);
            if (m.Success)
                Console.WriteLine("matrecule valide\n");
            else
                Console.WriteLine("matrecule non valide\n");
        }
        public static double cal()
        {
            Console.WriteLine("Enter ur nembers : ");
            string s = Console.ReadLine();
            double sum = 0.0 ;
            Regex reg = new Regex(@"(\d{1,}(\t|,| )\d{1,})*$");
            Match m = reg.Match(s);
            if (m.Success)
            {
                string[] n = s.Split('\t',' ');
                foreach (string it in n)
                {
                    
                         sum += Convert.ToDouble(it);
                }
            }
            return sum;
        }

        public static void enre()
        {
            Console.WriteLine("Enter a nember : ");
            string s = Console.ReadLine();
            Regex entier = new Regex("\\d+");
            Regex reel = new Regex("^\\d+,\\d{1,}$");
            Regex ch = new Regex("\\W");
            Match m1 = entier.Match(s);
            Match m2 = reel.Match(s);
            Match m3 = ch.Match(s);
            if (m1.Success)
            {
                if (m2.Success)
                    Console.WriteLine("reel\n");
                else if (m1.Success)
                    Console.WriteLine("entier\n");
                else if (m3.Success) 
                    Console.WriteLine("chaine de caracter\n");
            }
            else if (m3.Success) Console.WriteLine("chaine de character\n");
            else  Console.WriteLine("chaine de character\n");
        }


        static void Main(string[] args)
        {
            //caal();
            enre();
            //Console.WriteLine(cal());
           //matrecul();
            Console.Read();
        }
    }
}
