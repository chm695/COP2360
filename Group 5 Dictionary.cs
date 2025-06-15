//Create a Switch Statement: Implement a switch statement that allows the user to perform the following tasks:
//a.Populate the Dictionary: Add keys and values determined by your group.
//b. Display Dictionary Contents: Show the contents of the dictionary using any of the three enumeration methods covered in Module 7.
//c. Remove a Key: Remove a specified key from the dictionary.

using System;
using System.Collections.Generic;
using static System.Net.Mime.MediaTypeNames;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GroupProject
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("These grades are final!");
            // Create a dictionary to store grades and their corresponding letter grades

            Dictionary<int, string> testgradesofTheSemester = new();
            testgradesofTheSemester.Add(100, "A");
            testgradesofTheSemester.Add(80, "B");
            testgradesofTheSemester.Add(70, "C");
            testgradesofTheSemester.Add(60, "D");
            testgradesofTheSemester.Add(50, "F");
            testgradesofTheSemester.Add(40, "F-");
            testgradesofTheSemester.Remove(40);

            // Populate the dictionary the dictionary
            foreach (var gradeEntry in testgradesofTheSemester)
            {
                Console.WriteLine($"Grade: {gradeEntry.Key}, Letter Grade: {gradeEntry.Value}");
            }

            //Type your grade to see if you passed or failed.
            Console.WriteLine("Please enter your grade:");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case >= 100:
                    Console.WriteLine("You got an A!");
                    break;
                case >= 80:
                    Console.WriteLine("You got a B!");
                    break;
                case >= 70:
                    Console.WriteLine("You got a C!");
                    break;
                case >= 60:
                    Console.WriteLine("You got a D!");
                    break;
                case >= 50:
                    Console.WriteLine("You got an F!");
                    break;
                default:
                    Console.WriteLine("Invalid grade entered or you failed the class.");
                    break;
            }
            // Display the contents of the dictionary using an enumeration method
            Console.WriteLine(GradeLevel.A + " is wonderful grade to have!");
            Console.WriteLine(GradeLevel.B + " is a good grade to have!");
            Console.WriteLine(GradeLevel.C + " is an average grade to have!");
            Console.WriteLine(GradeLevel.D + " is a passing grade to have!");
            Console.WriteLine(GradeLevel.F + " is a failing grade to have!");

            Console.ReadKey();

        }

    }
    enum GradeLevel
    {
        A = 100,
        B = 80,
        C = 70,
        D = 60,
        F = 50,
        FMinus = 40
    }
}
