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
            foreach(WhereWhen unit in person1)
            {
                foreach(WhereWhen unit2 in person2)
                {
                    if(AreMeeting(unit,unit2, distanceMeter, timeSpan))
                    {
                        return unit;
                    }
                }
            }
            return null;
        }

        private bool AreMeeting(WhereWhen a, WhereWhen b, double distanceMeter, TimeSpan timeSpan)
        {
            if(GetDistanceKm(a.where, b.where)/1000 < distanceMeter
                && GetTimeSpan(a.when, b.when) < timeSpan)
            {
                return true;
            }

            return false;
        }

        public TimeSpan GetTimeSpan(DateTime a, DateTime b)
        {
            return (a - b).Duration();
        }



        public double GetDistanceKm( Location a, Location b)// unit test
        {
            var LatPoint = a.lat - b.lat;
            var LonPoint = a.lon - b.lon;
            //for lat
            var lat = LatPoint * 110.574; // km a
            var lon = LonPoint * 111.320 * Math.Cos(b.lat);// km b

            //a^2 + b^2 =c^2
            var c = Math .Sqrt(Math.Pow(lat, 2) + Math.Pow(lon,2));
            return c;

            /*
             * Latitude: 1 deg = 110.574 km
                Longitude: 1 deg = 111.320*cos(latitude) 
             * 
             */



            return 0;
        }

        public class WhereWhen
        {
            public DateTime when;
            public Location where;

        }



        // goal: make this work:
        // person1 = new[] { new WhereWhen() };
        // var location = LocationAnalysis.checkAlibi(person1, DateTime.Now.AddDays(-1), TimeSpan.FromMinutes(5));

        public checkAlibi(object person1, DateTime time, TimeSpan fuzzy)
        {
            //convert time into JSON timestamp format that is in millaseconeds 
            //scan all lines to find that timestamps




        }
        //given a set of data with time, latitude, longitude
        //given a target date and time
        //calculate the 
        //returns a latitude and longitude




        //takes in two sets of data 
        //checks to see if either have Idenitical longitude and latitude properities 
        //then for all cases of idenitical properities check to see if the date/time match up
        // return a list of all 


    }
}
