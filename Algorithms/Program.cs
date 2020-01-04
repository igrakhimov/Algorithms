using System;
using System.Collections.Generic;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Linq;

namespace Algorithms
{
    public class Palindrome
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

        public static void Main(string[] args)
        {
            int[] stockPrices = { 10, 7, 5, 8, 11, 9 };

            // Returns 6 (buying for $5 and selling for $11)
            GetMaxProfit(stockPrices);
            Console.WriteLine(Palindrome.IsPalindrome("Deleveled"));
        }

        public static int GetMaxProfit(int[] stockPrices)
        {
            if (stockPrices.Length < 2)
            {
                throw new ArgumentException("Getting a profit requires at least 2 prices",
                    nameof(stockPrices));
            }

            // We'll greedily update minPrice and maxProfit, so we initialize
            // them to the first price and the first possible profit
            int minPrice = stockPrices[0];
            int maxProfit = stockPrices[1] - stockPrices[0];

            // Start at the second (index 1) time.
            // We can't sell at the first time, since we must buy first,
            // and we can't buy and sell at the same time!
            // If we started at index 0, we'd try to buy *and* sell at time 0.
            // This would give a profit of 0, which is a problem if our
            // maxProfit is supposed to be *negative*--we'd return 0.
            for (int i = 1; i < stockPrices.Length; i++)
            {
                int currentPrice = stockPrices[i];

                // See what our profit would be if we bought at the
                // min price and sold at the current price
                int potentialProfit = currentPrice - minPrice;

                // Update maxProfit if we can do better
                maxProfit = Math.Max(maxProfit, potentialProfit);

                // Update minPrice so it's always
                // the lowest price we've seen so far
                minPrice = Math.Min(minPrice, currentPrice);
            }

            return maxProfit;
        }

    }

}



//public class AlertService
//    {
//        private readonly AlertDAO storage = new AlertDAO();

//        public Guid RaiseAlert()
//        {
//            return this.storage.AddAlert(DateTime.Now);
//        }
         
//        public DateTime GetAlertTime(Guid id)
//        {
//            return this.storage.GetAlert(id);
//        }
//    }

//    public class AlertDAO
//    {
//        private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

//        public Guid AddAlert(DateTime time)
//        {
//            Guid id = Guid.NewGuid();
//            this.alerts.Add(id, time);
//            return id;
//        }

//        public DateTime GetAlert(Guid id)
//        {
//            return this.alerts[id];
//        }
//    }

//    //* Definition for singly-linked list.
//    internal class ListNode {
//            public int val;
//            public ListNode next;

//            public ListNode(int x) { val = x; }
//        }

//        internal class SingleLinkedList
//        {
//            internal ListNode head;
//        }


//        static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
//        {
//            var num1 = 0;
//            var num2 = 0;

            

//            //ßvar tempIg = l1.Last;

//            if (l1 == null)
//                return l2;
//            if (l2 == null)
//                return l1;

//            //get nodes counts

            
//            try
//            {
//                num1 = Int32.Parse(string.Concat(l1.next.next.next.next.val.ToString(), l1.next.next.next.val.ToString(), l1.next.next.val.ToString(), l1.next.val.ToString(), l1.val.ToString()));
//            }
//            catch (Exception)
//            {
//                try
//                {
//                    num1 = Int32.Parse(string.Concat(l1.next.next.next.val.ToString(), l1.next.next.val.ToString(), l1.next.val.ToString(), l1.val.ToString()));
//                }
//                catch (Exception)
//                {
//                    try
//                    {
//                        num1 = Int32.Parse(string.Concat(l1.next.next.val.ToString(), l1.next.val.ToString(), l1.val.ToString()));
//                    }
//                    catch (Exception)
//                    {
//                        try
//                        {
//                            num1 = Int32.Parse(string.Concat(l1.next.val.ToString(), l1.val.ToString()));
//                        }
//                        catch (Exception)
//                        {
//                            num1 = Int32.Parse(l1.val.ToString());
//                        }
//                    }
//                }

//            }


//            try
//            {
//                num2 = Int32.Parse(string.Concat(l2.next.next.val.ToString(), l2.next.val.ToString(), l2.val.ToString()));
//            }
//            catch (Exception)
//            {
//                try
//                {
//                    num2 = Int32.Parse(string.Concat(l2.next.val.ToString(), l2.val.ToString()));
//                }
//                catch (Exception)
//                {
//                    num2 = Int32.Parse(l2.val.ToString());
//                }
//            }




//            var sum = num1 + num2;

//            var sumToString = sum.ToString();

//            string input = String.Empty;
//            ListNode listNodeResult = new ListNode(0);

//            if (sumToString.Count() == 6)
//            {
//                input = sumToString[5].ToString();

//                int temp = Int32.Parse(input);

//                listNodeResult = new ListNode(temp);

//                input = sumToString[4].ToString();

//                temp = Int32.Parse(input);

//                listNodeResult.next = new ListNode(temp);

//                input = sumToString[3].ToString();

//                temp = Int32.Parse(input);

//                listNodeResult.next.next = new ListNode(temp);

//                input = sumToString[2].ToString();

//                temp = Int32.Parse(input);

//                listNodeResult.next.next.next = new ListNode(temp);

//                input = sumToString[1].ToString();

//                temp = Int32.Parse(input);

//                listNodeResult.next.next.next.next = new ListNode(temp);

        //        input = sumToString[0].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next.next.next.next = new ListNode(temp);
        //    }
        //    else if (sumToString.Count() == 5)
        //    {
        //        input = sumToString[4].ToString();

        //        int temp = Int32.Parse(input);

        //        listNodeResult = new ListNode(temp);

        //        input = sumToString[3].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next = new ListNode(temp);

        //        input = sumToString[2].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next = new ListNode(temp);

        //        input = sumToString[1].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next.next = new ListNode(temp);

        //        input = sumToString[0].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next.next.next = new ListNode(temp);
        //    }
        //    else if (sumToString.Count() == 4)
        //    {
        //        input = sumToString[3].ToString();

        //        int temp = Int32.Parse(input);

        //        listNodeResult = new ListNode(temp);

        //        input = sumToString[2].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next = new ListNode(temp);

        //        input = sumToString[1].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next = new ListNode(temp);

        //        input = sumToString[0].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next.next = new ListNode(temp);
        //    }

        //    else if (sumToString.Count() == 3)
        //    {
        //        input = sumToString[2].ToString();

        //        int temp = Int32.Parse(input);

        //        listNodeResult = new ListNode(temp);

        //        input = sumToString[1].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next = new ListNode(temp);

        //        input = sumToString[0].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next.next = new ListNode(temp);
        //    }
        //    else if (sumToString.Count() == 2)
        //    {
        //        input = sumToString[1].ToString();

        //        int temp = Int32.Parse(input);

        //        listNodeResult = new ListNode(temp);

        //        input = sumToString[0].ToString();

        //        temp = Int32.Parse(input);

        //        listNodeResult.next = new ListNode(temp);
        //    }
        //    else
        //    {
        //        input = sumToString[0].ToString();

        //        int temp = Int32.Parse(input);

        //        listNodeResult = new ListNode(temp);
        //    }



        //    return listNodeResult;

        //}


        //static string IntToRoman(int number)
        //{
        //    string result = null;

        //    int[] numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        //    string[] romanDigits = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

        //    for (int i = 0; i < numbers.Length && number > 0; i++)
        //    {
        //        while (number >= numbers[i])
        //        {
        //            number -= numbers[i];
        //            result += romanDigits[i];
        //        }
        //    }

        //    return result;
        //}


        ////Sudoku
        //public bool IsValidSudoku(char[][] board)
        //{
        //    if (!checkBoardBySquare(board) || !checkBoardByRow(board) || !checkBoardByCol(board))
        //        return false;
        //    else
        //        return true;

        //}
        //// check for duplicate values in a row by passing it the board and a single row
        //bool rowCheck(char[][] play, int row)
        //{
        //    String keepTrack = "";

        //    for (int j = 0; j < 9; j++)
        //        if (play[row][j].ToString() != ".")
        //            keepTrack += play[row][j];

        //    return (keepTrack.Length - keepTrack.ToCharArray().Distinct().Count() >= 1);
        //}


        // checking board row by row
        //// if one row has duplicate values, then the board is invalid
        //bool checkBoardByRow(char[][] play)
        //{
        //    bool validBoard = true;

        //    for (int row = 0; row < 9; row++)
        //    {
        //        if (rowCheck(play, row))
        //            validBoard = false;
        //    }
        //    return validBoard;
        //}


        //// check for duplicate values in a column by passing it the board and a single column
        //bool colCheck(char[][] play, int col)
        //{
        //    String keepTrack = "";

        //    for (int i = 0; i < 9; i++)
        //        if (play[i][col].ToString() != ".")
        //            keepTrack += play[i][col];

        //    return (keepTrack.Length - keepTrack.ToCharArray().Distinct().Count() >= 1);
        //}


        //// checking board row by row
        //// if one row has duplicate values, then the board is invalid
        //bool checkBoardByCol(char[][] play)
        //{
        //    bool validBoard = true;

        //    for (int col = 0; col < 9; col++)
        //    {
        //        if (colCheck(play, col))
        //            validBoard = false;
        //    }
        //    return validBoard;
        //}


        //bool squareCheck(char[][] play, int row, int col)
        //{
        //    String keepTrack = "";

        //    for (int i = row; i < (row + 3); i++)
        //    {
        //        for (int j = col; j < (col + 3); j++)
        //            if (play[i][j].ToString() != ".")
        //                keepTrack += play[i][j];
        //    }
        //    return (keepTrack.Length - keepTrack.ToCharArray().Distinct().Count() >= 1);
        //}


    //    bool checkBoardBySquare(char[][] play)
    //    {
    //        bool validBoard = true;

    //        for (int i = 0; i < 9; i += 3)
    //        {
    //            //check to see if square is valid or not
    //            for (int j = 0; j < 9; j += 3)
    //            {
    //                // if a duplicate number on the 3x3 square exists, then board is false
    //                if (squareCheck(play, i, j))
    //                    validBoard = false;
    //            }
    //        }
    //        return validBoard;
    //    }
    //    //End Sudoku
    //    public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
    //        WebHost.CreateDefaultBuilder(args)
    //            .UseStartup<Startup>();
    //}

