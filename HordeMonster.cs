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
        public virtual void Attack()
        {
            //the groupAttack is a local variable
            int groupAttack = _dmg * _ammount;
            PlayerStatus.Hp -= groupAttack;
            Console.WriteLine($"The enemy horde attacked you and dealt {_dmg} damage each, you only got {PlayerStatus.Hp} hp left! \r\n\r\n");
        }
        public void MonstersDmgTaken()
        {
            AttackMenu fight = new AttackMenu();
            int hordeHp = _hp * _ammount;

            while (true)
            {
                if (PlayerStatus.Hp <= 0)
                {
                    Console.WriteLine("\r\n Oh boy seems you died... \r\n\r\n [Short lived ending achieved] \r\n\r\n");
                    System.Environment.Exit(0);

                }
                fight.Attack();
                if (PlayerStatus.Attacking)
                {
                    hordeHp -= PlayerStatus.Dmg;
                    Console.WriteLine($"\r\n You swing your arm around like a tothler would, smacking the enemy with whatever you wanna call your weapon. \r\n" +
                    $"You dealth {PlayerStatus.Dmg} damage to your apponenents leaving them with {hordeHp} hp. \r\n\r\n");
                }
                PlayerStatus.Attacking = false;

                if (hordeHp <= 0)
                {
                    Console.Clear();
                    break;
                }
                Attack();
            }
            
            
                Console.WriteLine("\r\n Hmmmm they seem dead. should take weapon? \r\n Type yes or no");
                _answer = Console.ReadLine();
                if (_answer == "yes" || _answer == "Yes")
                {
                    Console.WriteLine("You pick up a 'carcase' and proceed through. \r\n");
                    PlayerStatus.Dmg += _hp / 2;
                PlayerStatus.Weapon += $", the body of a {_name}";
                }
                else
                {
                    Console.WriteLine("Sad... I go now.");
                }
            
        }
    }
}
