using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Common
{
    public class AverageFuelConsumptionCalculator
    {
        public static double CalculateFuelConsumptionLiters(double filledLiters, double mileage)
        {
            if (mileage == 0 || double.IsNaN(filledLiters) || double.IsNaN(mileage))
            {
                return 0;
            }
            return filledLiters / (mileage / 100);
        }

        public static double CalculateFuelConsumptionMPG(double filledGallons, double mileage)
        {
            if (filledGallons == 0 || double.IsNaN(filledGallons) || double.IsNaN(mileage))
            {
                return 0;
            }
            return mileage / filledGallons;
        }
    }
}
