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
            NumOfPins -= numOfPins;
            Console.WriteLine($"{numOfPins} har tagits från brädet.");
        }

        public int GetNoPins() // Get Number of Pins
        {
            Console.WriteLine($"Antalet stickor kvar på brädet: {NumOfPins}");
            return NumOfPins;
        }
    }
}
