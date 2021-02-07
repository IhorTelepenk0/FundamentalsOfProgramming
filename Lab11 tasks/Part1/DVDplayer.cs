using System;
using System.Collections.Generic;
using System.Text;

namespace Part1
{
    class DVDplayer
    {
        private string _playedMovie;
        public string PlayedMovie
        {
            get
            {
                return $"The played movie is: {_playedMovie}";
            }
            set
            {
                _playedMovie = value;
                Console.WriteLine($"The played movie is chosen: {value}");
            }
        }

    }
}
