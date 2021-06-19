using System;

namespace Demos.BusRoute

{
    public class BusRoute 
    {
        public int Number {get; set;}
        public string Origin {get ; set;}
        public string Destination {get ; set;}    

        public BusRoute(int num , string origin , string destination)
        {
            Number = num;
            Origin = origin;
            Destination = destination;
        }

        public override string ToString() => $"{Number} : {Origin} -> {Destination}";

        
    }    
}