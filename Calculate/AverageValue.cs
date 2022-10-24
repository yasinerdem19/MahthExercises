using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Calculate
{
    internal class AverageValue
    {
        public static double AverageValueWithForEach(int[] array)
        {
            double avgValue = 0;
            foreach (var item in array)
            {
                avgValue = item+avgValue;
            }
            return avgValue/array.Length;
        }
        public static double AverageValueWithMethod(int[] array)
        {
            return array.Average();
        }

    }
}
