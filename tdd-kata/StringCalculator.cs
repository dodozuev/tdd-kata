using System.Linq;

namespace tdd_kata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            if (string.IsNullOrEmpty(input))
                return 0;

            var numbers = input.Split(new[] {',', '\n'});
            return numbers.Sum(int.Parse);
        }
    }
}