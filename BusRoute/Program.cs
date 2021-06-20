using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    class Program
    {
        static void Main(string[] args)
        {

            var AllRoutes = BusRouteRepo.InitializeRoutes();


            System.Console.WriteLine($"Which Route do you want to look up ");

            int number = int.Parse(System.Console.ReadLine());

            var available = AllRoutes.ContainsKey(number);

            if (available)
            {
                System.Console.WriteLine($"The Route you asked for is {AllRoutes[number]} ");
            }
            else
            {
                System.Console.WriteLine($"There is no Route with number {number} ");
            }
           
        }  

    }
}
