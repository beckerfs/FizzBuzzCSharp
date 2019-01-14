using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public bool IsFizz(int number)
        {
            return number % 3 == 0;
        }
        
        public bool IsBuzz(int number)
        {
            return number % 5 == 0;
        }

        public bool IsFizzBuzz(int number)
        {
            return number % 15 == 0;
        }

        public void PrintResult(string result)
        {
            Console.WriteLine(result);
        }

        public void PlayFizzBuzz(int end)
        {
            IEnumerable<int> range = Enumerable.Range(1, end);
            foreach (int number in range)
            {
                if (IsFizzBuzz(number))
                {
                    PrintResult("FizzBuzz");
                }
                else if (IsFizz(number))
                {
                    PrintResult("Fizz");
                }
                else if (IsBuzz(number))
                {
                    PrintResult("Buzz");
                }
                else
                {
                    PrintResult($"{number}");
                }
            }
        }
    }
}
