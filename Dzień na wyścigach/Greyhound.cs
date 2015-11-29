using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dzień_na_wyścigach
{
    public class Greyhound
    {
        //public int StartingPosition;
        public PictureBox MyPictureBox = null;
        public Random MyRandom;

        public Greyhound(PictureBox myPictureBox)
        {
            MyPictureBox = myPictureBox;
        }
    }
}
