using System ;

namespace Station
{
    public static class PassengerGenerator
    {
        private static int _count = 0 ;

        public static Passenger CreatePassenger()
        {
            string destination = "Lancaster" ;
            return new Passenger($"Person #{++_count}",destination);
        }    
    }
}