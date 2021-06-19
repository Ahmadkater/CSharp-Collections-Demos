using System;

namespace Demos.BusRoute
{
    public class BusRouteRepo 
    {
        public static BusRoute[] InitializeRoutes()
        {

            return new BusRoute[]
            {
                new BusRoute(40,"MoreCamp","Preston") ,
                new BusRoute(41,"Lancaster","BlackPool") ,
                new BusRoute(100,"University","MoreCamp") ,
                new BusRoute(555,"Lancaster","Keswick")
            };
        }    
    }
}