using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static business_logic_Library.LocationAnalysis;

namespace WebPage______
{
    public class AreMeetingRequest
    {
        public WhereWhen a;
        public WhereWhen b;
        public double distanceMeter;
        public TimeSpan timeSpan;

    }
}
