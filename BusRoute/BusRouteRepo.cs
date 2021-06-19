using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    public class BusRouteRepo 
    {
        public static List<BusRoute> InitializeRoutes()
        {
            var result = new List<BusRoute>
            {
                new BusRoute(40,new string[]{"MoreCamp","Lancaster","Garstang","Preston"}),
                new BusRoute(42,new string[]{"Lancaster","Garstang","BlackPool"}),
                new BusRoute(100,new string[]{"University","Lancaster","MoreCamp"}),
                new BusRoute(1_000,new string[]{"Test Origin","Test Destination"}),
                new BusRoute(555,new string[]{"Lancaster","Carnforth","Kendal","Winderemere","Keswick"})
            };
            
            return result ;
        }    
    }
}