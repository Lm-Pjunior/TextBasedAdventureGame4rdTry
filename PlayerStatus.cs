using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    public static class PlayerStatus
    {
        //make 2 functions for the friend bool and baton bool each 1 is a bool function the other a void fucntion that turns a bool on!


        //expand the grandmaster of war ending and add a status too ti where you see your sype of soldiers and the ammount of them that you have and if it reaches a certain point you die by the ending.

        public static bool Armed = false;
        public static bool Friend = false;
        private static int _hp = 100;



        //Add 2 new bool type functions to easen my own stress

        //fix the choise system since there are excess options still.
        //make the external documentation!
        

        public static void SendBool1B()

        {
            //friend
            RoomChoise1 boolReturned = new RoomChoise1();
            if (boolReturned.Decision == "B" || boolReturned.Decision == "b")
            {
                Friend = true;
            }
        
            //weapon

            if (boolReturned.Decision == "D" || boolReturned.Decision == "d")
            {
                Armed = true;
            }
            
        }



        //change a variable so it'll send true to roomchoise2 as you can't instantiate a static

    }
    }

