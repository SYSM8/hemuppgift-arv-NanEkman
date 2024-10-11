using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public class ComputerPlayer : Player
    {

        //Datorspelaren ska slumpmässigt välja att dra en eller två stickor

        public ComputerPlayer(string computerPlayer) : base(computerPlayer)
        {
            // behöver inte göra något specifikt med ComputerPlayer då detta skickats till basklassen Player
            // ev skapa objekt av ComputerPlayer här? 
        }

        public override int TakePins(Board board)
        {
            Random randomPins = new Random();
            int pinsTaken = randomPins.Next(1, 3);
            Console.WriteLine($"Datorn tog {randomPins}");
            return board.NumOfPins;
        }
    }
}
