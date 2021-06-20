using System ;

namespace Demos.BusRoute
{
    public class BusTimes 
    {
        public BusRoute Route {get; } 
        public string [][] Times{get;}

        public BusTimes(BusRoute route , String[][] times)
        {
            Route = route ;
            Times = times ;
        }


    }
}