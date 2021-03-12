using System;

namespace Bonus1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Letter Grade Converter!" + "\n");

            var getGrade = new Grade();
            string answer;
            do
            {
                Console.Write("Enter a numerical grade: ");
                var grade = int.Parse(Console.ReadLine());
                Console.WriteLine(getGrade.LetterGrade(grade));

                Console.WriteLine("Continue? (y/n): ");
                answer = Console.ReadLine();
            } while (answer == "y" || answer == "Y");


            Console.WriteLine("Goodbye!");
        }


    }
}
