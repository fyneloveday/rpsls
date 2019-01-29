using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class AI : Player
    {
        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);

        }

        public override string ChooseMove()
        {
            int AIMove = RandomNumber(0, 4);
            userMove = playerMoves[AIMove];
            return userMove;
        }

    }

}
