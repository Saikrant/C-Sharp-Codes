/*
* Class name : PaintJob
* Class description : Class with  method to return Estimated Cost.
* Developer name : Sai Kranth Koneru
* Date created : 09 / 13 / 2024
* Date modified : 09 / 15 / 2024
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_Program_5
{
    public class PaintJob
    {
        //Method to return the estimatedCost taking 2 input parmas
        public double CalculateEstimatedCost(double squareFootage, double costOfGallon)
        {
            //Constants
            int gallonSquareFeet = 390;
            double costPerSquareFoot = 3.05;
            
            double paintCost = (squareFootage / gallonSquareFeet) * costOfGallon;
            double laborCost = squareFootage * costPerSquareFoot;
            double estimatedCost = paintCost + laborCost;
            return estimatedCost;
        }
    }
}
