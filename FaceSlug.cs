using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextBasedAdventureGame
{
    public class FaceSlug : Monster
    {
        public FaceSlug(string name, string desc, string attackStory) : base(name, desc, attackStory)
        {
        }
        /*
          name
         
         FaceSlug 
        
        desc 

          "It's hideous abomination whoms exterior is made out of thousands of shriveled up human faces, its liquid guts made out of pulverized flesh and organs and wherever it goes it leaves a trail of oil and pus..." +
        "It among the slower abominations of this facility but it can take quite the hit"
          
        attack

        that overgrown slug spits its slime over the enemy and than throws up his eternal organs over him wich also have an adhesive agent and as my soldiers were rendered immobile...
        then it came over and swallowed them whole crushing them within its body and growing even more
         
         
        */

        public override void CreatureSpawn()
        {
            Console.WriteLine($" A singular {_name} showed up after the Twisted Ones were dead... we prepared for a fight.");
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
