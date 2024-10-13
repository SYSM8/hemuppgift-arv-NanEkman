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
            int pinsTaken = 0;         
            bool validInput = false; // Variabel för att kontrollera om inmatningen är giltig

            while (!validInput)
            {
                try
                {
                    Console.WriteLine("Ange om du vill ta 1 eller 2 stickor:");
                    pinsTaken = Convert.ToInt32(Console.ReadLine());

                    // Kontrollera att spelaren väljer 1 eller 2 stickor
                    if (pinsTaken == 1 || pinsTaken == 2)
                    {
                        // Kontrollera om det finns tillräckligt många stickor på brädet
                        if (pinsTaken <= board.NumOfPins) 
                        {
                            Console.WriteLine($"Du har valt att ta {pinsTaken} sticka/stickor.");
                            board.NumOfPins -= pinsTaken; // Minska antal stickor på brädet
                            validInput = true; // Avsluta loopen då korrekt inmatning har gjorts
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
            }

            return board.NumOfPins;
        }
    }
}
