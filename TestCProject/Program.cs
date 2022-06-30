using System;

namespace TestCProject
{
    static class Program
    {
        static void Main(string[] args)
        {

            // Declare an array of double with a fixed size
            double[] arrOfDouble = new double[10];

            // Declare an array of double and populate it
            double[] arrOfDouble2 = new double[] { 0.1, 0.5, 10.0, 1.0, 3.0 };

            // Declare an array of string
            string[] arrOfString = new string[] { "first string", "second string" };

            // An undefined array of double
            double[] newArrOfDouble;

            // Will use these to demonstrate conversion between arrays of type X to arrays of type Y
            string[] arrOfStrDoubles = new string[] { "0.1", "0.6", "10", "16.4" };
            string[] arrOfStr = new string[] { "0.1", "0.6", "10", "16.4", "abc", "def" };

            arrOfDouble[0] = 0.5;

            Console.WriteLine(arrOfDouble2[3]); // Outputs 1.0

            // Straightforward conversion between double and string arrays
            string[] stringInterpretationOfArrOfDouble2 = Array.ConvertAll(arrOfDouble2, x => x.ToString());

            // Using Parse() method to parse string into double
            double[] convertedStringToDoubleArray = Array.ConvertAll(arrOfStrDoubles, x => Double.Parse(x));

            // Using TryParse() method to convert a string into double
            double[] convertedStringArray = Array.ConvertAll(arrOfStr, x =>
            {
                // If TryParse() fails, it returns false. If it succeeds, it returns true, and the parsed
                // value is stored in the variable 'res'
                if (Double.TryParse(x, out double res))
                {
                    // Return parsed value as double
                    return res;
                }

                // Conversion failed, return 0 instead
                return 0;
            });

            // Array.ForEach method using a lambda (action)
            Array.ForEach(convertedStringArray, x => Console.WriteLine(x));

            // Ordinary for loop
            for(int i = 0; i < arrOfStr.Length; i++)
            {
                Console.WriteLine("---");
                Console.WriteLine(arrOfStr[i] + " => " + convertedStringArray[i].ToString());
                Console.WriteLine($"{arrOfStr[i]} => {convertedStringArray[i]}");
            }

            bool condition = true;
            int retryCount = 1;

            // Instantiate a random number generator
            Random rnd = new Random();
            int randomNumber;

            // do-while loop
            do
            {
                // Take a random number
                randomNumber = rnd.Next(maxValue: 1000, minValue: 100);
                // , check if it is even. If even, continue until we find an odd number
                condition = randomNumber % 2 == 0;

                // Increase the counter by 1 to stop at maximum 10 tries.
                retryCount++;    
            }
            while (condition || retryCount > 10);

            Console.WriteLine($"The random odd number is: {randomNumber} after {retryCount} iterations");

            // Type casting

            string thisWontCastToInt = "0.1";

            // Cast an int from a double
            double abc = 1.594039;
            int def = (int)abc;

            // There is no way to cast a string to an int in this way
            //def = (int)thisWontCast;

            // But you can use int.Parse()
            def = int.Parse(thisWontCastToInt);


            // Nullable types
            // string thisCannotBeNull = null;
            // int thisAlsoCannotBeNull = null;
            // bool thisBoolCannotBeNull = null;

            string? thisCanBeNull = null;
            int? thisIntCanBeNull = null;

            // Casting a non-nullable (int) to its nullable equivalent (int?) is automatic
            thisIntCanBeNull = rnd.Next(100);

            thisIntCanBeNull = 100;

            // ?? operator will return 10 if thisIntCanBeNull is null, otherwise it will return the value of thisIntCanBeNull
            int newRandomNumber = rnd.Next(thisIntCanBeNull ?? 10);


            // Object arrays
            // Object as input to a method

            // To be continued!




        }

     

    }

   
}


