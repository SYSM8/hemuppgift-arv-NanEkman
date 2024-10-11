namespace Hemuppgift_Arv_Temp
{
    internal class TakePins
    {
        //Här är main klassen där koden ska testas, lägg in i mappen
        static void Main(string[] args)
        {
            // Objekt för klassen Board
            Board board = new Board();
            board.SetUp(15); // antalet stickor på brädet
            board.TakePins(1); // default värde satt

            //ComputerPlayer comPlay = new ComputerPlayer();

        }

    }
}
