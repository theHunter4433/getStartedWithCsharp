using System;

namespace performBasicStringFormatting
{
    class pBSF
    {
        static void Main(string[] args)
        {
            /*Create string data containing tabs, new lines, and other special charcaters
              Create string data containing Unicode Characters
              Combine string data into a new string vaule via concatenation
              Combine string data into a new string vaule via interpolation*/

            //Character escape sequences
            Console.WriteLine("Hello\nWorld!");//New line
            Console.WriteLine("Hello\tWrold!");//Tab
            Console.WriteLine("Hello \"Wrold\"!");//Double quote
            Console.WriteLine("c:\\source\\repos\n\n");//Backslash

            //Format output using character scape sequences
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tCompelte!");
            Console.WriteLine("\nOutput Directory:\t");

            //Verbatim string literal
            Console.WriteLine(@"    c:\source\repos
          (This is where your code goes)" + "\n");

            //Format output using verbatim string literals
            Console.WriteLine(@"c:\invoices");

            //Unicode escape characters
            // Kon'nichiwa (Hello in Japanese)
            Console.WriteLine("\u3053\u3093\u306B\u3061\u306F\n");

            //Format output using Unicode characters
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            Concatenation();

            Interpolation();
        }

        public static void Concatenation()
        {
            Console.WriteLine("\n\nCONCATENATION\n");

            //Concatenate a literal string add a variable
            string firstName = "Alex";
            string message = "Hello " + firstName + ", welcome to the team!";
            Console.WriteLine(message + "\n");

            //Concatenate multiple variables and literals string
            string firstName1 = "Alex";
            string greeting = "Hello";
            string message1 = greeting + " " + firstName1 + ", welcome to the team!";
            Console.WriteLine(message1);

            //Avoiding intermediate variables
            string firstName3 = "Alex";
            string greeting1 = "Hello";
            Console.WriteLine("\n" + firstName3 + " " + greeting1 + "!");

        }

        public static void Interpolation()
        {
            Console.WriteLine("\n\nINTERPOLATION\n");

            //Exemple interpolating a variable into a string
            string firstName = "Alex";
            string greeting = "Hello";
            string message = $"{greeting} {firstName}, welcome to the team!";

            //String interpolation with multiple variables and literal strings
            int version = 11;
            string updateText = "Upsate to Windows";
            string message1 = $"{updateText} {version}";
            Console.WriteLine($"{message1}\n");

            //Avoiding intermediate variables
            Console.WriteLine($"{version} {updateText}\n");

            //Combine verbatim literals and string interpolation
            string projectName = "Fiest-Project";
            Console.WriteLine($@"c:\Output\{projectName}\Data" + "\n");

        }
    }
}