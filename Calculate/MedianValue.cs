using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Calculate
{
    internal class MedianValue
    {
        public static double MedianValueWithMethod(double[] arrSource)
        {
            return arrSource.Median();
        }
    }
}
