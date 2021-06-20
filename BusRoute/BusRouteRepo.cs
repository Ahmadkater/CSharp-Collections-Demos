using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    public class BusRouteRepo
    {
        private readonly BusRoute[] _allRoutes;

        public readonly string[][] timesRoute5 ;

        public BusRouteRepo()
        {
            _allRoutes = new BusRoute[]
            {
                new BusRoute(40,new string[]{"MoreCamp","Lancaster","Garstang","Preston"})
                ,
                new BusRoute(42,new string[]{"Lancaster","Garstang","BlackPool"})
                ,
                new BusRoute(100,new string[]{"University","Lancaster","MoreCamp"})
                ,
                new BusRoute(5,new string[]{"Overton","MoreCamp","Carnfoth"})
                ,
                new BusRoute(555,new string[]{"Lancaster","Carnforth","Kendal","Winderemere","Keswick"})
            };

            timesRoute5 = new string[][]
            {
                new string[]{"15:40","16:40","17:40","18:40"},
                new string[]{"16:08","17:08","18:08","19:08"},
                new string[]{"16:35","17:35","18:35"}
            };

            BustimeRoute5 = new BusTimes(Array.Find(_allRoutes , r => r.Number == 5), timesRoute5);
        }

        public BusTimes BustimeRoute5 {get; }
        public BusRoute[] FindBusesTo(string location)
        
        => Array.FindAll(_allRoutes,route => route.Serves(location));
        
    }
}