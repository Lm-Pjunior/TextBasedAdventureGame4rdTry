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
                    decision = Console.ReadLine();

                }
                if (decision == "a" || decision == "A")
                {
                    Console.WriteLine("");


                    _looping = false;
                    Console.ReadLine();
                }
                if (decision == "b" || decision == "B")
                {
                    Console.WriteLine("");

                    _looping = false;
                    Console.ReadLine();


                }


                if (decision == "c" || decision == "C")
                {
                    Console.WriteLine("");


                    _looping = false;
                    Console.ReadLine();

                }
                if (decision == "paths" || decision == "Paths")
                {
                    ShowPaths();
                }
            }
        }
    


        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("");
        }
    }
}
