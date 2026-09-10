using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    
    public class SecurityRoomSubChoice2 : ChooseDecision
    {
        private FaceSlug _slug = new FaceSlug("FaceSlug",

            "It's hideous abomination whoms exterior is made out of thousands of shriveled up human faces," +
            " its liquid guts made out of pulverized flesh and organs and wherever it goes it leaves a trail of oil and pus...\r\n" +
            " It among the slower abominations of this facility but it can take quite the hit",

            "that overgrown slug spits its slime over the enemy" +
            " and than throws up his eternal organs over him wich also have an adhesive agent and as my soldiers were rendered immobile...\r\n" +
            " then it came over and swallowed them whole crushing them within its body and growing even more");

        private TwistedOne _twisted = new TwistedOne("Twisted Ones"

            , "A creature that vaguely resembles a duckling, yellowe feathers stained in red, twisted legs and a twisted neck... a monstosity that is cursed to look downwards.\r\n" +
             "It has 2 beaks one on his face and the other on his cheek... it has a lot of needle like teeth and a long tongue with multiple tendrils on it...\r\n" +
            "It has 3 legs 2 of wich a large, twisted with some of its toes broken with the bone sticking out. The other leg is underdeveloped and cannot be used."

            , " The twisted Ones only have 2 things going for them and that's their numbers and vitality since they have high regeneration... which brings them endless agony.\r\n" +
            "They only die when their undeveloped leg is pulled off of their torso, this results in their guts spilling and their lives slipping.\r\n   " +
            "From there on you only need to crush their skull with the exo-skeleton, we put them out of their misery but one of exo skeletons got damaged in the proccess...\r\n" +
            "it would be best to get some repairs done to our weapons");

        
        public override void Decisions()
        {
            RoomChoise1 choise1 = new RoomChoise1();
            if (PlayerStatus.Friend)
            {
                while (true)
                {
                    Console.WriteLine("You decide to catch up with your friend afterall he's currently the 3rd most trustworthy person here, ofcourse the one you trust most is yourself.\r\n" +
                        "And this is a good oppertunnity to gather general information about the current situation and as you expected the situation is grim to say the least.\r\n" +
                        "The guards are running a bit low on ammunition and have sustained minor injuries aswell as some mayor ones whom are currently sleeping in the corner\r\n" +
                        "whilst having their bandages switched... their goes your medical supplies but in turn you gained a moral bargaining chip afterall\r\n" +
                        "they're rather gratefull. So in the end it's a good bargain. But the current situation is still grim even with your pawns it'll be hard to survive this\r\n" +
                        "not even mentioning solving this... so what will you do?\r\n\r\n" +
                        "A. Going on the offesnive and face the odds.\r\n" +
                        "B. Prioritise supplies and survivability.\r\n");

                        _decision = Console.ReadLine();

                    
                    if (_decision == "a" || _decision == "A")
                    {
                        Console.ReadLine();
                        StoryLine();
                        break;
                    }
                    if (_decision == "b" || _decision == "B")
                    {
                        Console.ReadLine();
                        StoryLineSec();
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
            else
            {
                StoryLineBad();
            }
        }





        public void ClearText()
        {
            base.ClearFunction();
        }

        public override void ShowPaths()
        {
            Console.WriteLine("2 choices 3 endings... [For those that will live and for those that have fallen], [Human sacrifice] or [Grandmaster of war]\r\n");
        }

        public override void StoryLine()
        {
            Console.WriteLine("You and the guys prepare yourself... it's time for a slaughter and the ones on the chopping blcok are those grotesque creatures.\r\n" +
                            "You take the lead and search for The Stalker's nest... you pass by the medical bay and you feel it, it's here.\r\n" +
                            "The beast dargs away your men, one. by. one. no fight nor gunshot the only thing left is a scream echoing in the distance.\r\n" +
                            "You gather your pawns... No, your brothers and go towards the sounds of the fallen. Only to be met with the scene of death... that twisted beast hadn't eaten one\r\n" +
                            "of them... he hanged them on the walls or sadisticly torn them limb for limb... It was toying with you and wanted to drown you in despair before eating you\r\n" +
                            "so... it gave you a gift... soem of your brothers... weren't graced by death their bodies had been thrown into fires and their wounds cauterized... they were alive\r\n" +
                            "without any limbs. They served the beast one purpose and one purpose alone... instilling despair on your remaining brothers. It would dig into their flesh to make\r\n" +
                            "them scream slowely gutting them infront of your eyes... \r\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(
                            "your brothers no longer being able to handle this scene grabbed their guns and started shooting the beast...\r\n" +
                            "It used the corpses and those alive as shields and advanced towards us ccutting us one... by... one many of us lsot our lives.\r\n" +
                            "I grabbed the little explosives we had remaining and put them on my vest...\r\n" +
                            "if weren't going to leave alive than, NEITHER SHALL YOU... The beast went to grab you with its claws makking the leader bleed\r\n" +
                            "before his soldiers eyes... that sadistic tendecy of his shall be its undoing. Standing on your bloodied body you tell your brothers to live a long life...\r\n" +
                            "For your brother's that passed and for your brothers that will life you pull the pin... the ebast releasing this one step to late gets engulfed by the flames of\r\n" +
                            "your wrath... You did it you avenged your brothers that had fallen and fought so the others could live one day longer... and maybe just maybe they can make it out\r\n" +
                            "of this wretched hell...\r\n" +
                            "[For those that will live and for those that have fallen ending ahcieved]");
            System.Environment.Exit(0);
        }

        public override void StoryLineSec()
        {
            //grandmaster of war
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You order your men to gather the weapons and medical supplies, the scouts reported a nearby nest... this news came with the price of a few of your men.\r\n" +
                "With the new equipment you launch a distraction mission to distract the beast as the other group goes out to gather the emdical supplies.\r\n" +
                "You and the rest of the forces go back to help the group that baited the creature... many are harmed... almost dead even... you have some of your soldiers tend\r\n" +
                "to them as you and the forces go after the beast... It lunges wildly at your forces dragging them and slamming them but has grown warry... this beast is a hunter and\r\n" +
                "a cunning one at that realising it's situation it tries to escape. A good thing you had blocked it in advance with a shield unit that carru shotguns. Surrounded by your\r\n" +
                "forces with no escape in sight... a beast once feared now nothing but cornered mice... as any beast in this situation in started to lash out but... all it had was his\r\n" +
                "might jaws, claws and taill... normally a scarry weapon reduced to nothing with the powerfull exo-skeletons and the special shields that the scientist here had created.\r\n" +
                "Truly a pity that no one was stationed there before mayby than... things wouldn't have reached this point... but a pleasant supprise to get my hands on these anyways.\r\n" +
                "Makes one truly wonder how many more secrets are being kept here.\r\n\r\n" +
                "The beast had finished its final struggle... and now all that remained was the stench of blood and dozens of corpses... but a victory nontheless. You decide to further\r\n" +
                "your advances in order to kill many more beasts to come and discover the secrets that this facility holds... and grow your strenght in the process.\r\n\r\n\r\n");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine($"You travel through the hallwaws on search for people and riches but instead...");
            _twisted.CreatureSpawn();
            _twisted.Description();
            _twisted.AttackStory();

            Console.ReadLine();

            _slug.CreatureSpawn();
            _slug.Description();
            _slug.AttackStory();

            Console.WriteLine("A while pass and your forces have grown, your treasures boundless and the knowledge you gained as vast as the seas with this newfound foundation" +
                " you decide to start your own mercenary corps\r\n" +
                "goign through battles with your men aswell as having the old researchers help you find newer knowledge, you are however on the run for those that had caused this.\r\n" +
                "But those fools have little going for them as you and your men easily deal with the enemy...\r\n" +
                "[Grandmaster Of War ending achieved]");
            System.Environment.Exit(0);

        }
        public void StoryLineBad()
        {
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("He makes his way over \"Well, guess you're still alive\" he says in an annoyed tone, you look at him and just walk away. He's of no use a liability even.\r\n" +
                        "The atmosphere is a bit tense quite a few people seem wary of you... guess they're his friends. While others seem to be somewhat on your side \r\n" +
                        "after seeing your achievement. It's getting late and you decide to go on guard duty togheter with the guard that you've saved before.\r\n" +
                        "You're in front of the door once more in a tattered hallway with debry evrywhere accompanied with the thick scent of blood.\r\n" +
                        "Nothing much is happening and you decide to talk with the guard for a while, sadly your leisure conversation got interupted and you get attacked.\r\n" +
                        "A creature dupped The Stalker as the beast lunges toward you with its razor sharp claws you hurriedly grab you rifle,\r\n" +
                        "only to watch it get split in two... his claws tear your flesh... but you're alive the rifle absorbed most of the momentum. You grab you pistol that\r\n" +
                        "was conveniently in sight so you *borrowed* your old roommate's pistol. You aim the pistol... The Stalker moves around fast, luckily your pawn starts\r\n" +
                        "distracting the creature by shooting its shoulder blades. The creature changes it's targets and turn around going for the guard you once saved.\r\n" +
                        "you run to the the creature's right side practically hugging the broken wall and you start aiming at its wounded shoulderblade. The beast swing its tail\r\n" +
                        "at the guard smashing him agaisnt the walls and going after you again. The creature goes after you and you plan to dodge so it'll impale its head on the\r\n" +
                        "metal sticking out of the debri once called a wall. The beast runs towards you with devestating killing intent and you shoot at ists eyes trying to \r\n" +
                        "blind it... however unlike your plan it decides to grab you with its tail and throw you towards the guard... your condition is... bad, your leg took\r\n" +
                        "the brunt of the impact shattering in the process and now the beast run towards you... you grab the guard's gun, shot him in his leg\r\n" +
                        "and threw him towards the beast... killing him.\r\n");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine(           
                        "You grab *your* rifle and start going for the eyes once more... but the beast decided to just leave with its new snack rapped with its tail... you survived\r\n" +
                        "but at what costs? You look behind you and see your old roommate and his mates... guess that's that for your social life.\r\n" +
                        "With heavy steps you return to the temporary base, with a heavy atmosphere those that once admired you now being the once that hate you most.\r\n" +
                        "You serve the group no more purpose... besides one, your presence is demoralizing so you're cast away they cannot trust someone like you that regards people\r\n" +
                        "as nothing mere pawns.\r\n" +
                        "You're tied up and forc ed to walk on the front, going to certain death at the beast's lair...\r\n" +
                        " death did not come swiftly... nor was your death grand you were\r\n" +
                        "small and ignificant those that captured you failed and fled the scene as your bones and flesh bided them time...\r\n" +
                        " ultimatly all you accomplished was just being the toy\r\n" +
                        "of this sadistic beast that enjoyed your every agony... eventualy there was nothing left of you as it had stripped your skin lair after lair, \r\n" +
                        "broken your bones and fingers... cracked your ribs and singed your flesh... your life is now nothing but pain...\r\n" +
                        "you were used as a pawn on the playing board you tought you controlled. \r\n" +
                        "[Human sacrifice ending achieved]");
            System.Environment.Exit(0);
        }
    }
}

