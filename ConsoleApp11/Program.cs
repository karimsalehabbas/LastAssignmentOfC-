using System;
using System.Reflection;
using System.Threading.Channels;

namespace ConsoleApp11
{
    internal class Program
    {
        class Person
        {
            public string Name;
        }



        static void Main(string[] args)
        {


            #region Explain the difference between passing (Value type parameters) by value and by reference then write a suitable c# example.

            // Pass by Value:

            // The method gets a copy of the variable.
            //Changes inside the method don’t affect the original variable.


            // Pass by Reference:

            //The method gets access to the original variable.
            //Changes inside the method do affect the original variable.



            // Pass by value
            //static void ModifyValue(int number)
            //{
            //    number = 100;
            //}

            //// Pass by reference
            //static void ModifyRef(ref int number)
            //{
            //    number = 100;
            //}

            //int a = 10;
            //int b = 10;

            //ModifyValue(a);  // Passed by value
            //ModifyRef(ref b); // Passed by reference

            //Console.WriteLine("After ModifyValue: a = " + a);   // Output: 10
            //Console.WriteLine("After ModifyRef: b = " + b);     // Output: 100

            #endregion

            #region Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.

            //Passing Reference Type by Value
            //The reference(memory address) is copied, not the object itself.
            // But if you reassign the reference inside the method, it won’t affect the original outside.

            //Passing Reference Type by Reference
            //    Both the reference and the object are passed.
            //    Changes to the object or the reference do affect the original.

            //static void ChangeName(Person p)
            //{
            //    p.Name = "Karim";         
            //    p = new Person();        
            //    p.Name = "Reassigned By Karim";
            //}

            ////    (reference passed by reference)
            //static void ChangePerson(ref Person p2)
            //{
            //    p2= new Person();        
            //    p2.Name = "Changed by reference";
            //}


            //    Person person1 = new Person { Name = "Abbas" };
            //    Person person2 = new Person { Name = "saleh" };

            //    ChangeName(person1);
            //    ChangePerson(ref person2);

            //    Console.WriteLine("Person One Name = " + person1.Name); // Ali
            //    Console.WriteLine("Person Two Name = " + person2.Name); // Changed by reference
            #endregion

            #region Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //static (int sum, int difference) Calculate(int a, int b, int c, int d)
            //{
            //    int sum = a + b;
            //    int difference = c - d;
            //    return (sum, difference);
            //}

            //    // Get input from user
            //    Console.Write("Enter first number for sum: ");
            //    int num1 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second number for sum: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter first number for subtraction: ");
            //    int num3 = int.Parse(Console.ReadLine());

            //    Console.Write("Enter second number for subtraction: ");
            //    int num4 = int.Parse(Console.ReadLine());

            //    // Call the function
            //    var result = Calculate(num1, num2, num3, num4);

            //    // Print the results
            //    Console.WriteLine("Sum = " + result.sum);
            //    Console.WriteLine("Difference = " + result.difference);

            #endregion

            #region Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.
            // Function to calculate sum of digits
            //static int SumOfDigits(int number)
            //{
            //    int sum = 0;
            //    while (number != 0)
            //    {
            //        int digit = number % 10; // Get last digit
            //        sum += digit;            // Add to sum
            //        number /= 10;            // Remove last digit
            //    }
            //    return sum;
            //}


            //    Console.Write("Enter a number: ");
            //    int num = int.Parse(Console.ReadLine());

            //    int result = SumOfDigits(num);

            //    Console.WriteLine("The sum of the digits of the number {0} is: {1}", num, result);
            #endregion

            #region Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not:
            //static bool IsPrime(int number)
            //{
            //    if (number <= 1)
            //        return false;

            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }

            //    return true;
            //}


            //    Console.Write("Enter a number: ");
            //    int num = int.Parse(Console.ReadLine());

            //    if (IsPrime(num))
            //        Console.WriteLine($"{num} is a prime number.");
            //    else
            //        Console.WriteLine($"{num} is not a prime number.");
            #endregion

            #region Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters
            //static void MinMaxArray(int[] arr, ref int min, ref int max)
            //{
            //    min = arr[0];
            //    max = arr[0];

            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        if (arr[i] < min)
            //            min = arr[i];

            //        if (arr[i] > max)
            //            max = arr[i];
            //    }
            //}


            //    int[] numbers = { 10, 5, 50, 30, 1 };

            //    int min = 0, max = 0;

            //    MinMaxArray(numbers, ref min, ref max);

            //    Console.WriteLine("Minimum value: " + min);
            //    Console.WriteLine("Maximum value: " + max);
            #endregion

            #region Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter
            static long Factorial(int number)
            {
                long result = 1;

                for (int i = 2; i <= number; i++)
                {
                    result *= i;
                }

                return result;
            }

          
                Console.Write("Enter a number: ");
                int num = int.Parse(Console.ReadLine());

                long fact = Factorial(num);

                Console.WriteLine($"Factorial of {num} is: {fact}");
            #endregion

            #region Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter
            static string ChangeChar(string input, int position, char newChar)
            {
                if (position < 0 || position >= input.Length)
                {
                    return input; // Invalid position, return original string
                }

                // Convert string to char array to modify it
                char[] chars = input.ToCharArray();
                chars[position] = newChar;

                // Return the new string
                return new string(chars);
            }

            
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                Console.Write("Enter the position to change (0-based): ");
                int pos = int.Parse(Console.ReadLine());

                Console.Write("Enter the new character: ");
                char newChar = Console.ReadKey().KeyChar;

                string result = ChangeChar(text, pos, newChar);

                Console.WriteLine("\nModified string: " + result);
                #endregion






            }
    }
}
