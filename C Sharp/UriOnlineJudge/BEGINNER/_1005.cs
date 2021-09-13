using System;
using System.Collections.Generic;
using System.Text;

namespace UriOnlineJudge.BEGINNER
{
    class _1005
    {
        public void Execute()
        {
            double num1, num2;

            num1 = double.Parse(Console.ReadLine());
            num2 = double.Parse(Console.ReadLine());

            var media = ((num1 * 3.5) + (num2 * 7.5)) / 11;

            Console.WriteLine("MEDIA = " + media.ToString("0.00000"));
        }
    }
}
