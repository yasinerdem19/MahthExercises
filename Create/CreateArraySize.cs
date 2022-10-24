using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Create
{
    internal class CreateArraySize
    {
        public static int CreateSizeFromImput()
        {
            Console.Write("Array Size is: ");
            string x = Console.ReadLine();
            return  Convert.ToInt32(x);
        }
    }
}
