using System ;

namespace Station
{
    public class Passenger 
    {
        public string Name {get ; set ;}
        public string Destination {get ; set ;}

        public Passenger(string name , string destination)
        {
            Name = name ;
            Destination = destination ;
        }

        public override string ToString()
        {
            return $"{Name} going to {Destination}" ;
        }
    }
}