using NUnit.Framework;
using DollarAddresses;
using WebRequest;
using System;

namespace Tests
{
    public class Tests
    {
        //how to use [SetUp] http://www.informit.com/articles/article.aspx?p=406343&seqNum=14
        [SetUp]
        public void Setup()
        {
         //   Session1 = new testGetDistanceKmFunction(response1, response2);
        }

        [TestCase("Lewiston", "First", 14, "Portland", "Falmouth", 96, 5, 47.26)]
        [TestCase("Lewiston", "First", 14, "Gorham", "College", 37, 5, 49.08)]
        public void testGetDistanceKmFunction(
            string city, string street, int address, string city2, string street2, int address2, int range, double realdistence)
        {
            // I got the testing distences from https://www.mapdevelopers.com/distance_from_to.php 
            //test lewiston house to usm portland and gorham
            // added range to solve for small distence errors

            location[] response1 = WebRequest.WebRequest.findLocations(city, street, address);
            location[] response2 = WebRequest.WebRequest.findLocations(city2, street2, address2);
            double distance = Program.GetDistanceKm(response1[0],response2[0]);
            Assert.IsTrue(distance >= 49.08 - range && distance <= 49.08 + range); 
            //this is distence (49.08) is given by the link above
            //due to ARC GIS giveing a different lon and lat value
            //when the suffix of a named street is or is not there 
            // because my program cant do suffixes 



            //Assert.Pass();
            //var x = DollarAddresses.Program.GetDistanceKm();// give locations
            //Assert.IsTrue(x > 2000); // test 
            // Assert.Pass();
        }

        //[TestCase("", ExpectedResult = 0)]
    }
}