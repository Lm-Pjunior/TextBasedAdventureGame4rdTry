using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class HordeRoute
    {
        public void HordePath()
        {
            Console.Clear();
            Console.WriteLine("\r\nYou decide to face the horde but you're unprepared so by the power of imagination \r\n" +
                "you conjure up some healing and a weapon at the cost of your frontal lobe. \r\n\r\n" +
                "You continue walking down a corridor that you do not know anything of afterall how can a simpleton like yourself process even for a single tought...\r\n" +
                "You start hearing loud noices.");

            ScientistHorde scientists = new ScientistHorde("injured scientists", 20, 12, 1);
            scientists.MonstersDmgTaken();

            Console.WriteLine("... Anywho it seems those INJURED scientist were getting chased, a horde of geese have come!\r\n"); 
            GeeseHorde geese = new GeeseHorde("goose", 14, 14, 2);
            geese.MonstersDmgTaken();

            Console.WriteLine("Well... that was quite weird.\r\n" +
                "Fifty... poolnoodles??? POOLNOODLES?!?!?! Did you suddenly get a vision impairement?!?!?! Why poolnoodles? How does that make any sense... \r\n" +
                "Wai- don't interu- me-\r\n");
            HordeOfPoolnoodles poolnoodles = new HordeOfPoolnoodles("poolnoodle", 50, 10, 1);
            poolnoodles.MonstersDmgTaken();


            //story


            //summon sum things here

            if (PlayerStatus.Dmg > 50)
            {

                Console.WriteLine("You arrive at a dead end... sadly your caveman brain couldn't see this comming... but hey at least you managed to hold a multitude of carcases in one han- wait don't \r\n" +
                    "just throw them all at the wall you stuppid baraberian!!! Wait w-w-why is that WORKING?!?!?! WASN'T THIS SUPPSOED TO BE A HIGH SECURITY FACILITY what are these walls made out off? PAPER?!!??!" +
                    " \r\n...Anywho you S O M E H O W managed to break through with sheer brute force... despite it going against every law of nature... finishing your 'weapons' off, makking a gigantic mess. \r\n\r\n" +
                    "[labomtamized caveman ending achieved]");
                System.Environment.Exit(0);
            }

            if(PlayerStatus.Dmg <= 50 || PlayerStatus.Hp <= 50)
            {
                Console.WriteLine("You arrived at a dead end... you walk to the wall and throw your weapon against it... it bounced back into your head... nothing important was harmed.\r\n " +
                    "Your physically incapable of break the wall as any sane man would know...\r\n\r\n" +
                    "[Well that was awkward ending achieved]");
                System.Environment.Exit(0);
            }

        }
    }
}
