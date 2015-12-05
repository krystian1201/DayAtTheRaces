using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dzień_na_wyścigach.Properties;

namespace Dzień_na_wyścigach
{
    public partial class Form2 : Form
    {
        private readonly List<Greyhound> _greyhounds;
        private readonly List<Player> _players;
         
        private readonly Random _random;
        
        private int _racetrackLength;

        public Form2()
        {
            InitializeComponent();

            _random = new Random();

            _greyhounds = new List<Greyhound>();
            _players = new List<Player>();

            InitializeRaceTrack();  
        }

        private void InitializeRaceTrack()
        {
            AddRaceTrackLaneWithGreyhound(0);

            _racetrackLength = (tableLayoutPanel1.Controls[0]).Width;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (var greyhound in _greyhounds)
            {
                if (!greyhound.CrossedTheFinishLine(_racetrackLength))
                {
                    AnimateGreyhound(greyhound);
                }
            }  
        }

        private void AnimateGreyhound(Greyhound greyhound)
        {
            int greyhoundMove = _random.Next(Greyhound.MIN_MOVE, Greyhound.MAX_MOVE);

            greyhound.Location = new Point(greyhound.Location.X + greyhoundMove, greyhound.Location.Y);
        }


        private void numericUpDownNumberOfGreyhounds_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown control = (NumericUpDown)sender;

            //probably this condition is unnecessary
            if (control.Value >= control.Minimum && control.Value <= control.Maximum)
            {
                RemoveAllRaceTrackLanes();

                for (int i = 0; i < control.Value; i++)
                {
                    AddRaceTrackLaneWithGreyhound((int)control.Value);
                }
            }
        }

        private void RemoveAllRaceTrackLanes()
        {
            this.tableLayoutPanel1.Controls.Clear();
        }

        private void AddRaceTrackLaneWithGreyhound(int greyhoundNumber)
        {
            Panel panel = new Panel {Size = new Size(600, 60)};

            AddRaceTrackLane(panel);
            AddGreyhoundToRaceTrack(panel, greyhoundNumber);

            panel.Dock = DockStyle.Fill;
            this.tableLayoutPanel1.Controls.Add(panel);
        }

        private void AddRaceTrackLane(Panel panel)
        {
            PictureBox pictureBoxTrackLane = new PictureBox
            {
                Image = Resources.racetrack_lane,
                Dock = Dock = DockStyle.Fill
            };

            panel.Controls.Add(pictureBoxTrackLane);
        }


        private void AddGreyhoundToRaceTrack(Panel panel, int greyhoundNumber)
        {
            PictureBox pictureBoxGreyhound = new PictureBox
            {
                Image = Resources.dog,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(0, 30)
            };


            panel.Controls.Add(pictureBoxGreyhound);

            panel.Controls[1].BringToFront();

            _greyhounds.Add(new Greyhound(pictureBoxGreyhound, greyhoundNumber));
        }  
    }
}
