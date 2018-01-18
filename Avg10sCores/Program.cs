using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Average ten scores
Create a console application that will accept ten test scores between 0 and 100, 
average them, and report a letter grade for the average based on the usual scale.
For example, a teacher will input ten test scores and see the average numerical grade 
and the letter grade.
*/

namespace Avg10sCores
{
    class Program
    {
        static void Main(string[] args)

        {  // declare values to hold test values and perform calculation
            int i, n, sum = 0;
            double avg;
            string LetGrade;

            //illicit input
            Console.Write("\n\n");
            Console.Write("Enter 10 scores between 0 and 100 and calculate Average:\n");
            Console.Write("----------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 10 numbers : \n");

            for (i = 1; i <= 10; i++)
            {
                Console.Write("Number-{0} :", i);

                n = Convert.ToInt32(Console.ReadLine());
                sum += n;
            }
            //calculate average and assign to varabila avg
            avg = sum / 10.0;

            Console.Write("\nThe Average is : {0}\n",avg);
            Console.WriteLine("Your letter grade is :  {GetGrade(avg)}");
        }  // end main

        //assigns a letter grade based on numerical value
        static char GetGrade(int LetGrade)
        {
            int avg = 0;
            char let;
            Console.ReadKey();
            if (avg >= 90 && avg <= 100)
            {
                let = 'A';
            }
            else if (avg >= 80 && avg <= 89)
            {
                let = 'B';
            }
            else if (avg >= 70 && avg <= 79)
            {
                let = 'C';
            }
            else if (avg >= 60 && avg <= 69)
            {
                let = 'D';
            }
            else if (avg >= 50 && avg <= 59)
            {
                let = 'F';
            }
            else
            {
                Console.WriteLine("numbers entered out of bounds");
                return 'x';
            }
            
            return let;
        }


      
    }

 
}