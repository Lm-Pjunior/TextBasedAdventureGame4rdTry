using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class SecurityRoomSubChoise1 : ChooseDecision
    {

        public override void Decisions()
        {
            while (true)
            {
                {
                    Console.WriteLine("One of those THINGS that wrecked the walls, its deafening wails echo through the hallway... you can't help but shivver what do you do...?\r\n" +
                        "A. Fuck this shit I'm out!\r\n" +
                        "B. Observe and wait for an oppertunnity?\r\n\r\n");
                    _decision = Console.ReadLine();

                }
                if (_decision == "a" || _decision == "A")
                {
                    

                    Console.WriteLine("Press 'enter' to continue\r\n");
                    Console.ReadLine();
                    StoryLine();
                }
                if (_decision == "b" || _decision == "B")
                {

                    Console.WriteLine("Press 'enter' to continue\r\n");
                    Console.ReadLine();
                    StoryLineSec();
                    SecurityRoomSubChoice2 securityRoomSubChoice2 = new SecurityRoomSubChoice2();
                    securityRoomSubChoice2.Decisions();
                    break;

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


        
        

        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("one choice leads to life but by the other path... [Death is a mercy] \r\n" +
                " be sure to doubt and distrust and you will get to the right ending for yourself\r\n");
        }

        public override void StoryLine()
        {
            Console.WriteLine($"You decide to make a run for it and go in the opposite direction of the beast, back to the medicalbay we go!\r\n" +
                            "You run through the hallway huffing and puffing. Yet you have an omminous feeling of being watched, by every step your doubts grow... what is it?\r\n" +
                            "What is following me? But... you made it, you're at the medicalbay. At last, freedom from this accursed feeling...\r\n" +
                            "As time went on, you grew hungry and scared... is it still there? what, WHAT is this feeling gnawing at the back of my head...");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("W H A T  D O  I  D O . . .\r\n\r\n");
            Console.ReadLine();
            Console.WriteLine("Your sanity is leaving you, you're out of food, sleep deprived and paranoid... you hallucinate and your world is anything but desirable.\r\n" +
                "A creature known as The Stalker that does not tire and does not need to eat has been with you, toying with you and your tired soul.\r\n" +
                "It had noticed your heavy footsteps near its lair... you shouldn't have ran...\r\n" +
                "you should've stayed and saved the man... but alas, you didn't and now... you die\r\n" +
                "because of it. \r\n" +
                "[Death is a mercy ending achieved]");
            System.Environment.Exit(0);
        }

        public override void StoryLineSec()
        {
            Console.WriteLine("As you wait you hear gunshots in the distance, a lot of gunshots it HAS to be a squad makking their way...\r\n" +
                "So you make your way to the guard and come to his rescue as you open the firstaid kit\r\n" +
                "the fallen guard's eyes go to the mysterious stim grabbing the chance you ask what it is, he explains that it is classified infomation\r\n" +
                "of this facility so he cannot disclose it, so... you ask if he doesn't want it than? afterall can't use something with the possebility of turning \r\n" +
                "you into one of THOSE abominations that are slowely makking their way to us RIGHT NOW... the guard getting your point immediatly says that \r\n" +
                "there is no need for worry for the stimulant is not one to carry such risks. It does however regenerate lost limbs...\r\n" +
                "this miracle medicne is one of the byproducts of the research done here.\r\n" +
                "And just the thing this man needs, as his hand is gone his arm wounded and his legs... eaten. \r\n" +
                "Sadly the guard can no longer stay conscious due to all the blood he lsot, hell it's a wonder he's even ALIVE. Without a doubt he'll make a fine pawn.\r\n" +
                "But... how close was the monster again? Might've been smarter to keep better track of it but you got far too immersed into the guard's story\r\n" +
                "that you actualy forgot about that behemoth of a beast. You turn around and... to no supprise make eye contact with it. You immediatly grab the\r\n" +
                "guard's gun and start blasting at its eyes the giant beast blocks its own face with it's large grotesque arms and comes closer whilst being truly \r\n" +
                "pissed off at you. It lets out a thunderous roar and starts sprinting. Will you end up like the guard next to you? Or will you survive long enough for\r\n" +
                "the other guards to appear...\r\n");
            Console.ReadLine();
            Console.WriteLine("\r\nThe beast LUNGES at you from meters far willing to make you its snack. You roll to the side and shoot the beast's neck wounding the damn thing,\r\n" +
            "the beast now blinded by rage just simply runs at you disregardng its defences and runs at you solely to kill.\r\n" +
            "You steady your breathing and take aim... you shoot the beast's left eye, the one that seemed weakest with all the scars that it had sustained.\r\n" +
            "This action was your saving grace as the beast fell down sliding over the broken floor hitting you against the wall. Had you been any slower\r\n" +
            "you'd be decorating the place with your blood and organs. The guards sprinting towards the sounds of battle have arrived... sure took their damn time.\r\n" +
            "You call over to them and they help you out. You give them the stimulant to save your newfound pawn. The guards hurry over and save the guard and you?\r\n" +
            "Well, you take a much deserved rest.\r\n" +
            "...You slowely open your eyes as you wake up to the noise that the security guards are makking. You look around you to an unfamiliar place...\r\n" +
            "At this moment the person that you saved comes to thank you for what you did for him after hearing the explenation of the other guards. And another\r\n" +
            "person comes over... It's your roommate from the other day.\r\n");
            Console.ReadLine();
        }
    }
}
