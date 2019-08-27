using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fighting
{
    public delegate void Wound(string player_name, int hp);
    public delegate void Block(string player_name, int hp);

    public class Player : IAction
    {
        private int hp;
        public int Hp
        {
            get
            {
                return hp;
            }
            set
            {
                if (value < 0)
                {
                    hp = 0;
                }
                else
                {
                    hp = value;
                }
            }
        }

        public CyberAttack Defendend { get; private set; }

        public string Name { get; }

        public Player(string name, int hp)
        {
            Name = name;
            Hp = hp;
        }
        
        public void GetHit(CyberAttack attackWay, int damage)
        {
            if (Defendend != attackWay)
            {
                Hp -= damage;
            }
            Wound(Name, Hp);
        }

        public void SetBlock(CyberAttack defendWay)
        {
            Defendend = defendWay;

            Block(Name, Hp);
        }

        public event Wound Wound;
        public event Block Block;
    }
}
