using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace canadianComputingCompetition.Controllers
{
    public class J2Controller : ApiController
    {
        /// <summary>
        /// This function computes the number of ways a person can roll 2 dice to get the sum of 10
        /// </summary>
        /// <param name="m">positve integer</param>
        /// <param name="n">positive integer</param>
        /// <returns>string</returns>
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]
        public string DiceGame(int m , int n)
        {
            // variable declaration
            const int sum = 10;
            int counter = 0;
            string message = "";

            //looping through the first number from buttom to top
            for (int i = 1 ; i <= m; i++)
            {
                // looping through the second number from top to buttom
                for(int j = n; j >= 1; j--)
                {
                    //checking if the sum of the two number is equal to 10
                    if( i + j == sum)
                    {
                        counter++; // increament the counter
                    }
                }
            }
            
            // if statment to format the out correctly
            if(counter == 0)
                message = "There are " + counter +  " ways to get the sum 10";
            else if(counter == 1)
            
                message = "There is " + counter + " way to get the sum 10";
            else
                message = "There are " + counter + " ways to get the sum 10";

            return message;
           
        }
    }
}
