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
                    _bool1 = false;
                    decision = Console.ReadLine();

                }
                if (decision == "a" || decision == "A")
                {
                    _looping = false;

                    _bool1 = true;

                    
                    Console.ReadLine();
                    
                }
                if (decision == "b" || decision == "B")
                {
                    _looping = false;

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

        public bool Bool1(bool bool1)
        {
            return _bool1;
        }
        

        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("2 choices 3 endings... [For those that will live and for those that have fallen], [Human sacrifice] or [Grandmaster of war]\r\n");
        }
    }
}

