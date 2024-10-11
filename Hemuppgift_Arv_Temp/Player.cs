using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public abstract class Player
    {

        // Egenskaper
        public string UserID { get; set; }

        // Konstruktor
        public Player(string userID) // ändr namn parameter? 
        {
            UserID = userID;
        }

        // Metoder
        public string GetUserID()
        {

        }

        public abstract int takePins(Board board) 
        {

        }
    }
}
