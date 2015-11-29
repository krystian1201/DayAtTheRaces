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
        private readonly List<Player> _players;
         
        private readonly Random _random;
        
        private readonly int _racetrackLength;

        public Form2()
        {
            InitializeComponent();

            _random = new Random();

            _greyhounds = new List<Greyhound>();

            int greyhoundNumber = _greyhounds.Count;

            _greyhounds.Add(new Greyhound(pictureBoxGreyhound, greyhoundNumber));


            _players = new List<Player>();

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
    }
}
