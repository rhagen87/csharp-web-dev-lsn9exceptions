using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by zero.");
            }
            else
            {
                return x / y;
            }            
        }

        
        static int CheckFileExtension(string fileName)
        {
            int points = 0;
            if (fileName.EndsWith(".cs"))
            {
                points += 1;
            }
            else if(fileName == null || fileName == "")
            {
                throw new ArgumentNullException("Filename cannot be 'null' or empty.");
            }
            return points;
        }
        


        static void Main(string[] args)
        {
            try
            {
                Divide(5, 0);
            }
            catch(ArgumentOutOfRangeException)
            {
                Console.WriteLine("Cannot divide by zero.");
            }

            // Test out your CheckFileExtension() function here!
            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode.cs");
            students.Add("Stefanie", "CoolProgram.cs");
            
            foreach (KeyValuePair<string, string> student in students)
            {
                try
                {
                    CheckFileExtension(student.Value);
                    Console.WriteLine(student.Key + "'s points added.");
                }
                catch(ArgumentNullException)
                {
                    Console.WriteLine("Null exception caught.");
                }
            }


        }
    }
}
