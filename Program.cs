using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input the number of subjects
            Console.Write("Enter the number of subjects: ");
            double numberOfSubjects = Convert.ToDouble(Console.ReadLine());

            // Initialize variables to store total marks
            double totalMarks = 0;

            // Loop to get marks for each subject
            for (int i = 1; i <= numberOfSubjects; i++)
            {
                Console.Write("Enter marks for subject {0}: ", i);
                double marks = Convert.ToInt32(Console.ReadLine());
                totalMarks += marks;
            }

            // Calculate percentage
            double percentage = totalMarks / numberOfSubjects;

            // Display total marks and percentage
            Console.WriteLine("Total Marks: {0}", totalMarks);
            Console.WriteLine("Percentage: {0:F2}%", percentage);

            // Determine grade based on percentage
            string grade;
            if (percentage >= 90)
            {
                grade = "A+";
            }
            else if (percentage >= 80)
            {
                grade = "A";
            }
            else if (percentage >= 70)
            {
                grade = "B";
            }
            else if (percentage >= 60)
            {
                grade = "C";
            }
            else if (percentage >= 50)
            {
                grade = "D";
            }
            else
            {
                grade = "F";
            }

            // Display the corresponding grade
            Console.WriteLine("Grade: {0}", grade);
        }
    }
}
