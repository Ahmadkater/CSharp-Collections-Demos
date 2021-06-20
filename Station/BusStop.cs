using System ;
using System.Collections.Generic ;

namespace Station
{
    public class BusStop 
    {
        private Queue<Passenger> _peopleWaiting = new Queue<Passenger>();

        public void PersonArrive(Passenger p)
        {
            _peopleWaiting.Enqueue(p);
            System.Console.WriteLine($"{p} queuing at bus stop "); 
        }  

        public void BusArrive(Bus bus)
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Bus arriving at bus stop to load passengers");

            while(bus.Space > 0 && _peopleWaiting.Count > 0)
            {
                Passenger p = _peopleWaiting.Dequeue();
                bus.Load(p) ;
            }
        }  
    }
}