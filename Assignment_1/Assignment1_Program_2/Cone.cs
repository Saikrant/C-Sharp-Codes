using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_2
{
    public static class Cone
    {

        public static double CalculateArea(int radius , int height)
        {
            return Math.PI * radius * (radius + Math.Sqrt((Math.Pow(radius, 2) + Math.Pow(height, 2))));
        }

        public static double CalculateVolume(int radius , int height)
        {   
            double coneVolume = (1.0/3.0) * Math.PI * Math.Pow(radius, 2) * height;
            return coneVolume;
        }
    }
}
