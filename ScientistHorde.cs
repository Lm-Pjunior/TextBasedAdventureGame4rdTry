using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class ScientistHorde : HordeMonster
    {
        public ScientistHorde(string name, int ammount, int hp, int dmg) : base(name, ammount, hp, dmg)
        {
        }

        public override void Attack()
        {
            int groupAttack = _dmg * _ammount;
            PlayerStatus.Hp -= groupAttack;
            Console.WriteLine($"The injured scientists scream for help! They're quite loud each scientist did {_dmg} damage to you, \r\n" +
                $"you only have {PlayerStatus.Hp} hp left... you're dieing of annoyance... \r\n\r\n");
        }
        public void DmgTaken()
        {
            base.MonstersDmgTaken();
        }
    }
}
