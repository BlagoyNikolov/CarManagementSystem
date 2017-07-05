using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMS.Common
{
    public class TimeMileageCalculator
    {
        public static int GetRemainingMonths(int givenConsumativeMonths, int elapsedMonths)
        {
            if (elapsedMonths >= 0 && givenConsumativeMonths > 0)
            {
                return (givenConsumativeMonths - elapsedMonths);
            }
            return 0;
        }

        public static int GetRemainingMileage(int givenConsumativeMileage, int carAverageMileage, int elapsedMonths)
        {
            if (elapsedMonths >= 0 && givenConsumativeMileage > 0 && carAverageMileage > 0)
            {
                return (givenConsumativeMileage - (elapsedMonths * carAverageMileage));
            }
            return 0;
        }

        public static string GetRemainingMonthsOrMileage(int givenConsumativeMonths, int givenConsumativeMileage, int carAverageMileage, int elapsedMonths)
        {
            int remainingTime = GetRemainingMonths(givenConsumativeMonths, elapsedMonths);
            int remainingMileage = GetRemainingMileage(givenConsumativeMileage, carAverageMileage, elapsedMonths);

            string result = string.Format("Time remaining {0}, Mileage remaining {1}", remainingTime, remainingMileage);
            return result;
        }
    }
}
