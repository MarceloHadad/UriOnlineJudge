using System;
using System.Collections.Generic;
using System.Text;

namespace UriOnlineJudge.BEGINNER
{
    class _1009
    {
        public void Execute()
        {
            string firstName;
            double sellersSalary, totalSales;

            firstName = Console.ReadLine();
            sellersSalary = double.Parse(Console.ReadLine());
            totalSales = double.Parse(Console.ReadLine());

            var finalSalary = sellersSalary + (totalSales * 0.15);

            Console.WriteLine("TOTAL = R$ " + finalSalary.ToString(".00"));
        }
    }
}
