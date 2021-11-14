using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisoon
{
    class Program
    {

        static int GCF(int a, int b)
        {
            if (a > b)
            {
                return GCF(b, a);
            }
            if ( a == b )
            {
                return a; 
            }
            for (int i = a; i >= 1; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    return i;
                }
            }
            return 1;
        }
        static void Main(string[] args)
        {
            int a = 0;
            var b = 0;
            string answer = "";
            string simple = "";
            double deci = 0.51;
            var GCD = 0;
           int sima = 0;
            int simb = 0;
            var Ran = new Random();
            while(true)
            {
                
                a = Ran.Next(1,100);
                b = Ran.Next(1, 100);
                deci = Math.Round((System.Convert.ToDouble(a) / b) * 100) / 100 ;
                GCD = GCF(a, b);
                sima = a / GCD;
                simb = b / GCD;
                simple = sima.ToString() + "/" + simb.ToString();
                Console.WriteLine("What is " + a.ToString() + "/" +b.ToString() + " either rounded to the nearest hundred or in simplest from  NO MIXED NUMBERS!!!!!" );
                answer = Console.ReadLine().Replace(" ", "");
                if ( answer == simple || double.Parse(answer) == deci)
                {
                    Console.WriteLine("good job!");
                }
                else
                {
                    Console.WriteLine("Wrong the answer is " + deci + " or " + simple);
                }

            }
        }
    }
}
