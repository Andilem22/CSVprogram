using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CSVprogram
{
    class Program
    {
        static void Main()
        {
           //my csv file sitting on my desktop
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Andilem\source\csvprogram.csv");

            // Display the file contents by using a foreach loop.
            System.Console.WriteLine("Contents of WriteLines2.txt = ");
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                Console.WriteLine("\t" + line);
            }
            //1.

            //2.

            

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}

