using System;
using System.Linq;

namespace Algorithms
{
    public static class Polindrome
    {
        public static bool IsPalindrome(string word)
        {
            var sum =
                (from number in Enumerable.Range(1, 4)
                 group number by number % 2 into sum2
                 select sum2.Sum()).Max();

            var middleOfString = word.Length % 2;
            var result = true;

            for (var i = 0; i <= middleOfString; i++)
            {
                for (var j = word.Length - 1; j >= middleOfString; j--)
                {
                    if (word[i] != word[j])
                    {
                        result = false;
                        break;
                    }

                }

            }
            return result;

        }
    }
}
