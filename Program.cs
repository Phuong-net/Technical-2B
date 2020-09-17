/*
    Author: Phuong Nguyen
   Date: 09/16/2020
   Comment: This C# Console application code demonstrates the use of conditional statements after getting input from users
*/


using System;

namespace Technical_2b
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
               //Ask the user to input their expected grade for ISM 
            
               
                Console.WriteLine("Please enter an interger value of the grade you expect to get in ISM4300:");

            try
            {
                int grade;
                grade = int.Parse(Console.ReadLine());
            
              
                if ((grade >= 90) && (grade <=100)) Console.WriteLine("Grade A");
                else if ((grade >= 80) && (grade < 90)) Console.WriteLine("Grade B");
                else if ((grade >= 70) && (grade < 60)) Console.WriteLine("Grade C");
                else if (grade > 50) Console.WriteLine("Grade D");
                else if ((grade < 50)) Console.WriteLine("Grade F");
                else Console.WriteLine("Invalid input");

                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an interger value for your expected graded next time");
                Console.WriteLine("Press any key to exit the program and try again");
                Console.ReadKey(true);
            }
        }
            

        }
    }


