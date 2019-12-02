using business_logic_Library;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static business_logic_Library.LocationAnalysis;

namespace LocationUnitTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test()]
        public void TestAreMeeting()
        {
            var result = LocationAnalysis.AreMeeting(new WhereWhen(20, 20, DateTime.Now),
                new WhereWhen(20, 20, DateTime.Now),
                1, new TimeSpan(10000));
            Assert.IsTrue(result);

            result = LocationAnalysis.AreMeeting(new WhereWhen(20, 20, DateTime.Now),
                new WhereWhen(10, 10, DateTime.Now),
                1, new TimeSpan(10000));
            Assert.IsFalse(result);

            result = LocationAnalysis.AreMeeting(new WhereWhen(20, 20, DateTime.Now),
                new WhereWhen(20, 20, DateTime.Now.AddDays(1)),
                1, new TimeSpan(10000));
            Assert.IsFalse(result);
        }

        [Test()]
        public void TestGetDistanceKm()
        {
            
            var result = LocationAnalysis.GetDistanceKm(
            new Location(20, 20),
            new Location(20, 20));
            Assert.IsFalse(result !=0);

            result = LocationAnalysis.GetDistanceKm(
            new Location(20, 20),
            new Location(20, 20));
            Assert.IsTrue(result == 0);


        }
        /*
        [Test()]
        public void TestcheckAlibi()
        {
            WhereWhen [] thing = new[]{ new WhereWhen(), 
                                  new WhereWhen(),
                                  new WhereWhen(),
                                  new WhereWhen() };
            //List<Location> A = new List<Location>();
            A.Add(Location(20.0,20.0));
            var driver = new LocationAnalysis();
            
            var result = checkAlibi(whereWhen[] person)

        }
        */
        [Test()]
        public void TestHaveWeMet()
        {
            
        }
        /*
        [Test()]
        public void TestGetTimeSpan()
        {
            var driver = new GetTimeSpan();

            var result = driver.GetTimeSpan(
            new DateTime(20),
            new DateTime(20));
            Assert.IsFalse(result != 0);

            result = driver.GetDistanceKm(
            new Location(20, 20),
            new Location(20, 20));
            Assert.IsTrue(result == 0);
        }*/

    }
}