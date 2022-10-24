using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Calculate
{
    public class MaxValue
    {
        public static int MaxValueWithForEach(int[] array)
        {
            int maxValue = array[0];
            foreach (var item in array)
            {
                if (item > maxValue)
                {
                    maxValue = item;
                }
            }
            return maxValue;
        }
        public static int MaxValueWithMethod(int[] array)
        {
            return array.Max();
        }
        
    }
}
