using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public class RoomChoise2 : ChooseDecision
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
                    "B. Security room\r\n" +
                    "C. Into the horde\r\n\r\n" +
                    "Type down you choice... 'A', 'B' or 'C'\r\n" +
                    "You can also type down clear to 'clear' the texts or 'paths' to show possible endings within the choices\r\n");

                _decision = Console.ReadLine();
                if (_decision == "a" || _decision == "A")
                {
                    StoryLine();
                    break;
                }

                if (_decision == "b" || _decision == "B")
                {
                    StoryLineSec();
                    SecurityRoomSubChoise1 securityRoomSubChoise1 = new SecurityRoomSubChoise1();
                    securityRoomSubChoise1.Decisions();
                    break;
                }

                if (_decision == "c" || _decision == "C")
                {
                    HordeRoute painPath = new HordeRoute();
                    painPath.HordePath();
                    //instantiate the path to to monster horde here

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
                Console.WriteLine("\r\n\r\n\r\n)");
            }
            
        }
        

        
        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("Only 1 choice leads to more whilst the other is a [Suicidal mission]... altough your end depends on what you've chosen\r\n");
        }

        public override void StoryLine()
        {
            //Generator

            Console.WriteLine("You decided that the power is a neccesity as you make your way to the generator... each step you take brings you closer but so does\r\n" +
               "a strange punget smell.\r\n\r\n " +
               "It didn't take long for you to notice what this smell was, as you now stand in it, the flesh of your colleages sticking to your boots.\r\n" +
               "You're not sure about how many died here but you make a rough estimate, mayby about 15 men. You can't diffrentiate between whoms who.\r\n" +
               "The scene is quite something... these people were torn apart and scattered across the hallway. You hold back the urge to throw up and\r\n" +
               "head to the generator... but you see soemthing glistering in the corner of your eye... you turn your head out of curiosity and see the\r\n" +
               "guard captain's security pass. He's wounded the most of the bunch, only an arm is intact and a half eaten torso remains, guts spilling out\r\n" +
               "and his head is slashed clean off with only the lower jaw remaining, the tongue sticking out and his blood staining the walls.\r\n" +
               "You scalvage what you can of the corpses, afterall it is dangerous right now and a proper weapon is what you need. You take one\r\n" +
               "of the security team's empty rifles and search for some ammo praying that whatever did this can be killed and hasn't eaten the ammo.\r\n" +
               "You go from corpse to corpse yet you find nothing else but the pass, a broken shield and the rifle but you decide to leave the rifle\r\n" +
               "alone for now, as you need ammo for it taking it with you now will only hinder your movement. Only 3 corpses left to search.\r\n\r\n" +
               "You make your way to the next corpse and grab its tattered jacket in order to search its contents as there is no belt or lower body to mention.\r\n" +
               "As you put your hand in the pocket you get attacked, in a hurry you turn around.");

            Console.ReadLine();
            if (PlayerStatus.Armed) 
                //Unlike NORMALLY static is the special kid of the bunch... sso instead of makking your usual instatiation you have to actualy put the class name infront of it.
            {
                Console.WriteLine(" You grab your batton and swing before you even lay eyes upon your newfound foe... \r\n" +
                    "you miss as your dumbass didn't look at how big the thing is that attacked you.\r\n" +
                    "It's a long centipede like creature with the arms of a human as it's legs and an oversized dog's head, it's fangs piercing your flesh and\r\n" +
                    "breaking bone it wrstles you to the ground. You grab the broken shield that you got from the corpses and block its mouth you go for another swing\r\n" +
                    "with your not so trust worthy wand and hit the thing on its head. THe beast lets out a cry slightly opening it's mouth... you take this opetunity\r\n" +
                    "and jam the broken shield in his mouth. The sharp edges of the broken shield damage the creature's mouth and you push it further in it's flesh\r\n" +
                    "the creature starts lifting you up and throws itself and you to the wall breaking your ribs in the procces, you let out a grunt and thrust your\r\n" +
                    "baton into it's eye. You hit the switch and electoructe the unholy abomination. You push it further into it's eye and \r\n" +
                    "twist it as much as you can to gauge out his eyes. The creature cries out and let's go running away from you, \r\n" +
                    "you won but at what costs? your ribs broken and your spine in pain, you continue to scalvage the supplies of the 2 remaining corpses. \r\n" +
                    "You wonder how long you'll have and if you can even make it... you finnally found the ammo and you go back to the rifle and take it with you.\r\n" +
                    "You continue with your suicidal journey to the generators...\r\n\r\n" +
                    "You have arrived at the generator, you're in luck as the door has been torn off by something, you walk forward temporarely using your new weapon\r\n" +
                    "as a crutch, not the smartest option but you couldn't find anythign else, and you DID NOT want to fight whatever the fuck that THING was from\r\n" +
                    "before, so you decided to go as fast as your tattered leg allowed you. \r\n\r\n" +
                    "You entered the generator room and once again, you're met with corpses. This time it's the corpses on the workers so you grab their pass in order\r\n" +
                    "to activate the generators, but you time is nigh, you've lost a lot of blood from your leg and the internal injuries that happened during your \r\n" +
                    "fight with that damned beast. As you activate the generator it starts blaring so you hurridly sit on the floor and lean against the generator,\r\n" +
                    "taking aim with your rifle, the broken shield on your arm and the batoon on the floor nicely within reach... as you had guessed it came back.\r\n" +
                    "With some friends, very ugly friends but now you're ready. You shoot the centipede like through the injury you had left him to finish the job\r\n" +
                    "and immediatly go for the next beast, this one was more wolf like with tendrils sticking out of it's eyes.\r\n" +
                    "It let's out a human scream as it runs to you, once more you take aim, and shoot it its mouth, the first bullet pained it and the second for it's\r\n" +
                    "leg as it stumbles infront of you use your trusty shield and smack it against it's head. you place the rifle on this beast and fire at the next \r\n" +
                    "beast wich was... an oversized slug made out of skin and bone. It had a portruding spine of bones and a body made out of the skin of many\r\n" +
                    "it's belly was by far the grosest thing you've ever seen as it was made out of a thousand faces. Sadly you didn't have time to throw up so\r\n" +
                    "you grab you baton and wail on the wolf like creature and zapping it as much as you can, keeping it down... its tentacles attacking you and you\r\n" +
                    "blocking it with the shield, and using the baton to electrocute it whenever whilst that slow ass slug came on over... slowely but surely.\r\n" +
                    "You shoot at it with all you have whislt defending against the wolf that is now starting to stand up. Sadly... this is your end but hey,\r\n" +
                    "you activated the generator. [Suicidal mission ending achieved]");
                System.Environment.Exit(0);
            }
            if (PlayerStatus.Armed == false) {
                {
                    Console.WriteLine("The centipe like beast bites into your ankle crushing bone and tearing flesh, you quikly turn around and use the broken shield that is mounted to\r\n" +
                        "your arm, all you can do is delay the beast... you cry for help but no avail. Your shield can't hld out for long under the beast's attacks and is\r\n" +
                        "starting to crack, the beast takking the oppertunity bites a chunk out of the shield and throws you to the ground. pinning you down with a hundred\r\n" +
                        "hands. this is the end of your story, food for a beast if only you had found the ammo for the rifle or had a weapon to hold it off...\r\n" +
                        "[Dogfood ending achieved]");
                }
            }
            System.Environment.Exit(0);
        }

        public override void StoryLineSec()
        {
            Console.WriteLine("You make your way to the security but your path has been blocked, the doors closed and the walls shatterd.\r\n" +
                 "You walk around these ruins once called a corridor in order to find a path towards the security room...\r\n" +
                 "After a long while you stumble upon a locked door near the medicalbay maybe you could find someone there with an acces key, and thus \r\n" +
                 "you made your way towards the medicalbay...\r\n" +
                 "The first thing you did was ofcourse scavenge for supplies, afterall you're unarmed.\r\n" +
                 "You take 2 medkits with you but they hold some unfamiliar medical supploes... it has to be something good afterall this place has some serious tech.\r\n" +
                 "You sadly didn't find any keycards but decide to go onwards anyways... maybe you'll have better luck by the next desitantion.\r\n\r\n   " +
                 "You walk through the hallways once more navigating with the map that the instructor had given you. Albeit not as functional due to the rampage \r\n" +
                 "that went through these hallways... after a while you start hearing a voice, are you finally going insane from all the mental fatigue? Or is there actualy\r\n" +
                 "something there, " +
                 "The voice starts calling for help you also hear him grunt and you wonder if you should help but the screams for help weren't the only thing there.\r\n");
        }
    }
    }
