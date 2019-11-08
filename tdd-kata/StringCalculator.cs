using System;
using System.Linq;

namespace tdd_kata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var numbers = input.Split(new[] {',', '\n'}).Select(int.Parse);
            if (numbers.Any(n => n < 0))
                throw new ArgumentException("Negatives are not allowed");
            return numbers.Sum();
        }
    }
}