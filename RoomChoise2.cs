using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class RoomChoise2 : ChooseDecision
    {
        private bool _looping = true;



        private string _decision;
        private bool _bool1 = false;
        //A is about the security room witht he friendship thing going on
        public override void Decisions()
        {
            

            while (_looping)
            {
                _bool1 = false;
                Console.WriteLine("After you make your back to the instructor you suddenly hear the alarms go off and the lights go out... the generator has been destroyed. The instructor organises the cadets and tells you\r\n" +
                    "to take some supplies and assist the guards... where will you go?\r\n\r\n" +
                    "A. Generator.\r\n" +
                    "B. Security room\r\n\r\n" +
                    "Type down you choice... 'A' or 'B'\r\n" +
                    "You can also type down clear to 'clear' the texts or 'paths' to show possible endings within the choices\r\n");

                _decision = Console.ReadLine();
                if (_decision == "a" || _decision == "A")
                {

                    _bool1 = true;

                    _looping = false;
                }

                if (_decision == "b" || _decision == "B")
                {

                    _looping = false;
                }
                if(_decision == "paths" || _decision == "Paths" || _decision == "route" || _decision == "Route")
                {
                    ShowPaths();
                }
                if (_decision == "clear" || _decision == "Clear")
                {
                    ClearText();
                }
                Console.WriteLine("\r\n\r\n\r\n)");
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
            Console.WriteLine("Only 1 choice leads to more whilst the other is a [Suicidal mission]... altough your end depends on what you've chosen\r\n");
        }
    }
    }
