using System ;
using System.Collections.Generic;


namespace Station
{
    public class Bus 
    {
        public const int CAPACITY = 5 ;
        public int Space { get => CAPACITY - _passengers.Count ;}    

        private Stack<Passenger> _passengers = new Stack<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space <1)
            {
                return false;
            }

            _passengers.Push(passenger) ;
            System.Console.WriteLine($"{passenger} got on bus");
            return true;
        }

        public void ArriveAtTerminus()
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Bus arrived at terminus");
            while (_passengers.Count > 0 )
            {
                var p = _passengers.Pop();
                System.Console.WriteLine($"{p.Name} got off the bus");
            }

            System.Console.WriteLine($"There are {_passengers.Count} passengers still on the bus");
        }
    }
}