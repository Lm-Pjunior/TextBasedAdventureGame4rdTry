using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class RoomChoise1 : ChooseDecision
    {
        // friend = false; // choise B
        // baton = false; //choise D

        private bool _looping = true;
        private bool _looping2 = true;
        private bool _friend = false;
        private bool _zappingStick = false;
        //decision A results in a bullet through the head
        //choise C in getting fired
        public override void Decisions()
        {
            while (_looping) {
                {
                    Console.WriteLine("The instructor hands you a map so you can find your way around the facility evrything is marked but you don't have acces to basicly anything.\r\n" +
                        "Where will you go?\r\n" +
                        "A. The shooting range\r\n" +
                        "B. The logings \r\n" +
                        "C. Outside the facility\r\n" +
                        "D. The armory\r\n\r\n" +
                        "Type down you choice... 'A', 'B', 'C' or 'D'\r\n" +
                        "You can also type down clear to 'clear' the texts or 'paths' to show possible endings within the choices\r\n");
                    decision = Console.ReadLine();
                    
                    }
                    if (decision == "a" || decision == "A")
                    {
                        Console.WriteLine("You're bored and decide to check out the shooting range, ignoring the warning the instructor gave you. Wow... you died");
                        Console.WriteLine("but hey this propably was natural selection as you couldn't followe such BASIC commands.");
                        Console.WriteLine("Your corpse lays on the ground with brain tissue lying all over the floor. ");
                        Console.WriteLine("the sight is as unsightly as your intelligence...");
                        Console.WriteLine("[Mercy kill ending achieved]\r\n");
                        Console.WriteLine("Press 'enter' to continue.");
                        Console.ReadLine();
                   
                        _looping = false;

                }
                if (decision == "b" || decision == "B")
                {

                    while (_looping2)
                    {
                        Console.WriteLine("You decide to go to the logings in advance.\r\n" +
                            "Afterall it might be nice to see the place you'll be staying at for a while.\r\n" +
                            "You enter the room and meet your new roommate but how will you greet him:\r\n" +
                            "A. Uppercut to the face.\r\n" +
                            "B. Demand to at the top of the bunkbed!" +
                            "Type down you choice... 'A', 'B', 'C' or 'D'\r\n" +
                            "You can also type down clear to 'clear' the texts or 'paths' to show possible endings within the choices\r\n");

                        decision = Console.ReadLine();
                    }
                        if(decision == "a" || decision == "A")
                      {
                           Console.WriteLine("You uppercut him hard enough to shatter a bit of his teeth... his dentist won't be happy and nor will he...\r\n" +
                              "You have made your first enemy within this facility... happy now?");

                        _looping2 = false;
                        _looping = false;
                    }
                        if(decision == "b" || decision == "B")
                    {
                        Console.WriteLine("You expected a fight to the death but he was supprisingly glad... and he explains how the lower bunk is supperious\r\n" +
                            "and thus begins the fight you were expecting... it was a truly stoic fight... of words, it was an argument... again.\r\n" +
                            "But at the end of the day you gained a friend... your first friend within this facility... and maybe your last ofcourse this is something only we know.");

                        _friend = true;
                        _looping2 = false;
                        _looping = false;
                        //_storyLine.AlarmBit();
                    }
                    if (decision == "paths" || decision == "Paths")
                    {
                        ShowPaths();
                    }
                    if (decision == "clear" || decision == "Clear")
                    {
                        ClearText();
                    }
                }
                          

                if (decision == "c" || decision == "C")
                    {
                        Console.WriteLine("You decided that working for a staggering 296 seconds was more than plenty... so you decide to go home");
                        Console.WriteLine("this ofcourse gets you fired so hard you'll be flipping burgers for the rest of your life but hey...");
                        Console.WriteLine(" atleast YOU'RE alive...");
                        Console.WriteLine("[Fired ending achieved]");
                        Console.WriteLine("");
                        Console.WriteLine("Press 'enter' to continue.");
                        Console.ReadLine();

                        _looping = false;

                    }
                    if (decision == "d" || decision == "D")
                    {

                    Console.WriteLine("You went to the armory and got handed... a baton... you expected more to say the least...");
                    _zappingStick = true;
                    _looping = false;
                    //_storyLine.AlarmBit();


                }
                    if(decision == "paths" ||  decision == "Paths" || decision == "route" || decision == "Route")
                {
                    ShowPaths();
                }
                    if(decision == "clear" || decision == "Clear")
                {
                    ClearText();
                }
                }
      }
      
        
        public override bool SendBool1(bool friend)
        {

            return _friend;
        }
        public override bool SendBool2(bool weapon)
        {
            return _zappingStick;
        }

        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("The 2 choices [Mercy kill] and [Fired] and the other 2 might save ones life... depending on what you do ofcourse");
        }


        
    }


}
