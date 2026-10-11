using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGoblinGame
{
    internal class Player : Character, IAttack, IHeal
    {
        public Player(string name, int hp)
            :base(name, hp)
        { }

        public void Attack(Character enemy)
        {
            enemy.HP = enemy.HP - 20;    
        }

        public void Heal()
        {
            HP = HP + 20;
        }
    }
}
