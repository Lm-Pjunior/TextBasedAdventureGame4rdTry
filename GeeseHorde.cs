using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class GeeseHorde : HordeMonster
    {
        public GeeseHorde(string name, int ammount, int hp, int dmg) : base(name, ammount, hp, dmg)
        {
        }

        public override void Attack()
        {
            base.Attack();
        }
        public void DmgTaken()
        {
            base.MonstersDmgTaken();
        }
    }
}
