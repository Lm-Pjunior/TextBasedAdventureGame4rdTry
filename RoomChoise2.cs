using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class RoomChoise2 : ChooseDecision
    {
        private bool _looping = true;
        //A is about the security room witht he friendship thing going on
        public override void Decisions()
        {
            while (_looping)
            {
                Console.WriteLine("After you make your back to the instructor you suddenly hear the alarms go off and the lights go out... the generator has been destroyed. The instructor organises the cadets and tells you\r\n" +
                    "to take some supplies and assist the guards... where will you go?\r\n\r\n" +
                    "A. Generator.\r\n" +
                    "B. Security room\r\n");

                decision = Console.ReadLine();
                if (decision == "a" || decision == "A")
                {
                    _looping = false;
                    //instantiate generator run
                }

                if (decision == "b" || decision == "B")
                {
                    _looping = false;
                    //instantiate securityroom run
                }
            }
            
        }







        public void ClearText()
        {
            base.ClearFunction();
        }

    }
    }
