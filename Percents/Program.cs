using System;
using System.Globalization;

namespace Percents
{
    class Program
    {
        static void Main(string[] args)
        {
            string s=Console.ReadLine();
           
            double d= Calculate(s);
            Console.WriteLine(d);
        }

        public static double Calculate(string userInput)
        {
            
            string[] c = userInput.Split(' ');
         
            double sum = double.Parse(c[0], CultureInfo.InvariantCulture);
            double proc = double.Parse(c[1]);
            double procInAMonth = (double)proc / 12;
            var countMonth = int.Parse(c[2]);
            return (sum * Math.Pow(1 + 0.01 * procInAMonth, countMonth));
            //return 0.0;
        }
    }
}
