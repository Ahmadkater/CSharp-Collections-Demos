using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    public class BusRouteRepo
    {
        public static Dictionary<int, BusRoute> InitializeRoutes()
        {
            var result = new Dictionary<int, BusRoute>()
            {

                {40,
                new BusRoute(40,new string[]{"MoreCamp","Lancaster","Garstang","Preston"})
                },
                {42,
                new BusRoute(42,new string[]{"Lancaster","Garstang","BlackPool"})
                },
                {100,
                new BusRoute(100,new string[]{"University","Lancaster","MoreCamp"})
                },
                {5,
                new BusRoute(5,new string[]{"Overton","MoreCamp","Carnfoth"})
                },
                {555,
                new BusRoute(555,new string[]{"Lancaster","Carnforth","Kendal","Winderemere","Keswick"})
                }
            };

            return result;
        }
    }
}