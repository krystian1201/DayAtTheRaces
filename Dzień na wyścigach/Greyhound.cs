using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Greyhound
    {
        public const int MIN_MOVE = 10;
        public const int MAX_MOVE = 40;
        public const int WIDTH = 74;
        public const int Y_OFFSET = 30;

        private PictureBox _pictureBox { get; }

        public int PositionInLastRace { get; set; }

        public TimeSpan TimeInLastRace { get; set; }

        public Random MyRandom;

        public Point Location
        {
            get { return _pictureBox.Location; }

            set { _pictureBox.Location = value; }
        }

        public int Number { get; private set; }


        public Greyhound(PictureBox pictureBox, int number)
        {
            _pictureBox = pictureBox;
            Number = number;
        }

        public bool CrossedTheFinishLine(int racetrackLength)
        {
            if (Location.X + WIDTH >= racetrackLength)
            {
                return true;
            }

            return false;
        }

    }
}
