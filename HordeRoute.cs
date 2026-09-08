using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class HordeRoute
    {
        private string _mercy;
        public void HordePath()
        {
            Console.WriteLine("");
            _mercy = Console.ReadLine();
            if(_mercy == "Mercy")

            //story


            //summon sum things here

            if(PlayerStatus.Dmg > 40)
            {

                Console.WriteLine("You arrive at a dead end... sadly your caveman brain couldn't see this comming... but hey at least you managed to hold a multitude of carcases in one han- wait don't \r\n" +
                    "just throw them all at the wall you stuppid baraberian!!! Wait w-w-why is that WORKING?!?!?! WASN'T THIS SUPPSOED TO BE A HIGH SECURITY FACILITY what are these walls made out off? PAPER?!!??!" +
                    " \r\n...Anywho you S O M E H O W managed to break through with sheer brute force... despite it going against every law of nature \r\n\r\n" +
                    "[labomtamized caveman ending achieved]");
                System.Environment.Exit(0);
            }

            else
            {
                Console.WriteLine("You arrived at a dead end... you walk to the wall and throw your weapon agaisnt it... it bounced back into your head... nothing important was harmed\r\n\r\n" +
                    "[Well that was awkward ending achieved]");
                System.Environment.Exit(0);
            }

        }
    }
}
