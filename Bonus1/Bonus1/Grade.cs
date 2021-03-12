using System;
using System.Collections.Generic;
using System.Text;

namespace Bonus1
{
    public class Grade
    {
        public string LetterGrade(int grade)
        {
            string end = "";
            if (grade >= 88 && grade <= 100)
            {
                end = "Letter Grade: A";
            }
            else if (grade >= 80 && grade <= 87)
            {
                end = "Letter Grade: B";
            }
            else if (grade >= 67 && grade <= 79)
            {
                end = "Letter Grade: C";
            }
            else if (grade >= 60 && grade <= 66)
            {
                end = "Letter Grade: D";
            }
            else if (grade < 60)
            {
                end = "Letter Grade: F";
            }
            return end;
        }
    }
}
