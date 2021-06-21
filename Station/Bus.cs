using System ;
using System.Collections.Generic;


namespace Station
{
    public class Bus 
    {
        public const int CAPACITY = 5 ;
        public int Space { get => CAPACITY - _passengers.Count ;}    

        private LinkedList<Passenger> _passengers = new LinkedList<Passenger>();

        public bool Load(Passenger passenger)
        {
            if (Space <1)
            {
                return false;
            }

            _passengers.AddLast(passenger) ;
            System.Console.WriteLine($"{passenger} got on bus");
            return true;
        }

        public void ArriveAt(string place)
        {
            System.Console.WriteLine(" ");
            System.Console.WriteLine($"Bus arriving at {place}");
            if (_passengers.Count == 0)
            {
                return;
            }

            LinkedListNode<Passenger> currentNode = _passengers.First ;

            while (currentNode != null)
            {
                var nextNode = currentNode.Next ;
                if (currentNode.Value.Destination == place)
                {
                    System.Console.WriteLine($"{currentNode.Value} is getting off");
                    _passengers.Remove(currentNode);
                }

                currentNode = nextNode;
            }

            System.Console.WriteLine($"There are {_passengers.Count} passengers left on the bus");
        }
    }
}