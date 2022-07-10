using System;
using System.Collections.Generic;
using System.Text;

namespace UriOnlineJudge.BEGINNER
{
    class _1006
    {
        public void Execute()
        {
            double numA, numB, numC;

            numA = double.Parse(Console.ReadLine());
            numB = double.Parse(Console.ReadLine());
            numC = double.Parse(Console.ReadLine());

            var media = ((numA * 2) + (numB * 3) + (numC * 5)) / 10;

            Console.WriteLine("MEDIA = " + media.ToString("0.0"));
        }
    }
}
