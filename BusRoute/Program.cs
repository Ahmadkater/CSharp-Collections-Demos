using System;

namespace Demos.BusRoute
{
    class Program
    {
        static void Main(string[] args)
        {
            var AllRoutes = BusRouteRepo.InitializeRoutes();

            System.Console.WriteLine($"Before There are {AllRoutes.Count} , Routes: ");
            foreach (var r in AllRoutes)
            {
                System.Console.WriteLine($"{r}");
            }

            System.Console.WriteLine("");
            AllRoutes.RemoveAll(item => item.Origin.StartsWith("Test "));

            System.Console.WriteLine($"After There are {AllRoutes.Count} , Routes: ");
            foreach (var r in AllRoutes)
            {
                System.Console.WriteLine($"{r}");
            }

        }  

    }
}
