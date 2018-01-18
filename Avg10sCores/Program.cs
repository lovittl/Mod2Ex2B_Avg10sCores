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

        {
            int i, n, sum = 0;
            double avg;


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
            avg = sum / 10.0;

            string LetGrade = "Grade";
            Console.ReadKey();
            {
                if (avg >= 90 && avg <= 100)
                {
                    LetGrade = "A";
                }
                else if (avg >= 80 && avg <= 89)
                {
                    LetGrade = "B";
                }
                else if (avg >= 70 && avg <= 79)
                {
                    LetGrade = "C";
                }
                else if (avg >= 60 && avg <= 69)
                {
                    LetGrade = "D";
                }
                else if (avg >= 50 && avg <= 59)
                {
                    LetGrade = "F";
                }
                //else
                //{
                  //  Console.WriteLine("numbers entered out of bounds");
                //}
                Console.Write("\nThe Average is : {1}\n", sum, avg);
                Console.WriteLine("Your letter grade is -> " + ($"LetGrade"));
            }
        }       
    }
}
    

