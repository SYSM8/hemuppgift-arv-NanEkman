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
            // ev skapa objekt av HumanPlayer här? 
        }

        public override int TakePins(Board board)
        {
            return 0;
        }
    }
}
