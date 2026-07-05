using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public abstract class ChooseDecision
    {
        private string _decision;
        private bool _bool1 = false;

        
        public abstract void Decisions();
       

       
        protected void ClearFunction()
        {
            if (_decision == "clear" || _decision == "Clear" || _decision == "CLEAR")
            {
                Console.Clear();
            }
        }

        public abstract void ShowPaths();
        

        public bool SendBool1(bool bool1)
        {            
            return _bool1;
        }

        /*
  Rooms

  OutsideFacility: start of the game
  FacilityEntrance: some info gets spit out you talk to an officer -> room choise

  //The examiner tells you to explore, but beware of the shooting range as they're currently practicing.

 room choise 1 (the saving grace)
  {
  A. TrainingFacility:
  you get shot in the head. 
  [Mercy kill ending achieved]

  B. Lodgings:
  You meet a fella that you can befriend... or get punched by 
    A. The top bunk shall be MINE
    B. This place reeks [dialogue 'cutscene' bool friend = true]


  C. OutsideFacility:
  You decide you've worked enough and make a run for it... you do know you won't get paid for showing up right?
  [Fired ending achieved]



  D. Armory:
  You go to the armory to collect your equipment... a slick suit and a zapping stick.
  //this activates a boolean
  }

  [Shit goes bad phase]
  //Monsters breached their containment

 Roomchoise 2 [storyline decision]



  A. SecurityRoom: (friendship)
  You make your way to the security room but your path has been blocked, the doors closed and the walls shatterd.
  You walk around these ruins once called a corridor in order to find a path towards the security room...
  After a long while you stumble upon a locked door near the medicalbay, maybe you could find someone there with an acces key, and thus 
  you made your way towards the medicalbay...
  The first thing you did was ofcourse scavenge for supplies, afterall you're unarmed.
  You take 2 medkits with you but they hold some unfamiliar medical supplies... it has to be something good afterall this place has some serious tech.
  You sadly didn't find any keycards but decide to go onwards anyways... maybe you'll have better luck by the next desitantion.

  You walk through the hallways once more navigating with the map that the instructor had given you. Albeit not as functional due to the rampage 
  that went through these hallways... after a while you start voices, are you finally going insane from all the mental fatigue? Or is there actualy
  something there, The voice starts calling for help you  also hear him grunt and you wonder if you should help but the screams for help weren't the only thing
  there. One of those THINGS that wrecked the walls, its deafening wails echo through the hallway... you can't help but shivver what do you do...?

       SubChoiseSecurity 1



       B. Fuck this shit I'm out!
       [The coward = true]
           You decide to make a run for it and go in the opposite direction of the beast, back to the medicalbay we go!
           You run through the hallway huffing and puffing. Yet you have an omminous feeling of being watched, by every step your doubts grow... what is it?
            What is following me? But... you made it, you're at the medicalbay. At last, freedom from this accursed feeling...
            As time went on, you grew hungry and scared... is it still there? what, WHAT is this feeling gnawing at the back of my head... 

             W H A T  D O  I  D O . . .

             Your sanity is leaving you, you're out of food, sleep deprived and paranoid... you hallucinate and your world is anything but desirable.
             A creature known as The Stalker that does not tire and does not need to eat has been with you, toying with you and your tired soul.
             It had noticed your heavy footsteps near its lair... you shouldn't have ran... you should've stayed and saved the man... but alas, you didn't and now... you die
             because of it. [Death is a mercy ending achieved]

       C. Observe and wait for an oppertunnity? 
       [Master Of Pawns = true]

          As you wait you hear gunshots in the distance, a lot of gunshots it HAS to be a squad makking their way...
          So you make your way to the guard and come to his rescue as you open the firstaid kit
          the fallen guard's eyes go to the mysterious stim grabbing the chance you ask what it is, he explains that it is one of the classified infomation
          of this facility so he cannot disclose it, so... you ask if he doesn't want it than? afterall can't use something with the possebility of turning 
          you into one of THOSE abominations that are slowely makking their way to us RIGHT NOW... the guard getting your point immediatly says that 
          there is no need for worry for the stimulant is not one to carry such risks. It does however regenerate lost limbs...
          this miracle medicne is one of the byproducts of the research done here.
          And just the thing this man needs, as his hand is gone his arm wounded and his legs... eaten. 
          Sadly the guard can no longer stay conscious due to all the blood he lsot, hell it's a wonder he's even ALIVE. Without a doubt he'll make a fine pawn.
          But... hwo close was the monster again? Might've been smarter to keep better track of it but you got far too immersed into the guard's story
          that you actualy forgor about that behemoth of a beast. You turn around and... to no supprise make eye contact with it. You immediatly grab the
          guard's gun and start blasting at its eyes the giant beast blocks its own face with it's large grotesque arms and comes closer whilst being truly 
          pissed off at you. It lets out a thunderous roar and starts sprinting. Will you end up like the guard next to you? Or will you survive long enough for
          the other guards to appear...
          Console.ReadLine();

          The beast LUNGES at you from meters far willing to make you its snack. You roll to the side and shoot the beast's neck wounding the damn thing,
          the beast now blinded by rage just simply runs at you disregardng its defences and runs at you solely to kill.
          You steady your breathing and take aim... you shoot the beast's left eye, the one that seemed weakest with all the scars that it had sustained.
          This action was your saving grace as the beast fell down sliding over the broken floor hitting you against the wall. Had you been any slower
          you'd be decorating the place with your blood and organs. The guards sprinting towards the sounds of battle have arrived... sure took their damn time.
          You call over to them and they help you out. You give them the stimulant to save your newfound pawn. The guards hurry over and save the guard and you?
          Well, you take a much deserved rest.
          ...You slowely open your eyes as you wake up to the noise that the security guards are makking. You look around you to an unfamiliar place...
          At this moment the person that you saved comes to thank you for what you did for him after hearing the explenation of the other guards. And another
          person comes over... It's your roommate from the other day.
          Console.ReadLine();

          if(friend = true) // you're leader of the group
          {

           You decide to catch up with your friend afterall he's currently the 3rd most trustworthy person here, ofcourse the one you trust most is yourself.
           And this is a good oppertunnity to gather general information about the current situation and as you expected the situation is grim to say the least.
           The guards are running a bit low on ammunition and have sustained minor injuries aswell as some mayor ones whom are currently sleeping in the corner
           whilst having their bandages switched... their goes your medical supplies but in turn you gained a moral bargaining chip afterall
           they're rather gratefull. So in the end it's a good bargain. But the current situation is still grim even with your pawns it'll be hard to survive this
           not even mentioning solving this... so what will you do?

               SubChoiseSecurity 2

               A. Going on the offesnive and face the odds.
               [For those that will live and for those that have fallen ending]

                   You and the guys prepare yourself... it's time for a slaughter and the ones on the chopping blcok are those grotesque creatures.
                   You take the lead and search for The Stalker's nest... you pass by the medicalbay and you feel it, it's here.
                   The beast dargs away your men, one. by. one. no fight nor gunshot the only thing left is a scream echoing in the distance.
                   You gather your pawns... No, your brothers and go towards the sounds of the fallen. Only to be met with the scene of death... that twisted beast hadn't eaten one
                   of them... he hanged them on the walls or sadisticly torn them limb for limb... It was toying with you and wanted to drown you in despair before eating you
                   so... it gave you a gift... soem of your brothers... weren't graced by death their bodies had been thrown into fires and their wounds cauterized... they were alive
                   without any limbs. They served the ebast one purpose and one purpose alone... instilling despair on your remaining brothers. It would dig into their flesh to make
                   them scream slowely gutting them infront of your eyes... 
                   your brothers no longer being able to handle this scene grabbed their guns and started shooting the beast...
                   It used the corpses and those alive as shields and advanced towards us ccutting us one... by... one many of us lsot our lives.
                   I grabbed the little explosives we had remaining and put them on my vest...
                   if weren't going to leave alive than, NEITHER SHALL YOU... The beast went to grab you with its claws makking the leader bleed
                   before his soldiers eyes... that sadistic tendecy of his shall be its undoing. Standing on your bloodied body you tell your brothers to live a long life...
                   For your brother's that passed and for your brothers that will life you pull the pin... the ebast releasing this one step to late gets engulfed by the flames of
                   your wrath... You did it you avenged your brothers that had fallen and fought so the others could live one day longer... and maybe just maybe they can make it out
                   of this wretched hell... [For those that will live and for those that have fallen ending ahcieved]



               B. Prioritise supplies and survivability.
               [Grandmaster of war ending]

                   You order your men to gather the weapons and medical supplies, the scouts reported a nearby nest... this news came with the price of a few of your men.
                   With the new equipment you launch a distraction mission to distract the beast as the other group goes out to gather the emdical supplies.
                   You and the rest of the forces go back to help the group that baited the creature... many are harmed... almost dead even... you have some of your soldiers tend
                   to them as you and the forces go after the beast... It lunges wildly at your forces dragging them and slamming them but has grown warry... this beast is a hunter and
                   a cunning one at that realising it's situation it tries to escape. A good thing you had blocked it in advance with a shield unit that carru shotguns. Surrounded by your
                   forces with no escape in sight... a beast once feared now nothing but cornered mice... as any beast in this situation in started to lash out but... all it had was his
                   might jaws, claws and taill... normally a scarry weapon reduced to nothing with the powerfull exo-skeletons and the special shields that the scientist here had created.
                   Truly a pity that no one was stationed there before mayby than... things wouldn't have reached this point... but a pleasant supprise to get my hands on these anyways.
                   Makes one truly wonder how many more secrets are being kept here.

                   The beast had finished its final struggle... and now all that remained was the stench of blood and dozens of corpses... but a victory nontheless. You decide to further
                   your advances in order to kill many more beasts to come and discover the secrets that this facility holds... and grow your strenght in the process.


                   ...(use the inheritance class here. it's a wave type omething like day 1 than instantiate the monster)

          }
          else [human sacrifice ending]
          {

             He makes his way over "Well, guess you're still alive" he says in an annoyed tone, you look at him and just walk away. He's of no use a liability even.
             The atmosphere is a bit tense quite a few people seem wary of you... guess they're his friends. While others seem to be somewhat on your side 
             after seeing your achievement. It's getting late and you decide to go on guard duty togheter with the guard that you've saved before.

             You're in front of the door once more in a tattered hallway with debry evrywhere accompanied with the thick scent of blood.
             Nothing much is happening and you decide to talk with the guard for a while, sadly your leisure conversation got interupted and you get attacked.
             A creature dupped "The Stalker"  {instantiate stalker desc}  as the beast lunges toward you with its razor sharp claws you hurriedly grab you rifle,
             only to watch it get split in two... his claws tear your flesh... but you're alive the rifle absorbed most of the momentum. You grab you pistol that
             was conveniently in sight so you *borrowed* your old roommate's pistol. You aim the pistol... The Stalker moves around fast, luckily your pawn starts
             distracting the creature by shooting its shoulder blades. The creature changes it's targets and turn around going for the guard you once saved.
             you run to the the creature's right side practically hugging the broken wall and you start aiming at its wounded shoulderblade. The beast swing its tail
             at the guard smashing him agaisnt the walls and going after you again. The creature goes after you and you plan to dodge so it'll impale its head on the
             metal sticking out of the debri once called a wall. The beast runs towards you with devestating killing intent and you shoot at ists eyes trying to 
             blind it... however unlike your plan it decides to grab you with its tail and throw you towards the guard... your condition is... bad, your leg took
             the brunt of the impact shattering in the process and now the beast run towards you... you grab the guard's gun, shot him in his leg
             and threw him towards the beast... killing him.

             You grab *your* rifle and start going for the eyes once more... but the beast decided to just leave with its new snack rapped with its tail... you survived
             but at what costs? You look behind you and see your old roommate and his mates... guess that's that for your social life.

             With heavy steps you return to the temporary base, with a heavy atmosphere those that once admired you now being the once that hate you most.
             You serve the group no more purpose... besides one, your presence is demoralizing so you're cast away they cannot trust someone like you that regards people
             as nothing mere pawns.
             You're tied up and forc ed to walk on the front, going to certain death at the beast's lair... death did not come swiftly... nor was your death grand you were
             small and ignificant those that captured you failed and fled the scene as your bones and flesh bided them time... ultimatly all you accomplished was just being the toy
             of this sadistic beast that enjoyed your every agony... eventualy there was nothing left of you as it had stripped your skin lair after lair, 
             broken your bones and fingers... cracked your ribs and singed your flesh... your life is now nothing but pain... you were used as a pawn on the playing board you tought
             you controlled. [Human sacrifice ending achieved]
          }

          ..




  (friend is fighting a slug like creature and you are chased by a frog like creature and ask for his gun wich would possibly kill him but he 
  could run incorporate this into the story this path is only possible if you have befriended him)
  ...

  B. GeneratorRoom: (security baton)
  You decided that the power is a neccesity as you make your way to the generator... each step you take brings you closer but so does
  a strange punget smell.

  It didn't take long for you to notice what this smell was, as you now stand in it, the flesh of your colleages sticking to your boots.
  You're not sure about how many died here but you make a rough estimate, mayby about 15 men. You can't diffrentiate between whoms who.
  The scene is quite something... these people were torn apart and scattered across the hallway. You hold back the urge to throw up and
  head to the generator... but you see soemthing glistering in the corner of your eye... you turn your head out of curiosity and see the
  guard captain's security pass. He's wounded the most of the bunch, only an arm is intact and a half eaten torso remains, guts spilling out
  and his head is slashed clean off with only the lower jaw remaining, the tongue sticking out and his blood staining the walls.
  You scalvage what you can of the corpses, afterall it is dangerous right now and a proper weapon is what you need. You take one
  of the security team's empty rifles and search for some ammo praying that whatever did this can be killed and hasn't eaten the ammo.
  You go from corpse to corpse yet you find nothing else but the pass, a broken shield and the rifle but you decide to leave the rifle
  alone for now, as you need ammo for it taking it with you now will only hinder your movement. Only 3 corpses left to search.

  You make your way to the next corpse and grab its tattered jacket in order to search its contents as there is no belt or lower body to mention.
  As you put your hand in the pocket you get attacked, in a hurry you turn around.   [if security batton = true]    You grab your batton and swing 
  before you even lay eyes upon your newfound foe... you miss as your dumbass didn't look at how big the thing is that attacked you.
  It's a long centipede like creature with the arms of a human as it's legs and an oversized dog's head, it's fangs piercing your flesh and
  breaking bone it wrstles you to the ground. You grab the broken shield that you got from the corpses and block its mouth you go for another swing
  with your not so trust worthy wand and hit the thing on its head. THe beast lets out a cry slightly opening it's mouth... you take this opetunity
  and jam the broken shield in his mouth. The sharp edges of the broken shield damage the creature's mouth and you push it further in it's flesh
  the creature starts lifting you up and throws itself and you to the wall breaking your ribs in the procces, you let out a grunt and thrust your
  baton into it's eye. You hit the switch and electoructe the unholy abomination. You push it further into it's eye and 
  twist it as much as you can to gauge out his eyes. The creature cries out and let's go running away from you, 
  you won but at what costs? your ribs broken and your spine in pain, you continue to scalvage the supplies of the 2 remaining corpses. 
  You wonder how long you'll have and if you can even make it... you finnally found the ammo and you go back to the rifle and take it with you.
  You continue with your suicidal journey to the generators...

  You have arrived at the generator, you're in luck as the door has been torn off by something, you walk forward temporarely using your new weapon
  as a crutch, not the smartest option but you couldn't find anythign else, and you DID NOT want to fight whatever the fuck that THING was from
  before, so you decided to go as fast as your tattered leg allowed you. 

  You entered the generator room and once again, you're met with corpses. This time it's the corpses on the workers so you grab their pass in order
  to activate the generators, but you time is nigh, you've lost a lot of blood from your leg and the internal injuries that happened during your 
  fight with that damned beast. As you activate the generator it starts blaring so you hurridly sit on the floor and lean against the generator,
  taking aim with your rifle, the broken shield on your arm and the batoon on the floor nicely within reach... as you had guessed it came back.
  With some friends, very ugly friends but now you're ready. You shoot the centipede like through the injury you had left him to finish the job
  and immediatly go for the next beast, this one was more wolf like with tendrils sticking out of it's eyes.
  It let's out a human scream as it runs to you, once more you take aim, and shoot it its mouth, the first bullet pained it and the second for it's
  leg as it stumbles infront of you use your trusty shield and smack it against it's head. you place the rifle on this beast and fire at the next 
  beast wich was... an oversized slug made out of skin and bone. It had a portruding spine of bones and a body made out of the skin of many
  it's belly was by far the grosest thing you've ever seen as it was made out of a thousand faces. Sadly you didn't have time to throw up so
  you grab you baton and wail on the wolf like creature and zapping it as much as you can, keeping it down... its tentacles attacking you and you
  blocking it with the shield, and using the baton to electrocute it whenever whilst that slow ass slug came on over... slowely but surely.
  You shoot at it with all you have whislt defending against the wolf that is now starting to stand up. Sadly... this is your end but hey,
  you activated the generator. [Suicidal mission ending achieved]

  else
  {
  The centipe like beast bites into your ankle crushing bone and tearing flesh, you quikly turn around and use the broken shield that is mounted to
  your arm, all you can do is delay the beast... you cry for help but no avail. Your shield can't hld out for long under the beast's attacks and is
  starting to crack, the beast takking the oppertunity bites a chunk out of the shield and throws you to the ground. pinning you down with a hundred
  hands. this is the end of your story, food for a beast if only you had found the ammo for the rifle or had a weapon to hold it off...
  [Dogfood ending achieved]
  }


  */






    }
}
