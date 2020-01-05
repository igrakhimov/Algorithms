using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace Algorithms
{
    public class Palindrome
    {
        

        public static void Main(string[] args)
        {
            int[] stockPrices = { 10, 7, 5, 8, 11, 9 };

            // Returns 6 (buying for $5 and selling for $11)
            MaxProfit.GetMaxProfit(stockPrices);
            Console.WriteLine(Polindrome.IsPalindrome("Deleveled"));
        }



    }
}