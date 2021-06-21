using System ;

namespace Station
{
    public static class PassengerGenerator
    {
        private static int _count = 0 ;
        private static Random _rnd = new Random() ;

        public static Passenger CreatePassenger()
        {
            string destination = _rnd.Next(2) == 0 ? "Lancaster" : "MoreCamp" ;
            return new Passenger($"Person #{++_count}",destination);
        }    
    }
}