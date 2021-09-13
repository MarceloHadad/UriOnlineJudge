using System;
using System.Collections.Generic;
using System.Text;

namespace UriOnlineJudge.BEGINNER
{
    class _1007
    {
        public void Execute()
        {
            int numA, numB, numC, numD;

            numA = int.Parse(Console.ReadLine());
            numB = int.Parse(Console.ReadLine());
            numC = int.Parse(Console.ReadLine());
            numD = int.Parse(Console.ReadLine());

            var diferenca = numA * numB - numC * numD;

            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}
