using System ;
using System.Collections.Generic;


namespace Station
{
    public class Bus 
    {
        public const int CAPACITY = 5 ;
        public int Space { get => CAPACITY - _passengers.Count ;}    

        private List<Passenger> _passengers = new List<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space <1)
            {
                return false;
            }

            _passengers.Add(passenger) ;
            System.Console.WriteLine($"{passenger} got on bus");
            return true;
        }
    }
}