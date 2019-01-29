using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Player
    {
         public string userName;
         public string userMove;
        
         public int score;
         // string string;
         public string[] playerMoves = new string[]

        {
            "Rock",
            "Paper",
            "Scissors",
            "Lizard",
            "Spock",
        };

        public void SetName()
        {
            Console.WriteLine("Please Enter Your Name.");
            userName = Console.ReadLine();

           // Console.WriteLine(gameScore);
        }

        public virtual string ChooseMove()
        {
            Console.WriteLine("Please Choose Your Move. Type 1 for Rock, 2 for Paper, 3 for Scissors, 4 for Lizard, and 5 for Spock");
            userMove = Console.ReadLine();
            return userMove;

   
        }

    }
}
