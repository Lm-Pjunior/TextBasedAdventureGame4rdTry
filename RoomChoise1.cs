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
        //decision A results in a bullet through the head
        //choise C in getting fired
        private StoryLine _story = new StoryLine();
        public override void Decisions()
        {
            while (_looping) {
                {
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
                      _looping = false;
                      //instatiate storyline


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
                    _looping = false;
                    //instatiate storyline

                    }
                    if(decision == "paths" ||  decision == "Paths")
                {
                    ShowPaths();
                }
                }
      }
      
        
        public override bool SendBool1(string decision)
        {

            if (decision == "b" || decision == "B")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override bool SendBool2(string decision)
        {
            if (decision == "d" || decision == "D")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("The 2 endings obtainable here are: [Mercy kill] and [Fired]");
        }


        /*
    Decisions
     {
     Console.WriteLine(des1);
     Console.WriteLine(des2);
     if (des3 != null)
     {
         Console.WriteLine(des3);
     }
     if (des4 != null)
     {
         Console.WriteLine(des4);
     }
    deciding = Console.ReadLine();
    if(deciding == "a" || deciding == "A")
     {
         Console.WriteLine("");
     }
 }
 */
    }


}
