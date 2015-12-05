using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Dzień_na_wyścigach.Properties;

namespace Dzień_na_wyścigach
{
    public class RaceTrackDisplayController
    {
        private readonly List<Greyhound> _greyhounds;
        private readonly Form2 _form;

        public RaceTrackDisplayController(Form2 form, List<Greyhound> greyhounds)
        {
            _form = form;
            _greyhounds = greyhounds;
        }

        public void RemoveAllRaceTrackLanes()
        {
            _form.tableLayoutPanel1.Controls.Clear();
        }

        public void AddRaceTrackLaneWithGreyhound(int greyhoundNumber)
        {
            Panel panel = new Panel { Size = new Size(600, 60) };

            AddRaceTrackLane(panel);
            AddGreyhoundToRaceTrack(panel, greyhoundNumber);

            panel.Dock = DockStyle.Fill;
            _form.tableLayoutPanel1.Controls.Add(panel);
        }

        public void AddRaceTrackLane(Panel panel)
        {
            PictureBox pictureBoxTrackLane = new PictureBox
            {
                Image = Resources.racetrack_lane,
                Dock = DockStyle.Fill
            };

            panel.Controls.Add(pictureBoxTrackLane);
        }


        public void AddGreyhoundToRaceTrack(Panel panel, int greyhoundNumber)
        {
            PictureBox pictureBoxGreyhound = new PictureBox
            {
                Image = Resources.dog,
                SizeMode = PictureBoxSizeMode.AutoSize,
                Location = new Point(0, Greyhound.Y_OFFSET)
            };

            panel.Controls.Add(pictureBoxGreyhound);

            panel.Controls[1].BringToFront();

            _greyhounds.Add(new Greyhound(pictureBoxGreyhound, greyhoundNumber));
        }
    }
}
