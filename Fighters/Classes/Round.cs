using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public class Round
    {
        public Player Defender { get; private set; }
        public Player Attacker { get; private set; }


        public int RoundNumber { get; private set; } = 1;


        public Round(Player player1, Player player2)
        {
            Random random = new Random();

            int number = random.Next(0, 1);

            if (number == 1)
            {
                Defender = player1;
                Attacker = player2;
            }
            else
            {
                Defender = player2;
                Attacker = player1;
            }
        }

        public void NextRound()
        {
            RoundNumber++;

            SwapFightersRoles();
        }
        
        private void SwapFightersRoles()
        {
            Player player = Defender;
            Defender = Attacker;
            Attacker = player;
        }
    }
}
