using System;
using System.Drawing;
using System.Windows.Forms;

namespace DayAtTheRaces
{
    public class Greyhound
    {
        public const int MIN_MOVE = 2;
        public const int MAX_MOVE = 30;
        public const int WIDTH = 74;
        public const int Y_OFFSET = 30;

        private PictureBox _pictureBox { get; }

        public int PositionInRace { get; set; }

        public TimeSpan TimeInRace { get; set; }

        public bool FinishedRace { get; private set; }

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
            FinishedRace = false;
        }

        public bool CrossedTheFinishLine(int racetrackLength)
        {
            if (Location.X + WIDTH >= racetrackLength)
            {
                return true;
            }

            return false;
        }

        public void OnRaceStart()
        {
            PositionInRace = -1;
            TimeInRace = TimeSpan.MaxValue;
            FinishedRace = false;
        }

        public void OnRaceFinish(int currentFinishingPosition, double finishingTime)
        {
            PositionInRace = currentFinishingPosition;

            int wholeSeconds = (int) finishingTime;
            int miliseconds = (int)((finishingTime - wholeSeconds) * 1000);

            TimeInRace = new TimeSpan(0, 0, 0, wholeSeconds, miliseconds);

            FinishedRace = true;
        }
    }
}
