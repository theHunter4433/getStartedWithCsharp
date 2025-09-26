using System;

namespace performBasicOperationNumbers
{
    class pBON
    {
        static void Main(string[] args)
        {
            /*Perform mathematical operations on numceric values
              Obseve implicit type converion between strings and numeric values
              Temporarily convert one data type into another*/

            //Add tow numerics values
            int firstNumber = 12;
            int secondNumber = 7;
            Console.WriteLine(firstNumber + secondNumber + "\n\n");

            //Mix data types to force implicit type conversion 
            string firstName = "Alex";
            int widgestsSold = 17;
            Console.WriteLine(firstName + " Sold " + widgestsSold + 7 + " widgest.");//Concatenation
            Console.WriteLine(firstName + " Soid " + widgestsSold + " widgest.\n");
            Console.WriteLine($"{firstName} sold {widgestsSold}{7} widgest.");//Interpolation-Not necesary for this example
            Console.WriteLine($"{firstName} sold {widgestsSold} widgest.\n");

            //Add parentheses to clarify your intent
            Console.WriteLine($"{firstName} sold {widgestsSold + 7} widgest.\n\n");//Output 24

            //Substraction, Multiplication and Division
            int sum = 7 + 5;
            int sub = 7 - 5;
            int product = 7 * 5;
            int quotient = 7 / 5;

            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {sub}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}\n\n");

            //Add code to cast result of integer division
            int first = 7;
            int seconf = 5;
            decimal quotient1 = (decimal)first / (decimal)seconf;
            Console.WriteLine(quotient1 + "\n\n");

            //Integer division for modulus operator
            Console.WriteLine($"Modulus of 200 / 5: {200 % 5}");
            Console.WriteLine($"Modulus of 7 / 5: {7 % 5}\n\n");

            //Order of operaartions 
            int value1 = 3 + 4 * 5;
            int vaule2 = (3 + 4) * 5;
            Console.WriteLine(value1);
            Console.WriteLine(vaule2 + "\n\n");

            Exercise_iDV();

            FtoC();
        }

        public static void Exercise_iDV()
        {
            //ASSIGNMENT OPERATORS
            //Increment and Decrement Variables
            int vaule = 0;      //Initialize vaule to 0
            vaule = vaule + 5;  //Value is now 5
            vaule += 5;         //Value is now 10

            int vaule1 = 0;     //Initialize vaule to 0
            vaule1 = vaule1 + 1;//Value is now 1
            vaule1++;           //Value is now 2

            int vaule2 = 1;

            vaule2 = (vaule2 + 1);
            Console.WriteLine("First increment: " + vaule2);//Value is now 2

            vaule2 += 1;
            Console.WriteLine("Second incremenr: " + vaule2);//Value is now 3

            vaule2++;
            Console.WriteLine("Third increment: " + vaule2);//Value is now 4

            vaule2 = vaule2 - 1;
            Console.WriteLine("First decrement: " + vaule2);//Value is now 3

            vaule2 -= 1;
            Console.WriteLine($"Second decrement: {vaule2}");//Value is now 2

            vaule2--;
            Console.WriteLine($"Third decrement: {vaule2}\n\n");//Value is now 1

            //Increment and decrement before and after the vaule
            int valor = 1;
            valor++;
            Console.WriteLine($"First increment: {valor}");//Value is now 2
            Console.WriteLine($"Second increment: {valor++}");//Value is now 2, but prints 3
            Console.WriteLine($"Third increment: {valor}");//Value is now 3
            Console.WriteLine($"FouRth increment: {++valor}\n\n");//Value is now 4 and prints 4
        }

        public static void FtoC()//Challenge: Fahrenheit to Celsius
        {
            int Fahrenheit = 94;
            float celsius = (Fahrenheit - 32) * 5 / 9;
            Console.WriteLine($"The temperature is {celsius} Celsius.\n");

            int Celcius = 99;
            float fharenheit = (Celcius * 9 / 5) + 32;
            Console.WriteLine($"The temperature is {fharenheit} fharenheit");
        }
    }
}