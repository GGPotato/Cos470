using System;
using WebRequest;

namespace DollarAddresses
{
    public static class Program
    {
        static void Main(string[] args)
        {

            location[] response1 = WebRequest.WebRequest.findLocations("Lewiston", "First", 14);
            location[] response2 = WebRequest.WebRequest.findLocations("Gorham", "College", 37);
            
            if (response1.Length >= 1 && response2.Length >=1)
            {
                double distance = GetDistanceKm(response1[0], response2[0]);

                Console.WriteLine(distance+ "km");
            }
            else
            {
                Console.WriteLine(" ya done goofed");
            }
        }


        public static double GetDistanceKm(location a, location b)// unit test
        {
            double LatPoint = a.Latitude - b.Latitude;
            double LonPoint = a.Longitude - b.Longitude;
            //for lat
            double lat = LatPoint * 110.574; // km a
            double lon = LonPoint * 111.320 * Math.Cos(b.Latitude);// km b

            //a^2 + b^2 =c^2
            double c = Math.Round(Math.Sqrt(Math.Pow(lat, 2) + Math.Pow(lon, 2)),2);
            return c;

        }
    }
}
