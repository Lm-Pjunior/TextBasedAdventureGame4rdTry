using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class SecurityRoomSubChoice2 : ChooseDecision
    {
        private bool _looping = true;
        public override void Decisions()
        {
            while (_looping)
            {
                {
                    decision = Console.ReadLine();

                }
                if (decision == "a" || decision == "A")
                {
                    _looping = false;
                    _storyLine.HeroicSacrifice();
                    
                    Console.ReadLine();
                    
                }
                if (decision == "b" || decision == "B")
                {
                    _looping = false;
                    _storyLine.GrandmasterOfWar();

                    Console.ReadLine();

                }


                if (decision == "paths" || decision == "Paths" || decision == "route" || decision == "Route")
                {
                    ShowPaths();
                }
                if (decision == "clear" || decision == "Clear")
                {
                    ClearText();
                }
            }
        }


        

        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("2 choices 3 endings... [For those that will live and for those that have fallen], [Human sacrifice] or [Grandmaster of war]");
        }
    }
}

