using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static business_logic_Library.LocationAnalysis;

namespace WebPage______
{
    public class HaveWeMetRequest
    {
        public WhereWhen[] person1;
        public WhereWhen[] person2;
        public double distanceMeter;
        public TimeSpan timeSpan;

    }
}
