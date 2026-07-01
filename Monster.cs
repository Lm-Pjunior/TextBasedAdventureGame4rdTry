using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public abstract class Monster
    {
        protected string _name;
        protected string _desc;
        protected string _attackStory;

        public Monster(string name, string desc, string attackStory)
        {
            _name = name;
            _desc = desc;
            _attackStory = attackStory;
        }
        public virtual void CreatureSpawn()
        {
            Console.WriteLine($"A {_name} appeared.");
        }
        public void BeastDesc()
        {
            Console.WriteLine(_desc);
        }
        public void AttackStory()
        {
            Console.WriteLine(_attackStory);
        }
    }
}
