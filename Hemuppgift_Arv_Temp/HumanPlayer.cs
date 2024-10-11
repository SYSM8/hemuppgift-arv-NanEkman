using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class HumanPlayer : Player
    {
        public HumanPlayer(string humanPlayer) : base(humanPlayer)
        {
            // behöver inte göra något specifikt med HumanPlayer då detta skickats till basklassen Player
        }

        //Metoden låter spelaren dra en eller två stickor enligt spelarens strategi och returnerar sedan antalet dragna stickor
        public override int TakePins(Board board)
        {
            try
            {
                Console.WriteLine($"Your userID is: {UserID}");

                Console.WriteLine("Ange om du vill ta 1 eller 2 stickor:");
                int pinsTaken = Convert.ToInt32(Console.ReadLine());

                // Kontrollera att spelaren väljer 1 eller 2 stickor
                if (pinsTaken == 1 || pinsTaken == 2)
                {
                    Console.WriteLine($"Du har valt att ta {pinsTaken} sticka/stickor.");

                    // Minska antal stickor på board
                    if (pinsTaken <= board.NumOfPins)
                    {
                        board.NumOfPins -= pinsTaken; // Uppdatera antal stickor på board
                        
                    }
                    else
                    {
                        Console.WriteLine("Det finns inte tillräckligt många stickor kvar!");
                    }
                }
                else
                {
                    Console.WriteLine("Du måste välja antingen 1 eller 2 stickor.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Felaktig inmatning, ange en siffra, 1 eller 2.");
            }
            return board.NumOfPins;

        }
    }
}
