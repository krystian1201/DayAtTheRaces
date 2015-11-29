using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public partial class Form2 : Form
    {
        private readonly List<Greyhound> _greyhounds;
        private readonly Random _random;
        private const int MIN_GREYHOUND_MOVE = 5;
        private const int MAX_GREYHOUND_MOVE = 20;
        private readonly int _greyhoundWidth;
        private readonly int _racetrackLength;

        public Form2()
        {
            InitializeComponent();

            _random = new Random();

            _greyhounds = new List<Greyhound>
            {
                new Greyhound(pictureBoxGreyhound)
            };


            _greyhoundWidth = _greyhounds[0].PictureBox.Width;
            _racetrackLength = pictureBoxRaceTrackLane.Width;
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
            int greyhoundMove = _random.Next(MIN_GREYHOUND_MOVE, MAX_GREYHOUND_MOVE);

            greyhound.Location = new Point(greyhound.Location.X + greyhoundMove, greyhound.Location.Y);

        }

        private bool CrossedTheFinishLine(Greyhound greyhound)
        {

            if (greyhound.Location.X + _greyhoundWidth >= _racetrackLength)
            {
                return true;
            }

            return false;
        }
    }
}
