using System.Diagnostics.Metrics;
using System.Security.Cryptography;

namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {

            // Objekt för klassen Board
            Board board = new Board();

            board.SetUp(15); // antalet startstickor på brädet         

            Player player1 = new HumanPlayer("Nän");
            Player player2 = new ComputerPlayer("Computer");

            // HumanPlayer startar
            Player currentPlayer = player1;

            bool isPlayer1Turn = true;

            while (board.NumOfPins > 0)
            {
                if (isPlayer1Turn)
                {
                    currentPlayer = player1;

                    Console.WriteLine($"{currentPlayer.GetUserID()}s tur!");

                    currentPlayer.TakePins(board);

                    board.GetNoPins();

                    // Kontrollera om spelet är slut
                    if (board.NumOfPins == 0)
                    {
                        Console.WriteLine($"{currentPlayer.GetUserID()} vann!");
                        // avsluta spelet
                        break;
                    }
                }
                else
                {
                    currentPlayer = player2;

                    Console.WriteLine($"{currentPlayer.GetUserID()}s tur!");

                    currentPlayer.TakePins(board);

                    board.GetNoPins();

                    // Kontrollera om spelet är slut
                    if (board.NumOfPins == 0)
                    {
                        Console.WriteLine($"{currentPlayer.GetUserID()} vann!");
                        // avsluta spelet
                        break;
                    }
                }

                isPlayer1Turn =! isPlayer1Turn;
            }
        }
    }
}
