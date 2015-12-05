using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    public class GreyhoundDisplayController
    {
        private readonly List<Greyhound> _greyhounds;
        private readonly Random _random;

        public GreyhoundDisplayController(List<Greyhound> greyhounds)
        {
            _greyhounds = greyhounds;
            _random = new Random();
        }

        public bool AllGreyhoundsCrossedTheFinishLine()
        {
            return _greyhounds.All(greyhound => greyhound.CrossedTheFinishLine(RaceTrack.Length));
        }

        public void AnimateGreyhound(Greyhound greyhound)
        {
            int greyhoundMove = _random.Next(Greyhound.MIN_MOVE, Greyhound.MAX_MOVE);

            greyhound.Location = new Point(greyhound.Location.X + greyhoundMove, greyhound.Location.Y);
        }


    }
}
