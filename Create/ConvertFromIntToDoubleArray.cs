using MathNet.Numerics.Statistics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Create
{
    internal class ConvertFromIntToDoubleArray
    {
        public static double[] ConvertIntToDoubleArr(int[] arrSource)
        {
            double[] arr = new double[arrSource.Length];
            //foreach (int item in arrSource)
            //{
            //    arr[item] = Convert.ToDouble(arrSource[item]);
            //}
            for (int i = 0; i < arrSource.Length; i++)
            {
                arr[i] = Convert.ToDouble(arrSource[i]);
            }
            return arr;
        }
    }
}
