using System;

namespace Demos.BusRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute[] AllRoutes = BusRouteRepo.InitializeRoutes();

            System.Console.WriteLine("Where do you want to go ?");
            string location = System.Console.ReadLine();

            BusRoute[] routes = FindBusTO(AllRoutes, location);

            if (routes != null)
            {
                foreach (var route in routes)
                {
                    System.Console.WriteLine($"You can use route {route} ");
                }
            }
            else
            {
                System.Console.WriteLine($"No routes go to {location}");
            }

        }

        public static BusRoute[] FindBusTO(BusRoute[] routes, String location)
        {
            /*
            foreach (var r in routes)
            {
                if (r.Origin == location || r.Destination == location)
                {
                    return r;
                }
            }

            return null ;
            */
            return Array.FindAll(routes, r => r.Origin == location || r.Destination == location);
        }

    }
}
