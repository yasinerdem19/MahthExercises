// See https://aka.ms/new-console-template for more information
using MathExercises.Calculate;
using MathExercises.Create;

//Get size from imput
int sizeOfTheArrays = CreateArraySize.CreateSizeFromImput();
//create a random array-with previous size
int[] myIntegerArray= CreateArray.GenerateIntegerArray(sizeOfTheArrays);
//write the array
Console.WriteLine("\nCreated array is: ");
//check the array size
CreateArray.ConsoleWriteArray(myIntegerArray);


//max value by for each
int maxValueForEach = MaxValue.MaxValueWithForEach(myIntegerArray);
Console.WriteLine("\nMax value is (method 1): " + maxValueForEach);
//max value by method
int maxValueMethod = MaxValue.MaxValueWithMethod(myIntegerArray);
Console.WriteLine("\nMax value is (method 2): " + maxValueMethod);

//min value by for each
int minValueForEach = MinValue.MinValueWithForEach(myIntegerArray);
Console.WriteLine("\nMin value is (method 1): " + minValueForEach);
//min value by method
int minValueMethod = MinValue.MinValueWithMethod(myIntegerArray);
Console.WriteLine("\nMin value is (method 2): " + minValueMethod);


//avg value by for each
double avgValueForEach = AverageValue.AverageValueWithForEach(myIntegerArray);
Console.WriteLine("\nAvg value is (method 1): " + avgValueForEach);
//avg value by method
double avgValueMethod = AverageValue.AverageValueWithMethod(myIntegerArray);
Console.WriteLine("\nAvg value is (method 2): " + avgValueMethod);



//Convert from int array to double array
double[] myDoubleArray =ConvertFromIntToDoubleArray.ConvertIntToDoubleArr(myIntegerArray);
Console.WriteLine("\nConverted array is: ");
CreateArray.ConsoleWriteArray(myDoubleArray);

//median value by for each
//int minValueForEach = MinValue.MinValueWithForEach(myIntegerArray);
//Console.WriteLine("\nMin value is (method 1): " + minValueForEach);
//median value by method
double  medianValueMethod = MedianValue.MedianValueWithMethod(myDoubleArray);
Console.WriteLine("\nMedian value is (method 2): " + medianValueMethod);



//Factorial.FactorialForImputValue();
//Console.WriteLine(Factorial.FactorialForSentValue(5));







