using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class RoomChoise1 : ChooseDecision
    {
        private bool friend = false; // choise B
        private bool baton = false; //choise D
        //decision A results in a bullet through the head
        //choise C in getting fired
        
        public override void Decisions()
        {
            
          {
          Console.WriteLine(des1);
          Console.WriteLine(des2);
          if (des3 != null)
          {
              Console.WriteLine(des3);
          }
          if (des4 != null)
          {
              Console.WriteLine(des4);
          }
         deciding = Console.ReadLine();
         if(deciding == "a" || deciding == "A")
          {
              Console.WriteLine(""); 
          }
      }
      
        }
        public override bool SendBool1(string decision)
        {

            if (decision == "b" || decision == "B")
            {
                return true;

            }
            else
            {
                return false;
            }
        }
        public override bool SendBool2(string decision)
        {
            if (decision == "d" || decision == "D")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
    Decisions
     {
     Console.WriteLine(des1);
     Console.WriteLine(des2);
     if (des3 != null)
     {
         Console.WriteLine(des3);
     }
     if (des4 != null)
     {
         Console.WriteLine(des4);
     }
    deciding = Console.ReadLine();
    if(deciding == "a" || deciding == "A")
     {
         Console.WriteLine("");
     }
 }
 */
    }


}
