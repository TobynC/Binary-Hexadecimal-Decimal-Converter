using System;

namespace DecimalConverter
{
    public class Manager
    {
       public static void Main(string[] args)
       {
            Console.WriteLine("1. Decimal=>Binary\n2. Hexadecimal=>Binary");
            var conversionResponse = Console.ReadLine();

            if (conversionResponse != null && conversionResponse.Equals("1"))
            {
                Console.WriteLine("Enter a decimal number to convert.");
                var input = Console.ReadLine();

                try
                {
                    if (input != null)
                    {
                        var intInput = long.Parse(input);

                        Binary convert = new Binary(intInput);
                        convert.ConvertToBinary();

                        Console.WriteLine("Converted Value is: ");
                        Console.WriteLine(convert.Print());
                    }
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }
            }
            else if (conversionResponse != null && conversionResponse.Equals("2"))
            {
                Console.WriteLine("Enter a hexadecimal number to convert.");
                var input = Console.ReadLine();

                try
                {
                    Hexidecimal convert = new Hexidecimal(input);

                    convert.Convert();
                    Console.WriteLine("Converted Value is: ");
                    Console.WriteLine(convert.Print());
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid Response");
            }

            Console.ReadLine();
       }
    }
}
