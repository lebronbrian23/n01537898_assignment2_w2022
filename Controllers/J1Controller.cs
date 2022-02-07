using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace canadianComputingCompetition.Controllers
{
    public class J1Controller : ApiController
    {
        /// <summary>
        /// This method computes the total calories of a menu
        /// </summary>
        /// burger - integer the index burger choice
        /// drink - integer the index drink choice
        /// side - integer the index side choice
        /// dessert - integer the index dessert choice
        /// <returns>A string with the total calories of an order</returns>
        [HttpGet]
        [Route("api/j1/menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu(int burger ,int drink , int side ,int dessert)
        {
            //variable declaration
            int total_burger_calories = 0;
            int total_drink_calories = 0;
            int total_side_calories = 0;
            int total_dessert_calories = 0;

            //if statement to find the calories  in burgers
            if (burger == 1)
            {
                total_burger_calories = 461; //cheeseburger
            } else if (burger == 2)
            {
                total_burger_calories = 431; //fishnurger
            } else if (burger == 3) 
            {
                total_burger_calories = 420; //veggie burger
            }
            else {
                 total_burger_calories =  0; //no burger / option not on the list
            }

            //if statement to find the calories  in drinks
            if (drink == 1)
            {
                total_drink_calories = 130; //soft drink
            }
            else if (drink == 2)
            {
                total_drink_calories = 160; // orange juice
            }
            else if (drink == 3)
            {
                total_drink_calories = 118; // mikl
            }
            else
            {
                total_drink_calories = 0; //no drink / option not on the list
            }
            //if statement to find the calories  in side orders
            if (side == 1)
            {
                total_side_calories = 100; //fries
            }
            else if (side == 2)
            {
                total_side_calories = 57; //baked potatoes
            }
            else if (side == 3)
            {
                total_side_calories = 70; //chef salad
            }
            else
            {
                total_side_calories = 0; //no side order / option not on the list
            }
            //if statement to find the calories  in desserts
            if (dessert == 1)
            {
                total_dessert_calories = 167; //apple pie 
            }
            else if (dessert == 2)
            {
                total_dessert_calories = 266; //sundae
            }
            else if (dessert == 3)
            {
                total_dessert_calories = 75; // fruit cup 
            }
            else
            {
                total_dessert_calories = 0; //no dessert / option not on the list
            }


            return "Your total calorie count is " + (total_burger_calories + total_drink_calories + total_side_calories + total_dessert_calories);
        }
    }
}
