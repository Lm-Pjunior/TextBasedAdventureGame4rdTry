using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class AttackMenu
    {
        public void Attack()
        {
            string answer;
            Console.WriteLine("'Attack', 'Heal' or 'Mercy'? " +
                "\r\n Type down your path oh labotamised one.\r\n");
            answer = Console.ReadLine();
            if(answer == "Attack" ||  answer == "attack")
            {
                Console.WriteLine(" Uheuhuuuu weird thing is noooiiccyyy... I smack noiccyyyy thiiing.\r\n\r\n");
                PlayerStatus.Attacking = true;
            }
            if ((answer == "Heal" || answer == "heal") & PlayerStatus.Healing > 0)
            {
                PlayerStatus.Healing -= 1;
                PlayerStatus.Hp = 160;
                Console.WriteLine($"You hp is {PlayerStatus.Hp} and you have {PlayerStatus.Healing} healing left \r\n");
            }

            if((answer == "Heal" || answer == "heal") & PlayerStatus.Healing <= 0)
            {
                Console.WriteLine("Sadly enough for you, you don't have enough healing left nor can you sacrifice your frontal lobe for whatever kind of magic that was.\r\n\r\n");
            }

            if(answer == "Mercy" || answer == "mercy")
            {
                Console.WriteLine("\r\n Error: Mercy.exe not found.\r\n " +
                    "I swing noicy noicy thing away.");
                PlayerStatus.Attacking = true;
            }
            

        }
    }
}
