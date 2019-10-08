using System;

namespace DollarAddresses
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static int ThingThatShouldBeTested()
        {
            WebRequest.WebRequest.DoStuff();
            return 1;
            
        }
    }
}
