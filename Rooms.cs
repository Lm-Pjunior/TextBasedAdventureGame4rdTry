using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal abstract class Rooms
    {
        private string _name;
        private string _description;
        public Rooms(string name, string description)
        {
            _name = name;
            _description = description;
        }
        public abstract void EnterRoom();

       /*
        First room has to have a room description with the mentioning of:
       - map given by instructor
       -
       -
       */
    }
}
