using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace squaredrandoms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            var randomNumbers = new List<int>();
            var numbersToDisgard = new List<int>();

            for (var i = 0; i < 20; i++)
            {
                randomNumbers.Add(random.Next(1, 50));
            }

            for (var i =0; i < randomNumbers.Count; i++)
            {
                var squaredNumber = randomNumbers[i] * randomNumbers[i];
                if (squaredNumber % 2 == 0)
                {
                    Console.WriteLine(squaredNumber);
                }
                else
                {
                    randomNumbers.RemoveAt(i);
                }
            }
            Console.Read();
        }
    }
}
