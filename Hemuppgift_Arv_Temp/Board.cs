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
        public int NumOfPins { get; set; } 

        // Metoder
        public void SetUp(int numOfPins) 
        {
            NumOfPins = numOfPins;
            Console.WriteLine($"Antalet stickor på brädet är: {numOfPins}");
        }

        public void TakePins(int numOfPins)
        {
            NumOfPins-=numOfPins;
            Console.WriteLine($"{numOfPins} har tagits från brädet.");
        }

        public int GetNoPins() // Get Number of Pins
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
