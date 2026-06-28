using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal abstract class Monster
    {
        private string _name;
        private string _desc;
        private string _attackType;
        private string _spawnRegion;

        public Monster(string name, string desc, string attackType, string spawnRegion)
        {
            _name = name;
            _desc = desc;
            _attackType = attackType;
        }
        public void CreatureSpawn()
        {
            Console.WriteLine($"A {_name} appeared.");
        }
        public void BeastAppearance()
        {
            Console.WriteLine(_desc);
        }
        public void Attack()
        {

        }
    }
}
