using System;

namespace Station
{
    class Program
    {
        static void Main(string[] args)
        {
            BusStop bs = new BusStop();
            Bus b = new Bus();

            for (int i = 0; i < 6; i++)
            {
                bs.PersonArrive(PassengerGenerator.CreatePassenger());
            }

            bs.BusArrive(b) ;
            b.ArriveAt("Lancaster");
            b.ArriveAt("MoreCamp");
        }
    }
}
