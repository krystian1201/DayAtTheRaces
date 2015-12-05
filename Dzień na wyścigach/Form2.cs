using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Dzień_na_wyścigach.Properties;

namespace Dzień_na_wyścigach
{
    public partial class Form2 : Form
    {
        private readonly List<Greyhound> _greyhounds;
        private readonly List<Player> _players;
         

        private readonly RaceController _raceController;
        private readonly RaceTrackDisplayController _raceTrackDisplayController;
        private readonly GreyhoundDisplayController _greyhoundDisplayController;

        public Form2()
        {
            InitializeComponent();

            _greyhounds = new List<Greyhound>();
            _players = new List<Player>();


            _raceController = new RaceController(this, timer1, _greyhounds);
            _raceTrackDisplayController = new RaceTrackDisplayController(this, _greyhounds);

            InitializeRaceTrack();

            _greyhoundDisplayController = new GreyhoundDisplayController(_greyhounds);
        }

        private void InitializeRaceTrack()
        {
            _raceTrackDisplayController.AddRaceTrackLaneWithGreyhound(0);
            _raceTrackDisplayController.AddRaceTrackLaneWithGreyhound(1);

            RaceTrack raceTrack = new RaceTrack(tableLayoutPanel1.Controls[0].Width);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _raceController.StartTheRace();
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


        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var greyhound in _greyhounds)
            {
                if (!greyhound.CrossedTheFinishLine(RaceTrack.Length))
                {
                    _greyhoundDisplayController.AnimateGreyhound(greyhound);
                }

                if(_greyhoundDisplayController.AllGreyhoundsCrossedTheFinishLine())
                {
                    _raceController.StopTheRace();
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
                    _raceTrackDisplayController.AddRaceTrackLaneWithGreyhound((int)control.Value);
                }
            }
        }

        public void DisplayRaceResults()
        {
            dataGridViewResults.Rows.Clear();

            foreach (var greyhound in _greyhounds)
            {
                string[] greyhoundResults = 
                    {greyhound.PositionInLastRace.ToString(), greyhound.Number.ToString(), greyhound.TimeInLastRace.Seconds.ToString()};

                dataGridViewResults.Rows.Add(greyhoundResults);
            } 
        }  
    }
}
