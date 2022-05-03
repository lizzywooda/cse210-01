// CSE 210-01 Tic-Tac-Toe game
// Lizzy Woodruff

using System;
using System.Collections.Generic;

namespace cse210_01
{
    class Program
    {
        static void Main(string[] args)
        {
            makeBoard();
            string player = getPlayer("");
        }
        static List<string> makeBoard()
        {
            var board = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                string j = i.ToString();
                board.Add(j);
            }
            return board;
        }
        static void writeBoard(List<string> board){
            Console.WriteLine($"{board[0]}|{board[1]}|{board[2]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[3]}|{board[4]}|{board[5]}");
            Console.WriteLine("-+-+-");
            Console.WriteLine($"{board[6]}|{board[7]}|{board[8]}");
        }
        static string getPlayer(string player){
            
            if (player == "" || player == "O"){
                return "X";
            }
            else {
                return "O";
            }
        static bool checkDraw(List<string> board){
            for (int i = 0; i < 8; i++){
                if (board[i] != "X" && board[i] != "O")
                {
                    return false;
                }
                return true;
            }
        }
        static bool checkWinner(List<string> board){
            if (board[0] == board[1] && board[1] == board[2]){
                return true;
            }
            else if (board[3] == board[4] && board[4] == board[5]){
                return true;
            }
            else if (board[6] == board[7] && board[7] == board[8]){
                return true;
            }
            else if (board[0] == board[3] && board[3] == board[6]){
                return true;
            }
            else if (board[1] == board[4] && board[4] == board[7]){
                return true;
            }
            else if (board[2] == board[5] && board[5] == board[8]){
                return true;
            }
            else if (board[0] == board[4] && board[4] == board[8]){
                return true;
            }
            else if (board[2] == board[4] && board[4] == board[6]){
                return true;
            }
            else{
                return false;
            }
        }
        static void move()
        }
    }
}
