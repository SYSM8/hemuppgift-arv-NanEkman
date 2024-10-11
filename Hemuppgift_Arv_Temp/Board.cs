using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class Board
    {
        // Egenskaper/Properties
        public int NumOfPins { get; private set; } // NumOfPins bärde kan endast ändras från denna klass

        // Metoder
        public void SetUp(int numOfPins) 
        {
            NumOfPins = numOfPins;
        }

        //Metoden låter spelaren dra en eller två stickor enligt spelarens strategi och returnerar sedan antalet dragna stickor
        public void TakePins(int numOfPins)
        {
            try
            {
                Console.WriteLine("Ange om du vill ta 1 eller 2 stickor:");
                int pinsTaken = Convert.ToInt32(Console.ReadLine());

                // Kontrollera att spelaren väljer 1 eller 2 stickor
                if (pinsTaken == 1 || pinsTaken == 2)
                {
                    Console.WriteLine($"Du har valt att ta {pinsTaken} sticka/stickor.");

                    // Minska antal stickor på board
                    if (pinsTaken <= NumOfPins)
                    {
                        NumOfPins -= pinsTaken; // Uppdatera antal stickor på board
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

        public int GetNoPins()
        {
            Console.WriteLine($"Antalet stickor kvar på brädet: {NumOfPins}");
            return NumOfPins;
        }

        //        Programmet ska inkludera lämpliga utskrifter(antalet stickor kvar på bordet,
        //antalet stickor som datorspelaren tar, vem som vinner) så att användaren kan
        //följa spelets gång.Det ska också hantera felaktig indata på ett robust sätt
        //(t.ex.om en människospelare försöker ta för få eller för många stickor).
    }
}
