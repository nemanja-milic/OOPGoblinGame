using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGoblinGame
{
    internal class Goblin : Character, IAttack
    {
        public Goblin(string name, int hp)
            :base(name, hp)
        {}

        public void Attack(Character player)
        {
            player.HP = player.HP - 10;

        }
    }
}
