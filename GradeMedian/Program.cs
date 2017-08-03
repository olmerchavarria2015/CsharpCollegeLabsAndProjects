//***********************************************************************
//Filename: 
// Written by: Olmer Chavarria
// Date: 03/22/2017
// ITSE-2453-53400
// Lab: 1
// Description: This program calculates the medium grade. The median grade is the middle grade.
//  If there are an even number of grades, the median is the average of the middle two grades.
//***********************************************************************
using System;


namespace Lab01_GradeMedian
{
    class Program
    {
       
        static void methodTakeArray(float [] fArray) //this method takes an array of grades, sorts it out and then returns the median of those grades.
        {
            float medium;
            Array.Sort(fArray);//Sorts the array of grades.
            if (fArray.Length % 2 == 0)
            {
                medium = (fArray[fArray.Length / 2] + fArray[(fArray.Length / 2) - 1]) / 2;
                Console.WriteLine("Medium grade is " + medium);
            }
            else {
                medium = fArray[(fArray.Length - 1 )/ 2];
                Console.WriteLine("Medium grade is " + medium);
               
            }
            
        }
          
        static void Main(string[] args)
        {
            int NumberOfGrades;
            float[] grades;
            
            
            Console.Write("Please enter the number of grades: ");
            
            int.TryParse(Console.ReadLine(), out NumberOfGrades);//Use at least one reference or output parameter.
            grades =new float[NumberOfGrades];
            if (grades.Length > 1 && grades.Length <= 20) //Handle up to 20 grades.
            {
                for (int i = 0; i < grades.Length; i++)
                {
                    Console.Write("Please enter grade #" + (i + 1) + ": ");//Populates the array.
                    float.TryParse(Console.ReadLine(), out grades[i]); //Store the grades in an array.
                }
                Program.methodTakeArray(grades);
                Console.ReadLine();
            }
            else {
                Console.WriteLine("wrong input try again");
                Console.ReadLine();
            }

           
            
            
        }


    }
}
