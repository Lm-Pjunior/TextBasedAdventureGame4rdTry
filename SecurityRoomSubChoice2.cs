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

        private string _decision;
        private bool _bool1 = false;
        public override void Decisions()
        {
            while (_looping)
            {
                {
                    _bool1 = false;
                    _decision = Console.ReadLine();

                }
                if (_decision == "a" || _decision == "A")
                {
                    _looping = false;

                    _bool1 = true;

                    
                    Console.ReadLine();
                    
                }
                if (_decision == "b" || _decision == "B")
                {
                    _looping = false;

                    Console.ReadLine();

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
            Console.WriteLine("2 choices 3 endings... [For those that will live and for those that have fallen], [Human sacrifice] or [Grandmaster of war]\r\n");
        }
    }
}

