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
        List<Greyhound> greyhounds;
        Random random;
        const int minGreyhoundMove = 5;
        const int maxGreyhoundMove = 20;
        readonly int greyhoundWidth;
        readonly int racetrackLength;

        public Form2()
        {
            InitializeComponent();

            random = new Random();

            greyhounds = new List<Greyhound>();


            greyhounds.Add(new Greyhound(pictureBoxGreyhound));

            greyhoundWidth = greyhounds[0].MyPictureBox.Width;
            racetrackLength = pictureBoxRaceTrackLane.Width;
        }


        private void startButton_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Greyhound greyhound = greyhounds[0];

            if (!CrossedTheFinishLine(greyhound))
            {
                AnimateGreyhound(greyhound);
            }  
        }

        private void AnimateGreyhound(Greyhound greyhound)
        {
            int greyhoundMove = random.Next(minGreyhoundMove, maxGreyhoundMove);

            Point currentLocation = greyhound.MyPictureBox.Location;

            greyhound.MyPictureBox.Location = new Point(currentLocation.X + greyhoundMove, currentLocation.Y);

        }

        private bool CrossedTheFinishLine(Greyhound greyhound)
        {
            Point currentLocation = greyhound.MyPictureBox.Location;

            if (currentLocation.X + greyhoundWidth >= racetrackLength)
            {
                return true;
            }

            return false;
        }
    }
}
