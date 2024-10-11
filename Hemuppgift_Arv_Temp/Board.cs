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
        }

        //Metoden låter spelaren dra en eller två stickor enligt spelarens strategi och returnerar sedan antalet dragna stickor
        public void TakePins(int numOfPins)
        {
            Console.WriteLine("Du behöver välja om du ska ta 1 eller 2 stickor");
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
