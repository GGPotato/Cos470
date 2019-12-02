using System;
using System.Collections.Generic;
using System.Text;

namespace business_logic_Library
{
    public static class LocationAnalysis
    {
        // goal: make this work:
        // person1 = new[] { new WhereWhen() };
        // var collisions = LocationAnalysis.HaveWeMet(person1, person2, 10, TimeSpan.FromMinutes(5));

        //returns null if nothing is found
        public static WhereWhen HaveWeMet(WhereWhen[] person1, WhereWhen[] person2,
            double distanceMeter, TimeSpan timeSpan)
        {
            foreach (WhereWhen unit in person1)
            {
                foreach (WhereWhen unit2 in person2)
                {
                    if (AreMeeting(unit, unit2, distanceMeter, timeSpan))
                    {
                        return unit;
                    }
                }
            }
            return null;
        }

       

        public static bool AreMeeting(WhereWhen a, WhereWhen b, double distanceMeter, TimeSpan timeSpan)
        {
            if (GetDistanceKm(a.Where, b.Where) / 1000 < distanceMeter
                && GetTimeSpan(a.When, b.When) < timeSpan)
            {
                return true;
            }

            return false;
        }

        public static TimeSpan GetTimeSpan(DateTime a, DateTime b)
        {
            return (a - b).Duration();
        }



        public static double GetDistanceKm(Location a, Location b)
        {
          
            var LatPoint = a.Lat - b.Lat;
            var LonPoint = a.Lon - b.Lon;
            //for lat
            var lat = LatPoint * 110.574; // km a
            var lon = LonPoint * 111.320 * Math.Cos(b.Lat);// km b

            //a^2 + b^2 =c^2
            var c = Math.Sqrt(Math.Pow(lat, 2) + Math.Pow(lon, 2));
            return c;

        }

        public static List<Location> checkAlibi(WhereWhen[] person, DateTime startTime, DateTime endTime)
        {/*
            public checkAlibi(WhereWhen[] person, DateTime startTime, DateTime endTime)
            {
            }
            */
            List<Location> locationList = new List<Location>();
            
            for (int i = 0;i<=person.Length-1; i++)
            {
                if((person[i].When >= startTime) && (person[i].When <= endTime))
                {
                    locationList.Add(person[i].Where);
                }
            }
            return locationList;
            
            /*
            foreach ( WhereWhen when in person)
            {
                if((DateTime)when.Milliseconed)
            }
            return null;
            */
        }



        public class WhereWhen
        {
            public WhereWhen(double lat, double lon, System.DateTime time)
            {
                Where = new Location(lat,lon);
                When = time;
            }
            public DateTime When;
            public Location Where;

           // public DateTime whatDay;
           // public Location listLocations;
        }

    }
}
