using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedAdventureGame
{
    internal class Program
    {
        private StoryLine _story = new StoryLine();
        private bool _looping = true;
        public void Main(string[] args)
        {

            while (_looping)
            {
                _story.BeginStory();
            }
        }
    }
}
