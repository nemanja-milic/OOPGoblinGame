using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGoblinGame
{
    internal abstract class Character
    {
        public string Name { get; set; }

        public int HP { get; set; }


        public Character(string name, int hp)
        {
            Name = name;
            HP = hp;
        }

        public string ShowStatus () 
        {
            return Name + "HP: " + HP;
        }

    }
}
