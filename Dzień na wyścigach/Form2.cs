using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

namespace Dzień_na_wyścigach
{
    public partial class Form2 : Form
    {
        public IMessageBoxService MessageBoxService { get; set; }

        private readonly List<Greyhound> _greyhounds;
        private readonly HashSet<Player> _players;
        private static int _ticks;
        private static Timer _timer;

        private readonly RaceController _raceController;
        private readonly RaceTrackDisplayController _raceTrackDisplayController;
        private readonly GreyhoundDisplayController _greyhoundDisplayController;
        private readonly PlayersDisplayController _playersDisplayController;

        public volatile int CurrentFinishingPosition;

        public Form2()
        {
            InitializeComponent();

            _greyhounds = new List<Greyhound>();
            _players = new HashSet<Player>();

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
            _playersDisplayController = new PlayersDisplayController(_players);

            MessageBoxService = new MessageBoxService();
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
            buttonStart.Enabled = false;
            numericUpDownNumberOfGreyhounds.Enabled = false;
            buttonAcceptBet.Enabled = false;
            dataGridViewBets.Enabled = false;
            dataGridViewPlayers.Enabled = false;
            buttonAddPlayer.Enabled = false;
        }

        public void EnableControlsWhenRaceFinishes()
        {
            buttonStart.Enabled = true;
            numericUpDownNumberOfGreyhounds.Enabled = true;
            buttonAcceptBet.Enabled = true;
            dataGridViewBets.Enabled = true;
            dataGridViewPlayers.Enabled = true;
            buttonAddPlayer.Enabled = true;
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

        public void buttonAddPlayer_Click(object sender, EventArgs e)
        {

            int rowsCount = dataGridViewPlayers.Rows.Count;

            //we should also check if there was a new row inserted
            if (rowsCount >= 2)
            {
                for (int rowIndex = 0; rowIndex < rowsCount - 1; rowIndex++)
                {
                    string playerName = dataGridViewPlayers.Rows[rowIndex].Cells["PlayerNameColumn"].Value.ToString();
                    string playerMoney = dataGridViewPlayers.Rows[rowIndex].Cells["PlayerMoneyColumn"].Value.ToString();

                    //bool isNew = dataGridViewPlayers.Rows[rowIndex].IsNewRow;
                    //var lol = dataGridViewPlayers.Rows[rowIndex].State;

                    if (!WasRowAlreadyAdded(rowIndex))
                    {
                        OnNewRowOfPlayerAdded(playerName, playerMoney, rowIndex);
                    }
                } 
            }
  
        }

        private bool WasRowAlreadyAdded(int rowIndex)
        {
            return dataGridViewPlayers.Rows[rowIndex].ReadOnly;
        }

        private void OnNewRowOfPlayerAdded(string playerName, string playerMoney, int rowIndex)
        {
            try
            {
                _playersDisplayController.AddPlayer(playerName, playerMoney);

                dataGridViewPlayers.Rows[rowIndex].ReadOnly = true;
                dataGridViewPlayers.Rows[rowIndex].DefaultCellStyle.BackColor = Color.LightGray;

                buttonAddPlayer.Enabled = false;
            }
            catch (Exception exception)
            {
                MessageBoxService.Show(exception.Message);
            }
        }

        public void dataGridViewPlayers_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            int rowsCount = dataGridViewPlayers.Rows.Count;

            if (AreAllRowCellsFilled(rowsCount - 2) && !WasRowAlreadyAdded(rowsCount - 2))
            {
                buttonAddPlayer.Enabled = true;
            }
        }

        private bool AreAllRowCellsFilled(int rowIndex)
        {
            object name = dataGridViewPlayers.Rows[rowIndex].Cells["PlayerNameColumn"].EditedFormattedValue;
            object money = dataGridViewPlayers.Rows[rowIndex].Cells["PlayerMoneyColumn"].EditedFormattedValue;

            return name != null && name.ToString() != "" && money != null && money.ToString() != "";
        }
    }

    public interface IMessageBoxService
    {
        void Show(string message);
    }

    public class MessageBoxService : IMessageBoxService
    {
        public void Show(string message)
        {
            MessageBox.Show(message);
        }
    }
}
