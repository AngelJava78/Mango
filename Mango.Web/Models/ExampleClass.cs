using System;
namespace Mango.Web.Models
{
    /// <summary>
    /// Esta clase contiene bugs, vulnerabilidades y codigo duplicado
    /// </summary>
    public class ExampleClass
    {
        private int exampleInt = 0;

        public void ExampleMethod(int exampleParam)
        {
            if (exampleParam == 0)
            {
                Console.WriteLine("The parameter is 0");
            }

            if (exampleParam == 1)
            {
                Console.WriteLine("The parameter is 1");
            }

            if (exampleParam > 1 && exampleParam < 5)
            {
                Console.WriteLine("The parameter is between 2 and 4");
            }

            if (exampleParam > 5)
            {
                Console.WriteLine("The parameter is greater than 5");
            }

            int a = 0;
            int b = 5 / a;

            if (exampleInt == 1)
            {
                Console.WriteLine("The integer is 1");
            }

            if (exampleInt == 2)
            {
                Console.WriteLine("The integer is 2");
            }

            if (exampleInt > 2 && exampleInt < 5)
            {
                Console.WriteLine("The integer is between 3 and 4");
            }

            if (exampleInt > 5)
            {
                Console.WriteLine("The integer is greater than 5");
            }

            string exampleString = "ExampleString";

            Console.WriteLine(exampleString.ToLower());
            Console.WriteLine(exampleString.ToUpper());

            if (exampleString.Equals("examplestring"))
            {
                Console.WriteLine("The string is equal to 'examplestring'");
            }

            if (exampleString == "examplestring")
            {
                Console.WriteLine("The string is equal to 'examplestring'");
            }

            if (exampleString.Contains("string"))
            {
                Console.WriteLine("The string contains 'string'");
            }

            if (exampleString.StartsWith("Example"))
            {
                Console.WriteLine("The string starts with 'Example'");
            }

            if (exampleString.EndsWith("String"))
            {
                Console.WriteLine("The string ends with 'String'");
            }
        }

        public void ExampleMethod2()
        {
            try
            {
                int[] array = new int[3];
                array[3] = 5;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
