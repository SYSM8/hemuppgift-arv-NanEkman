using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hemuppgift_Arv_Temp
{
    public abstract class Player
    {

        // Egenskaper/Properties
        public string UserID { get; set; } 

        // Konstruktor
        public Player(string userID) 
        {
            UserID = userID;
        }

        // Metoder
        public string GetUserID()
        {
            return $"Your userID is: {UserID} ";
        }

        public abstract int TakePins(Board board);



    }
}
