using System;
using System.Diagnostics.SymbolStore;
using System.Threading;

namespace Leonding.Pose.TicTacToe
{
    class Program
    {
        public static void Main(string[] args)
        {
            // TicTacToe field
            string TicTacToeField = "     1   2   3  \n   ------------- \n A |   |   |   |\n   -------------\n B |   |   |   |\n   -------------\n C |   |   |   |\n   -------------\n";

            /*
            Console.WriteLine("     1   2   3  ");
            Console.WriteLine("   -------------");
            Console.WriteLine(" A |   |   |   |");
            Console.WriteLine("   -------------");
            Console.WriteLine(" B |   |   |   |");
            Console.WriteLine("   -------------");
            Console.WriteLine(" C |   |   |   |");
            Console.WriteLine("   -------------");
            */


            //random number for first player
            Random random = new Random();
            int firstPlayerRandom = random.Next(1, 3);

            //ask the user for name
            Console.Write(">> Please enter the first Player (X): ");
            string firstPlayer = Console.ReadLine();

            Console.Write("Please enter the seconds Player (O): ");
            string secondPlayer = Console.ReadLine();

            //calculate first Player via if
            string firstPlayerString = string.Empty;
            string secondPlayerString = string.Empty;
            if (firstPlayerRandom == 1)
            {
                firstPlayerString = firstPlayer;
                secondPlayerString = secondPlayer;
            }
            else if (firstPlayerRandom == 2)
            {
                firstPlayerString = secondPlayer;
                secondPlayerString = firstPlayer;
            }

            bool draw = false;
            bool win = false;
            //Bitte noch Bedingung ändern
            for (int i = 1; !draw || !win; i++)
            {
                if (i % 2 == 0 && !draw && !win)
                {
                    Console.WriteLine($"{secondPlayerString}, it's your turn!");
                }
                else
                {
                    Console.WriteLine($"{firstPlayerString}, it's your turn!");
                }
                Console.Write(TicTacToeField);
                Console.Write($"Please enter {i}. field number: ");
                string fieldNumber = Console.ReadLine();
            }
        }
    }
}