using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class Program
    {
        private static StoryLine _story = new StoryLine();
        private static bool _looping = true;
        static void Main(string[] args)
        {

            while (_looping)
            {
                _story.BeginStory();
            }
        }
    }
}
