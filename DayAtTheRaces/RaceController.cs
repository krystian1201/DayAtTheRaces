using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Timers;

namespace DayAtTheRaces
{
    public class RaceController
    {
        private readonly Timer _timer;
        private readonly Form2 _form;
        private readonly List<Greyhound> _greyhounds;

        public bool IsRaceStopped { get; private set; }
        public int CurrentFinishingPosition { get; private set; }

        public RaceController(Form2 form, Timer timer, List<Greyhound> greyhounds)
        {
            _timer = timer;
            _form = form;
            _greyhounds = greyhounds;
            IsRaceStopped = false;
            ResetCurrentFinishingPosition();
        }


        public void StartTheRace()
        {
            _timer.Start();

            _form.DisableControlsWhenRaceStarts();
            ResetGreyhoundsLocations();
            IsRaceStopped = false;
            ResetCurrentFinishingPosition();

            foreach (var greyhound in _greyhounds)
            {
                greyhound.OnRaceStart();
            }
        }

        public void StopTheRace()
        {
            _timer.Stop();

            _form.EnableControlsWhenRaceFinishes();
            IsRaceStopped = true;
            
            _form.DisplayRaceResults();          
        }

        public void ResetGreyhoundsLocations()
        {
            foreach (var greyhound in _greyhounds)
            {
                greyhound.Location = new Point(0, Greyhound.Y_OFFSET);
            }
        }

        public bool AllGreyhoundsCrossedTheFinishLine()
        {
            return _greyhounds.All(greyhound => greyhound.CrossedTheFinishLine(RaceTrack.Length));
        }

        public void IncrementCurrentFinishingPosition()
        {
            CurrentFinishingPosition++;
        }

        private void ResetCurrentFinishingPosition()
        {
            CurrentFinishingPosition = 1;
        }
    }
}
