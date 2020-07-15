using System;

using System.Collections.Generic;


namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1ST question\n");
            Console.WriteLine(Utility.LastWord(2,"Welcome to this world", ' ' ));
            Console.WriteLine("3RD question\n");
            Console.WriteLine($"The conversion of 45 d C to Farenheit is: {TemperatureConverter.Cel2Far(45)}");

            Console.WriteLine($"The conversion of 45 d F to Celcius is: {TemperatureConverter.Far2Cel(45)}");
            Console.WriteLine("------ \n \n");
            {
                Utility ut = new Utility();
                string[] str1 = { "coc", "fghhgf", "hjkl" };
                Console.WriteLine("String before palindrome check");
                foreach (var item in str1)
                {
                    Console.WriteLine(item);
                }
                List<string> strr = new List<string>();
                strr = ut.GetPalindromes(str1);
                Console.WriteLine("String After palindrome check");
                foreach (var item in strr)
                {
                    Console.WriteLine(item);

                }


            }
        }
    }
}
