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
        //public int StartingPosition;
        public PictureBox PictureBox;
        public Random MyRandom;

        public Point Location
        {
            get { return PictureBox.Location; }

            set { PictureBox.Location = value; }
        }

        public Greyhound(PictureBox pictureBox)
        {
            PictureBox = pictureBox;
        }
    }
}
