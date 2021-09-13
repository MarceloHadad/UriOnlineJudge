using System;
using System.Collections.Generic;
using System.Text;

namespace UriOnlineJudge.BEGINNER
{
    class _1010
    {
        public void Execute()
        {
            string input1, input2;

            input1 = Console.ReadLine();
            input2 = Console.ReadLine();

            var result1 = input1.Split(' ');
            var result2 = input2.Split(' ');

            var valueToPay = int.Parse(result1[1]) * double.Parse(result1[2]) + int.Parse(result2[1]) * double.Parse(result2[2]);

            Console.WriteLine("VALOR A PAGAR: R$ " + valueToPay.ToString(".00"));

        }
    }
}
