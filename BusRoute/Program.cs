using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    class Program
    {
        static void Main(string[] args)
        {

            var repo = new BusRouteRepo();


            System.Console.WriteLine($"Where are you ? ");

            string startingAt = System.Console.ReadLine();

            System.Console.WriteLine($"Where do you want to go to ? ");

            string goingTo = System.Console.ReadLine();

            BusRoute[] originRoutes = repo.FindBusesTo(startingAt);
            BusRoute[] destinationRoutes = repo.FindBusesTo(goingTo);

            var routes = new HashSet<BusRoute>(originRoutes);
            routes.IntersectWith(destinationRoutes);


            if (routes.Count > 0)
            {
                foreach (var r in routes)
                {
                    System.Console.WriteLine($"You Can use route {r}");
                }
            }
            else
            {
                System.Console.WriteLine($"No Routes between {startingAt} , {goingTo} ");
            }
           
        }  

    }
}
