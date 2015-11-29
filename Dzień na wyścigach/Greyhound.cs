using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Greyhound
    {
        public const int MIN_MOVE = 5;
        public const int MAX_MOVE = 20;
        public const int WIDTH = 74;

        public PictureBox PictureBox;
        public Random MyRandom;

        public Point Location
        {
            get { return PictureBox.Location; }

            set { PictureBox.Location = value; }
        }

        public int Number { get; private set; }

        public Greyhound(PictureBox pictureBox, int number)
        {
            PictureBox = pictureBox;
            Number = number;
        }

    }
}
