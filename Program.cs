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
                Console.WriteLine("Make sure to remember the controls as they won't be shown later for immersion reasons although you might see a 'press 'enter' to continue' \r\n" +
                    "I hope you enjoy this 'game' and goodluck!\r\n\r\n" +
                    "Press 'enter' to continue");
                Console.ReadLine();
                Console.Clear();

                _story.BeginStory();
                Console.WriteLine("\r\nThank you for playing.");
                Console.ReadLine();

                _looping = false;   
            }

        }
    }
}
