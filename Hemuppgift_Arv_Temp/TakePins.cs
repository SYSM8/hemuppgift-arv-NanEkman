﻿namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {

            Player player1 = new HumanPlayer("Nän");
            Player player2 = new ComputerPlayer("Computer");
            player1.GetUserID();

            // Objekt för klassen Board
            Board board = new Board();

            board.SetUp(15); // antalet startstickor på brädet
            board.TakePins(1);
            board.GetNoPins();



            //ComputerPlayer comPlay = new ComputerPlayer();

        }

    }
}
