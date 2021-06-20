using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    public class BusRouteRepo
    {
        private readonly BusRoute[] _allroutes;
        public BusRouteRepo()
        {
            _allroutes = new BusRoute[]
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
        }

        public BusRoute[] FindBusesTo(string location)
        
        => Array.FindAll(_allroutes,route => route.Serves(location));

        public BusRoute[] FindBusesBetween(string location1,string location2)
        
        => Array.FindAll(_allroutes,route => route.Serves(location1) && route.Serves(location2));
    }
}