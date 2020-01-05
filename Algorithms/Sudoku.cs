using System;
using System.Linq;

namespace Algorithms
{
    public class Sudoku
    {
        //Sudoku
        public bool IsValidSudoku(char[][] board)
        {
            if (!checkBoardBySquare(board) || !checkBoardByRow(board) || !checkBoardByCol(board))
                return false;
            else
                return true;

        }
        // check for duplicate values in a row by passing it the board and a single row
        bool rowCheck(char[][] play, int row)
        {
            String keepTrack = "";

            for (int j = 0; j < 9; j++)
                if (play[row][j].ToString() != ".")
                    keepTrack += play[row][j];

            return (keepTrack.Length - keepTrack.ToCharArray().Distinct().Count() >= 1);
        }


        // checking board row by row
        // if one row has duplicate values, then the board is invalid
        bool checkBoardByRow(char[][] play)
        {
            bool validBoard = true;

            for (int row = 0; row < 9; row++)
            {
                if (rowCheck(play, row))
                    validBoard = false;
            }
            return validBoard;
        }


        // check for duplicate values in a column by passing it the board and a single column
        bool colCheck(char[][] play, int col)
        {
            String keepTrack = "";

            for (int i = 0; i < 9; i++)
                if (play[i][col].ToString() != ".")
                    keepTrack += play[i][col];

            return (keepTrack.Length - keepTrack.ToCharArray().Distinct().Count() >= 1);
        }


        // checking board row by row
        // if one row has duplicate values, then the board is invalid
        bool checkBoardByCol(char[][] play)
        {
            bool validBoard = true;

            for (int col = 0; col < 9; col++)
            {
                if (colCheck(play, col))
                    validBoard = false;
            }
            return validBoard;
        }


        bool squareCheck(char[][] play, int row, int col)
        {
            String keepTrack = "";

            for (int i = row; i < (row + 3); i++)
            {
                for (int j = col; j < (col + 3); j++)
                    if (play[i][j].ToString() != ".")
                        keepTrack += play[i][j];
            }
            return (keepTrack.Length - keepTrack.ToCharArray().Distinct().Count() >= 1);
        }


        bool checkBoardBySquare(char[][] play)
        {
            bool validBoard = true;

            for (int i = 0; i < 9; i += 3)
            {
                //check to see if square is valid or not
                for (int j = 0; j < 9; j += 3)
                {
                    // if a duplicate number on the 3x3 square exists, then board is false
                    if (squareCheck(play, i, j))
                        validBoard = false;
                }
            }
            return validBoard;
        }
    }
}
