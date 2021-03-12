using System;
using Xunit;

namespace Bonus1.Tests
{
    public class Bonus1Tests
    {
        [Fact]
        public void TestForAnA()
        {
            var testing = new Grade();

            var resultA = testing.LetterGrade(92);

            Assert.Equal("Letter Grade: A", resultA);
        }

        [Fact]
        public void TestForAB()
        {
            var testing = new Grade();

            var resultB = testing.LetterGrade(82);

            Assert.Equal("Letter Grade: B", resultB);
        }

        [Fact]
        public void TestForAC()
        {
            var testing = new Grade();

            var resultC = testing.LetterGrade(75);

            Assert.Equal("Letter Grade: C", resultC);
        }

        [Fact]
        public void TestForAD()
        {
            var testing = new Grade();

            var resultD = testing.LetterGrade(64);

            Assert.Equal("Letter Grade: D", resultD);
        }

        [Fact]
        public void TestForAF()
        {
            var testing = new Grade();

            var resultF = testing.LetterGrade(45);

            Assert.Equal("Letter Grade: F", resultF);
        }
    }
}
