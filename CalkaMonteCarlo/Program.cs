using System;

namespace CalkaMonteCarlo
{
    class Program
    {
        public static void Main(string[] args)
        {
            string x = calka(3, 10, 1000000);
            Console.WriteLine(x);
        }

        public static string calka(int x1, int x2,int liczbaLosowan)
        {
            // p = (x2 - x1)*1
            double pole = x2 - x1;
            int count = 0;
            Random rnd = new Random();
            for (int i =0; i< liczbaLosowan;i++)
            {
                double xi = (double)(rnd.Next(x1*1000000,x2 * 1000000))/1000000;
                double yi = rnd.NextDouble();
                double l = Math.Sin(xi);
                if(l>=0) if (yi <= l) count++;
                if(l<0) if (yi <= -l) count--;

            }
            double k = count * pole / liczbaLosowan;
            string result = Math.Round(k, 10,MidpointRounding.ToZero).ToString();
            return result;
        }
    }
}
