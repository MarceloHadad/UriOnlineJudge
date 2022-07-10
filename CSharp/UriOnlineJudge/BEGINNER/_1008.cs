using System;
using System.Collections.Generic;
using System.Text;

namespace UriOnlineJudge.BEGINNER
{
    class _1008
    {
        public void Execute()
        {
            int number, workedHours;
            double receivePerHour;

            number = int.Parse(Console.ReadLine());
            workedHours = int.Parse(Console.ReadLine());
            receivePerHour = double.Parse(Console.ReadLine());

            var salary = workedHours * receivePerHour;

            Console.WriteLine("NUMBER = " + number + "\n" +
                "SALARY = U$ " + salary.ToString("000.00"));

        }
    }
}
