using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class AdvancedComputerPlayer : Player
    {
        public AdvancedComputerPlayer(string advancedComputerPlayer) : base(advancedComputerPlayer)
        {
            // behöver inte göra något specifikt med AdvancedComputerPlayer då detta skickats till basklassen Player
        }

        public override int TakePins(Board board)
        {
            Console.WriteLine();
            Random randomPins = new Random();
            int pinsTaken;

            if (board.NumOfPins == 4)
            {
                pinsTaken = 1;
            }
            else if (board.NumOfPins == 3)
            {
                pinsTaken = 2;
            }
            else
            {
                pinsTaken = randomPins.Next(1, 3); // Genererar random mellan 1 och 2
            }

            if (pinsTaken <= board.NumOfPins)
            {
                Console.WriteLine($"Datorn tog {pinsTaken}");
                board.NumOfPins -= pinsTaken;
            }
            else
            {
                Console.WriteLine("Det finns inte tillräckligt många stickor kvar!");
            }

            return board.NumOfPins;
        }
    }
}
