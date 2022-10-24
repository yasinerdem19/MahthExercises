using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathExercises.Create
{
    internal class CreateArray
    {
        public static int[] GenerateIntegerArray(int arraySize, int minValue=-888, int maxValue=9999)
        {
            Random rnd = new Random();
            int[] myIntegerArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                myIntegerArray[i] = rnd.Next(minValue, maxValue);
            }
            //write the array on screen
            return myIntegerArray;

        }







        public static void ConsoleWriteArray(int[] xConsoleWriteArray)
        {
            foreach (int item in xConsoleWriteArray)
            {
                Console.Write(item + " / ");
            }
            //chexk array size
            Console.WriteLine("\n\nArray's size is: " + xConsoleWriteArray.Length);
        }
        public static void ConsoleWriteArray(double[] xConsoleWriteArray)
        {
            foreach (double item in xConsoleWriteArray)
            {
                Console.Write(item + " / ");
            }
            //chexk array size
            Console.WriteLine("\n\nArray's size is: " + xConsoleWriteArray.Length);
        }
    }
}
