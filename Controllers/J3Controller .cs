using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace canadianComputingCompetition.Controllers
{
    public class J3Controller : ApiController
    {
        /// <summary>
        /// This J3 problem is from 2009 Junior competition https://cemc.math.uwaterloo.ca/contests/computing/2009/stage1/juniorEn.pdf
        /// This function computes the  local time at the user’s actual location in Canada.
        /// This ensures that text messages have a valid local time attached to them.
        /// </summary>
        /// <param name="time">positve integer between 0 and 2359</param>
        /// <returns>string</returns>
        [HttpGet]
        [Route("api/J3/GoodTimes/{time}")]
        public string GoodTimes(int time)
        {
            // variable declaration
            int toronto = time; //maintains the same time
            int ottawa = time; //maintains the same time
            int victoria = time - 300; //subtract 300 from the time
            int edmonton = time - 200; //subtract 200 from the time
            int winnipeg = time - 100; //subtract 100 from the time
            int halifax = time + 100; //add 100 to the time
            int stJohn = time + 130;  //add 130 to the time

            // logic to compute time in regions



            string message = ottawa + " in Ottawa " + "\n" + victoria + " in Victoria " + "\n" +
                 edmonton + " in Edmonton " + "\n" + winnipeg + " in Winnipeg " + "\n" +
                  toronto + " in Toronto " + "\n" + halifax + " in Halifax " + "\n" +
                   stJohn + " in St. John's. ";


            return message;
           
        }
    }
}
