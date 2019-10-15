using System;
using System.Collections.Generic;
using System.Text;

namespace business_logic_Library
{
    public class LocationAnalysis
    {
        // goal: make this work:
        // person1 = new[] { new WhereWhen() };
        // var collisions = LocationAnalysis.HaveWeMet(person1, person2, 10, TimeSpan.FromMinutes(5));

        //returns null if nothing is found
        public WhereWhen HaveWeMet(WhereWhen[] person1, WhereWhen[] person2,
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

        private bool AreMeeting(WhereWhen a, WhereWhen b, double distanceMeter, TimeSpan timeSpan)
        {
            if (GetDistanceKm(a.where, b.where) / 1000 < distanceMeter
                && GetTimeSpan(a.when, b.when) < timeSpan)
            {
                return true;
            }

            return false;
        }

        public TimeSpan GetTimeSpan(DateTime a, DateTime b)
        {
            WhereWhen x = new WhereWhen();


            return (a - b).Duration();
        }



        public double GetDistanceKm(Location a, Location b)// unit test
        {
            var LatPoint = a.lat - b.lat;
            var LonPoint = a.lon - b.lon;
            //for lat
            var lat = LatPoint * 110.574; // km a
            var lon = LonPoint * 111.320 * Math.Cos(b.lat);// km b

            //a^2 + b^2 =c^2
            var c = Math.Sqrt(Math.Pow(lat, 2) + Math.Pow(lon, 2));
            return c;

        }

        public List<Location> checkAlibi(WhereWhen[] person, DateTime startTime, DateTime endTime)
        {
            List<Location> locationList = new List<Location>();
            
            for (int i = 0;i<=person.Length; i++)
            {
                if((person[i].when >= startTime) && (person[i].when <= endTime))
                {
                    locationList.Add(person[i].where);

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
            public DateTime when;
            public Location where;

           // public DateTime whatDay;
           // public Location listLocations;
        }

    }
}
