using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nim
{
    public class Board
    {
        public char[][] visual;

        public Board()
        {

        }

        public Board(char[][] board)
        {
            visual = board;
        }

        public void InitDefaultBoard()
        {
           visual = new char[3][]
            {
                new char[] {'o', 'o', 'o'},
                new char[] {'o', 'o', 'o', 'o', 'o'},
                new char[] {'o', 'o', 'o', 'o', 'o', 'o', 'o'}
            };
        }

        public string PrintBoard()
        {
            int rowLabel = 0;
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                output += RowIntToChar(rowLabel) + " ";
                rowLabel++;
                for (int j = 0; j < visual[i].Count(); j++)
                {
                    output += visual[i][j];
                }
                output += "\n";
            }
            return output;
        }

        public string PrintBoard(char[][] board)
        {
            int rowLabel = 0;
            string output = "";
            for (int i = 0; i < 3; i++)
            {
                output += RowIntToChar(rowLabel) + " ";
                rowLabel++;
                for (int j = 0; j < board[i].Count(); j++)
                {
                    output += board[i][j];
                }
                output += "\n";
            }
            return output;
        }

        private char RowIntToChar(int r)//Changes between A,B,C to 0,1,2
        {
            char row = 'z';
            switch (r)
            {
                case 0:
                    row = 'A';
                    break;
                case 1:
                    row = 'B';
                    break;
                case 2:
                    row = 'C';
                    break;
            }
            return row;
        }
    }
}
