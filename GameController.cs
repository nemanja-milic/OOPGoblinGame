using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPGoblinGame
{
    internal class GameController
    {
        private Player Player;

        private Goblin Goblin;

        private int ActionNumber {  get; set; } 

        public GameController() 
        {
            Player = new Player("Player", 80);
            Goblin = new Goblin("Goblin", 40);
        }

        public void StartGame()
        {
            while(Player.HP > 0 && Goblin.HP > 0)
            {
                InputActions();
                TriggerAction();
            }
            if (Player.HP == 0)
            {
                Console.WriteLine("Player lost, Goblin won");
                return;
            }
            else if (Goblin.HP == 0)
            {
                Console.WriteLine("Player won");
                return;
            }
        }

        public void InputActions()
        {
            int actionNumber = 0;

            while (actionNumber == 0)
            {
                string? inputAction = Console.ReadLine();
                if (inputAction != null)
                {
                    bool result = int.TryParse(inputAction, out actionNumber);
                    if(result) ActionNumber = actionNumber;
                }
            }
        }

        public void TriggerAction()
        {
            if(ActionNumber == 1)
            {
                Goblin.Attack(Player);
                Player.Attack(Goblin);
            }

            else if(ActionNumber == 2)
            {
                Player.Heal();
            }

            Console.WriteLine(Player.ShowStatus());
            Console.WriteLine(Goblin.ShowStatus());
        }
    }
}
