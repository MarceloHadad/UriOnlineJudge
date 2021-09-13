using System;
using System.Globalization;

namespace UriOnlineJudge.BEGINNER
{
    class _1002
    {
        public void Execute()
        {
            double pi = 3.14159;

            double r = double.Parse(Console.ReadLine());

            double a = pi * Math.Pow(r, 2);

            Console.WriteLine("A=" + a.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}