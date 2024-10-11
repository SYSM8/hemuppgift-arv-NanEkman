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
        }

        //Metoden låter spelaren dra en eller två stickor enligt spelarens strategi och returnerar sedan antalet dragna stickor
        public override int TakePins(Board board)
        {
            Random randomPins = new Random();
            int pinsTaken = randomPins.Next(1, 3); // Genererar random mellan 1 och 3

            Console.WriteLine($"Your userID is: {UserID}");

            if (pinsTaken == 1 || pinsTaken == 2)
            {
                Console.WriteLine($"Datorn tog {pinsTaken}");
                if(pinsTaken <= board.NumOfPins)
                {
                    board.NumOfPins -= pinsTaken;
                }
                else
                {
                    Console.WriteLine("Det finns inte tillräckligt många stickor kvar!");
                }
            }
            return board.NumOfPins;
        }
    }
}
