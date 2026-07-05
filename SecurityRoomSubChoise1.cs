using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class SecurityRoomSubChoise1 : ChooseDecision
    {
        private string _decision;
        private bool _bool1 = false;

        private bool _looping = true;
        public override void Decisions()
        {
            while (_looping)
            {
                {
                    _bool1 = false;
                    Console.WriteLine(" there. One of those THINGS that wrecked the walls, its deafening wails echo through the hallway... you can't help but shivver what do you do...?\r\n" +
                        "A. Fuck this shit I'm out!\r\n" +
                        "B. Observe and wait for an oppertunnity?\r\n\r\n");
                    _decision = Console.ReadLine();

                }
                if (_decision == "a" || _decision == "A")
                {
                    _looping = false;

                    _bool1 = true;
                    Console.WriteLine("Press 'enter' to continue\r\n");
                    Console.ReadLine();
                    //_storyLine.SecurityRoomCoward();
                }
                if (_decision == "b" || _decision == "B")
                {
                    _looping = false;

                    Console.WriteLine("Press 'enter' to continue\r\n");
                    Console.ReadLine();
                    //_storyLine.SecurityRoomPawnMaster();


                }


                if (_decision == "paths" || _decision == "Paths" || _decision == "route" || _decision == "Route")
                {
                    ShowPaths();
                }
                if (_decision == "clear" || _decision == "Clear")
                {
                    ClearText();
                }
            }
        }


        public bool Bool1(bool bool1)
        {
            _bool1 = bool1;
            return _bool1;
        }
        

        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("one choice leads to life but by the other path... [Death is a mercy] \r\n" +
                " be sure to doubt and distrust and you will get to the right ending for yourself\r\n");
        }
    }
}
