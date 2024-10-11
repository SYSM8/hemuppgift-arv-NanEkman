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
            player1.GetUserID();
            player1.TakePins(board.NumOfPins);
            board.GetNoPins();

            Player player2 = new ComputerPlayer("Computer");
            player2.GetUserID();
            board.TakePins(1);
            board.GetNoPins();






        }

    }
}
