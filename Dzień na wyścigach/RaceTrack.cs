namespace DayAtTheRaces
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
