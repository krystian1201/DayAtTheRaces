using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class RaceController
    {
        private readonly Timer _timer;
        private readonly Form2 _form;
        private readonly List<Greyhound> _greyhounds;

        public RaceController(Form2 form, Timer timer, List<Greyhound> greyhounds)
        {
            _timer = timer;
            _form = form;
            _greyhounds = greyhounds;
        }


        public void StartTheRace()
        {
            _timer.Start();

            _form.DisableControlsWhenRaceStarts();

            ResetGreyhoundsLocations();
        }

        public void StopTheRace()
        {
            _form.EnableControlsWhenRaceFinishes();

            _timer.Stop();

            _form.DisplayRaceResults();
        }

        public void ResetGreyhoundsLocations()
        {
            foreach (var greyhound in _greyhounds)
            {
                greyhound.Location = new Point(0, Greyhound.Y_OFFSET);
            }
        }
    }
}
