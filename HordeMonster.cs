using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public abstract class HordeMonster
    {
        protected string _name;
        protected int _ammount;
        protected int _hp;
        protected int _dmg;
        private string _answer;
        public HordeMonster(string name, int ammount, int hp, int dmg)
        {
            _name = name;
            _ammount = ammount;
            _hp = hp;
            _dmg = dmg;
        }
        public void Attack()
        {
            PlayerStatus.Hp -= _dmg * _ammount;
        }
        public void MonstersFelled()
        {
            int hordeHp = _hp * _ammount;
            if (hordeHp <= 0)
            {
                Console.WriteLine("\r\n Hmmmm they seem dead should anywho I take this as a weapon? \r\n Type yes or no");
                _answer = Console.ReadLine();
                if (_answer == "yes" || _answer == "Yes")
                {
                    Console.WriteLine("You pick up a monster carcase and proceed through! \r\n");
                    PlayerStatus.Dmg += _hp / 50;
                }
                else
                {
                    Console.WriteLine("Sad... I'll go now though.");
                }
            }
        }
    }
}
