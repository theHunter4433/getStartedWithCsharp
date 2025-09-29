using System;

namespace calculate_PritnStudentGrade
{
    class cPSG
    {
        static void Main(string[] args)
        {
            /*In this proyect i'll be able to:
             *Learn to develop basic applications by breaking down the work intro smaller parts
             *Identify appropriate data types for storing and working with variables
             *Perform mathematical operations to determine results
             *Apply formatting techniques to display output*/


            //Proyect Overview
            /*You're given a short list of four students and their five assignment grades.
            *Each assignment grade is expressed as an integer value, 0-100, where 100 represents 100% correct.
            *Final scores are calculated as an average of the five assignment scores.
            *Your application needs to perform basic math operations to calculate the final grades for each student.
            *Your application needs to output/display each student’s name and final score.*/

            // Call the method to execute the exercise
            decimal[] studentGrade = new decimal[4] {0, 0, 0, 0};
            int[,] assigmentGrades = new int[4,5]
            {
                {93, 87, 98, 95, 100},// Sophia
                {80, 83, 82, 88, 85},// Nicolas
                {84, 69, 73, 85, 79},// Zahirah
                {90, 92, 98, 100, 97}// Jeong
            };

            // Calculate the average grade for each student
            for (int i = 0; i < assigmentGrades.GetLength(0); i++)// colums
            {
                int sum = 0;
                for (int j = 0; j < assigmentGrades.GetLength(1); j++)// rows
                {
                    // Sum the grades for the current student
                    sum += assigmentGrades[i, j];
                }
                // Calculate the average and store it in the studentGrade array
                studentGrade[i] = sum / (decimal)assigmentGrades.GetLength(1);
            }
            // Display the final grades for each student
            decimal sophiaGrade = studentGrade[0];
            decimal nicolasGrade = studentGrade[1];
            decimal zahirahGrade = studentGrade[2];
            decimal jeongGrade = studentGrade[3];

            Console.Write("Student\t\tGrade\n");
            Console.WriteLine($"Sophia:\t\t{sophiaGrade}\tA");
            Console.WriteLine($"Nicolas:\t{nicolasGrade}\tB");
            Console.WriteLine($"Zahirah:\t{zahirahGrade}\tB");
            Console.WriteLine($"Jeong:\t\t{jeongGrade}\tA\n\n");
        }

        public static void ExercideOtherForm()
        {
            // initialize variables - graded assignments 
            int currentAssignments = 5;

            int sophia1 = 93;
            int sophia2 = 87;
            int sophia3 = 98;
            int sophia4 = 95;
            int sophia5 = 100;

            int nicolas1 = 80;
            int nicolas2 = 83;
            int nicolas3 = 82;
            int nicolas4 = 88;
            int nicolas5 = 85;

            int zahirah1 = 84;
            int zahirah2 = 96;
            int zahirah3 = 73;
            int zahirah4 = 85;
            int zahirah5 = 79;

            int jeong1 = 90;
            int jeong2 = 92;
            int jeong3 = 98;
            int jeong4 = 100;
            int jeong5 = 97;

            // calculate the sum of each student's grades
            int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

            // calculate the average for each student
            decimal sophiaGrade = sophiaSum / (decimal)currentAssignments;
            decimal nicolasGrade = nicolasSum / (decimal)currentAssignments;
            decimal zahirahGrade = zahirahSum / (decimal)currentAssignments;
            decimal jeongGrade = jeongSum / (decimal)currentAssignments;

            // show the results
            Console.WriteLine("Student\t\tGrade");
            Console.WriteLine($"Sophia\t\t{sophiaGrade}\tA");
            Console.WriteLine($"Nicolas\t\t{nicolasGrade}\tB");
            Console.WriteLine($"Zahirah\t\t{zahirahGrade}\tB");
            Console.WriteLine($"Jeong\t\t{jeongGrade}\tA");
        }
    }
}