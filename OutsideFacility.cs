using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class OutsideFacility : Rooms
    {
        public OutsideFacility(string name, string description) : base(name, description)
        {

        }

        public void GoEnterRoom()
        {
            base.EnterRoom();
        }
    }
}
