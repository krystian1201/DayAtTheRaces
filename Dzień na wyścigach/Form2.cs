using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

            int greyhoundNumber = _greyhounds.Count;

            //_greyhounds.Add(new Greyhound(new PictureBox(Resources.dog), greyhoundNumber));


            _players = new List<Player>();

            InitializeRaceTrack();

           
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Greyhound greyhound = _greyhounds[0];

            if (!CrossedTheFinishLine(greyhound))
            {
                AnimateGreyhound(greyhound);
            }  
        }

        private void AnimateGreyhound(Greyhound greyhound)
        {
            int greyhoundMove = _random.Next(Greyhound.MIN_MOVE, Greyhound.MAX_MOVE);

            greyhound.Location = new Point(greyhound.Location.X + greyhoundMove, greyhound.Location.Y);

        }

        private bool CrossedTheFinishLine(Greyhound greyhound)
        {

            if (greyhound.Location.X + Greyhound.WIDTH >= _racetrackLength)
            {
                return true;
            }

            return false;
        }

        private void InitializeRaceTrack()
        {
            AddRaceTrackLane();

            _racetrackLength = (tableLayoutPanel1.Controls[0]).Width;
        }

        private void numericUpDownNumberOfGreyhounds_ValueChanged(object sender, EventArgs e)
        {
            AddRaceTrackLane();
        }

        private void AddRaceTrackLane()
        {
            PictureBox pictureBoxTrackLane = new PictureBox { Image = Resources.racetrack_lane };
            pictureBoxTrackLane.Dock = Dock = DockStyle.Fill;

            this.tableLayoutPanel1.Controls.Add(pictureBoxTrackLane);
        }
    }
}
