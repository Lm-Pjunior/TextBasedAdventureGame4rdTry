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
            Console.WriteLine("Type 'Attack', 'Heal', 'Mercy' or 'Check' in order to check on what you're holding \r\n" +
                "down in order to choose your path oh labotamised one.\r\n");
            answer = Console.ReadLine();
            if(answer == "Attack" ||  answer == "attack")
            {
                Console.WriteLine(" Uheuhuuuu weird thing is noooiiccyyy... I smack noiccyyyy thiiing.\r\n");
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
                Console.WriteLine("Sadly enough for you, you don't have enough healing left nor can you sacrifice your frontal lobe for whatever kind of magic that was.\r\n");
            }

            if(answer == "Mercy" || answer == "mercy")
            {
                Console.WriteLine("\r\n Error: Mercy.exe not found.\r\n " +
                    "I swing noicy noicy thing away.");
                PlayerStatus.Attacking = true;
            }
            if(answer == "check" || answer == "Check")
            {
                Console.WriteLine($"You currently hold {PlayerStatus.Healing} healing on you and your weapon consists of {PlayerStatus.Weapon}.\r\n");
                Attack();
            }
            
        }
    }
}
