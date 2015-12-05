using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Dzień_na_wyścigach
{
    public partial class Form2 : Form
    {
        private readonly List<Greyhound> _greyhounds;
        private readonly List<Player> _players;
        private static int _ticks;
        private static Timer _timer;

        private readonly RaceController _raceController;
        private readonly RaceTrackDisplayController _raceTrackDisplayController;
        private readonly GreyhoundDisplayController _greyhoundDisplayController;

        public volatile int CurrentFinishingPosition;

        public Form2()
        {
            InitializeComponent();

            _greyhounds = new List<Greyhound>();
            _players = new List<Player>();

            //interval in miliseconds
            _timer = new Timer(50);
            _timer.Elapsed += OnTimedEvent;
            _timer.AutoReset = true;
            _timer.SynchronizingObject = this;

            _ticks = 0;

            _raceController = new RaceController(this, _timer, _greyhounds);
            _raceTrackDisplayController = new RaceTrackDisplayController(this, _greyhounds);

            InitializeRaceTrack();

            _greyhoundDisplayController = new GreyhoundDisplayController(_greyhounds);
        }

        private void InitializeRaceTrack()
        {
            _raceTrackDisplayController.AddRaceTrackLaneWithGreyhound(1);
            _raceTrackDisplayController.AddRaceTrackLaneWithGreyhound(2);

            RaceTrack raceTrack = new RaceTrack(tableLayoutPanel1.Controls[0].Width);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _raceController.StartTheRace();

            _ticks = 0;
        }


        public void DisableControlsWhenRaceStarts()
        {
            startButton.Enabled = false;
            numericUpDownNumberOfGreyhounds.Enabled = false;
            buttonAcceptBet.Enabled = false;
            listBoxBets.Enabled = false;
            listBoxPlayers.Enabled = false;
            numericUpDownGreyhoundForBet.Enabled = false;
            textBoxBetAmount.Enabled = false;
        }

        public void EnableControlsWhenRaceFinishes()
        {
            startButton.Enabled = true;
            numericUpDownNumberOfGreyhounds.Enabled = true;
            buttonAcceptBet.Enabled = true;
            listBoxBets.Enabled = true;
            listBoxPlayers.Enabled = true;
            numericUpDownGreyhoundForBet.Enabled = true;
            textBoxBetAmount.Enabled = true;
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            _ticks++;

            foreach (var greyhound in _greyhounds)
            {

                if (!_raceController.IsRaceStopped && _raceController.AllGreyhoundsCrossedTheFinishLine())
                {
                    _raceController.StopTheRace();
                }


                if (!greyhound.CrossedTheFinishLine(RaceTrack.Length))
                {
                    _greyhoundDisplayController.AnimateGreyhound(greyhound);
                }

                if (!_raceController.IsRaceStopped && greyhound.CrossedTheFinishLine(RaceTrack.Length)
                    && !greyhound.FinishedRace)
                {
                    double finishingTime = _ticks * (_timer.Interval / 1000.0);

                    greyhound.OnRaceFinish(_raceController.CurrentFinishingPosition, finishingTime);

                    _raceController.IncrementCurrentFinishingPosition();
                    //CurrentFinishingPosition++;
                }
            }
        }

        private void numericUpDownNumberOfGreyhounds_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;

            //probably this condition is unnecessary
            if (control.Value >= control.Minimum && control.Value <= control.Maximum)
            {
                _raceTrackDisplayController.RemoveAllRaceTrackLanes();

                for (int i = 0; i < control.Value; i++)
                {
                    _raceTrackDisplayController.AddRaceTrackLaneWithGreyhound(i + 1);
                }
            }
        }

        public void DisplayRaceResults()
        {
            dataGridViewResults.Rows.Clear();

            foreach (var greyhound in _greyhounds.OrderBy(g => g.PositionInRace))
            {
                object[] greyhoundResults = 
                    {greyhound.PositionInRace.ToString(), greyhound.Number.ToString(),
                    greyhound.TimeInRace.Seconds + ":" + greyhound.TimeInRace.Milliseconds};

                dataGridViewResults.Rows.Add(greyhoundResults);
            } 
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    OnTimerTick();
        //}

        //private void OnTimerTick()
        //{
        //    _ticks++;

        //    foreach (var greyhound in _greyhounds)
        //    {

        //        if (!_raceController.IsRaceStopped && _raceController.AllGreyhoundsCrossedTheFinishLine())
        //        {
        //            _raceController.StopTheRace();
        //        }


        //        if (!greyhound.CrossedTheFinishLine(RaceTrack.Length))
        //        {
        //            _greyhoundDisplayController.AnimateGreyhound(greyhound);
        //        }

        //        if (!_raceController.IsRaceStopped && greyhound.CrossedTheFinishLine(RaceTrack.Length)
        //            && !greyhound.FinishedRace)
        //        {
        //            double finishingTime = _ticks * (_timer.Interval / 1000.0);

        //            greyhound.OnRaceFinish(CurrentFinishingPosition, finishingTime);

        //            //_raceController.IncrementCurrentFinishingPosition();
        //            CurrentFinishingPosition++;
        //        }
        //    }
        //}
    }
}
