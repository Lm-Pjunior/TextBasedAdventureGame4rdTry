using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class SecurityRoomSubChoise1 : ChooseDecision
    {
        private bool _looping = true;
        public override void Decisions()
        {
            while (_looping)
            {
                {
                    Console.WriteLine(" there. One of those THINGS that wrecked the walls, its deafening wails echo through the hallway... you can't help but shivver what do you do...?");
                    decision = Console.ReadLine();

                }
                if (decision == "a" || decision == "A")
                {
                    


                    _looping = false;
                    Console.ReadLine();
                    _storyLine.SecurityRoomCoward();
                }
                if (decision == "b" || decision == "B")
                {
                    Console.WriteLine("");

                    _looping = false;
                    Console.ReadLine();
                    _storyLine.SecurityRoomPawnMaster();


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
            Console.WriteLine("one choice leads to life but by the other path... [Death is a mercy] \r\n" +
                " be sure to doubt and distrust and you will get to the right ending for yourself");
        }
    }
}
