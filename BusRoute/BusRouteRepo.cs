using System;

namespace Demos.BusRoute
{
    public class BusRouteRepo 
    {
        public static BusRoute[] InitializeRoutes()
        {

            return new BusRoute[]
            {
                new BusRoute(40,new string[]{"MoreCamp","Lancaster","Garstang","Preston"}) ,
                new BusRoute(42,new string[]{"Lancaster","Garstang","BlackPool"}) ,
                new BusRoute(100,new string[]{"University","Lancaster","MoreCamp"}) ,
                new BusRoute(555,new string[]{"Lancaster","Carnforth","Kendal","Winderemere","Keswick"})
            };
        }    
    }
}