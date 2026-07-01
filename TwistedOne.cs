using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class TwistedOne : Monster
    {
        public TwistedOne(string name, string desc, string attackStory) : base(name, desc, attackStory)
        {
        }
        /*
          Name

          Twisted Ones

        desc

        A creature that vaguely resembles a duckling, yellowe feathers stained in red, twisted legs and a twisted neck... a monstosity that is cursed to look downwards.
        It has 2 beaks one on his face and the other on his cheek... it has a lot of needle like teeth and a long tongue with multiple tendrils on it...
        It has 3 legs 2 of wich a large, twisted with some of its toes broken with the bone sticking out. The other leg is underdeveloped and cannot be used.
        
        attack

        The twisted Ones only have 2 things going for them and that's their numbers and vitality since they have high regeneration... which brings them endless agony.
        They only die when their undeveloped leg is pulled off of their torso, this results in their guts spilling and their lives slipping.
        From there on you only need to crush their skull with the exo-skeleton, we put them out of their misery but one of exo skeletons got damaged in the proccess...
        it would be best to get some repairs done to our weapons
        */
        public override void CreatureSpawn()
        {
            base.CreatureSpawn();
        }
        public void Description()
        {
            base.BeastDesc();

        }
        public void Mauling()
        {
            base.AttackStory();
        }


    }
}
