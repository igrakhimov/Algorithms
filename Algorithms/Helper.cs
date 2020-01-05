using System;
using System.Collections.Generic;

namespace Algorithms
{
    public static class Helper
    {
        private static readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        public static Guid AddAlert(DateTime time)
        {
            Guid id = Guid.NewGuid();
            alerts.Add(id, time);
            return id;
        }

        public static DateTime GetAlert(Guid id)
        {
            return alerts[id];
        }

        public static string IntToRoman(int number)
        {
            string result = null;

            int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romanDigits = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            for (int i = 0; i < numbers.Length && number > 0; i++)
            {
                while (number >= numbers[i])
                {
                    number -= numbers[i];
                    result += romanDigits[i];
                }
            }

            return result;
        }
    }
}
