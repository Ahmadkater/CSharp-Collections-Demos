using System;
using System.Collections.Generic;

namespace Demos.BusRoute
{
    class Program
    {
        static void Main(string[] args)
        {

            var repo = new BusRouteRepo();
            BusTimes times5 = repo.BustimeRoute5 ;
            BusRoute route5 = times5.Route;

            for(int p = 0 ; p < route5.PlacesServed.Length ; p++)
            {
                System.Console.Write(route5.PlacesServed[p].PadRight(12));
                
                for(int t=0 ; t < times5.Times.GetLength(1) ; t++)
                {
                    System.Console.Write(times5.Times[p,t]);
                    System.Console.Write("  ");
                }
                System.Console.WriteLine("");
            }

          
           
        }  

    }
}
