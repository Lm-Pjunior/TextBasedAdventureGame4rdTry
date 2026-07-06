using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("Make sure to remember the controls as they won't be shown later for immersion reasons although you might see a 'press 'enter' to continue' \r\n" +
                    "I hope you enjoy this 'game' and goodluck!\r\n\r\n" +
                    "Press 'enter' to continue");
                Console.ReadLine();
                Console.Clear();


                RoomChoise1 choise1 = new RoomChoise1();
                choise1.Decisions();


                break;   
            }

        }
    }
}
