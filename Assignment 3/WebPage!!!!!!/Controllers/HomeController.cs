using System;
using System.Collections.Generic;
using business_logic_Library;
using Microsoft.AspNetCore.Mvc;
using static business_logic_Library.LocationAnalysis;

namespace WebPage______.Controllers
{
	public class HomeController : Controller
	{
        [HttpPost]
		public ActionResult<bool> AreMeeting([FromBody] AreMeetingRequest request)
		{
			return LocationAnalysis.AreMeeting(request.a, request.b, request.distanceMeter, request.timeSpan);
		}

        [HttpPost]
        public ActionResult<WhereWhen> HaveWeMet([FromBody] HaveWeMetRequest request2)
        {
            return LocationAnalysis.HaveWeMet(request2.person1, request2.person2, request2.distanceMeter, request2.timeSpan);
        }

        [HttpPost]
        public ActionResult<List<Location>> checkAlibi([FromBody] checkAlibiRequest request3)
        {
            return LocationAnalysis.checkAlibi(request3.person, request3.startTime, request3.endTime);
        }

        [HttpPost]
        public ActionResult<double> GetDistanceKm([FromBody] GetDistanceKmRequest request4)
        {
            return LocationAnalysis.GetDistanceKm(request4.a, request4.b);
        }
    }
}
