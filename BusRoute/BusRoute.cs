using System;

namespace Demos.BusRoute

{
    public class BusRoute 
    {
        public int Number {get; set;}
        public string Origin => PlacesServed[0];
        public string Destination => PlacesServed[^1];    
        public string [] PlacesServed {get; set;}
        public BusRoute(int num , string[] placesServed)
        {
            Number = num;
            PlacesServed = placesServed;
            
        }

        public override string ToString() => $"{Number} : {Origin} -> {Destination}";

        public bool Serves(string destination) => Array.Exists(PlacesServed, p => p == destination);

        
    }    
}