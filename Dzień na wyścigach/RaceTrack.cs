using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzień_na_wyścigach
{
    public class RaceTrack
    {
        public static int Length { get; private set; }

        //TODO: it would be best to make it singleton
        public RaceTrack(int length)
        {
            Length = length;
        }
    }
}
