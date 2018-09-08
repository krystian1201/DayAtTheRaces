using System;
using System.Collections.Generic;
using System.Drawing;

namespace DayAtTheRaces
{
    public class GreyhoundDisplayController
    {
        //private readonly List<Greyhound> _greyhounds;
        private readonly Random _random;

        public GreyhoundDisplayController(List<Greyhound> greyhounds)
        {
            //_greyhounds = greyhounds;
            _random = new Random();
        }


        public void AnimateGreyhound(Greyhound greyhound)
        {
            int greyhoundMove = _random.Next(Greyhound.MIN_MOVE, Greyhound.MAX_MOVE);

            greyhound.Location = new Point(greyhound.Location.X + greyhoundMove, greyhound.Location.Y);
        }


    }
}
