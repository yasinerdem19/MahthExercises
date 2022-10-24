using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Calculate
{
    public class MinValue
    {
        public static int MinValueWithForEach(int[] array)
        {
            int minValue = array[0];
            foreach (var item in array)
            {
                if (item < minValue)
                {
                    minValue = item;
                }
            }
            return minValue;
        }
        public static int MinValueWithMethod(int[] array)
        {
            return array.Min();
        }
        
    }
}
