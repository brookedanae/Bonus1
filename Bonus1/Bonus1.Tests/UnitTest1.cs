using System;
using Xunit;

namespace Bonus1.Tests
{
    public class Bonus1Tests
    {
        [Fact]
        public void TestForLowA()
        {
            var testing = new Grade();

            var resultA = testing.LetterGrade(88);

            Assert.Equal("Letter Grade: A", resultA);

        }
        [Fact]
        public void TestForHighA()
        {
            var testing = new Grade();

            var resultA1 = testing.LetterGrade(100);

            Assert.Equal("Letter Grade: A", resultA1);

        }

        [Fact]
        public void TestForLowB()
        {
            var testing = new Grade();

            var resultB = testing.LetterGrade(80);

            Assert.Equal("Letter Grade: B", resultB);
        }

        [Fact]
        public void TestForHighB()
        {
            var testing = new Grade();

            var resultB1 = testing.LetterGrade(87);

            Assert.Equal("Letter Grade: B", resultB1);
        }

        [Fact]
        public void TestForLowC()
        {
            var testing = new Grade();

            var resultC = testing.LetterGrade(67);

            Assert.Equal("Letter Grade: C", resultC);
        }

        [Fact]
        public void TestForHighC()
        {
            var testing = new Grade();

            var resultC1 = testing.LetterGrade(79);

            Assert.Equal("Letter Grade: C", resultC1);
        }

        [Fact]
        public void TestForLowD()
        {
            var testing = new Grade();

            var resultD = testing.LetterGrade(60);

            Assert.Equal("Letter Grade: D", resultD);
        }
        [Fact]
        public void TestForHighD()
        {
            var testing = new Grade();

            var resultD1 = testing.LetterGrade(66);

            Assert.Equal("Letter Grade: D", resultD1);
        }

        [Fact]
        public void TestForLowF()
        {
            var testing = new Grade();

            var resultF = testing.LetterGrade(0);

            Assert.Equal("Letter Grade: F", resultF);
        }

        [Fact]
        public void TestForHighF()
        {
            var testing = new Grade();

            var resultF1 = testing.LetterGrade(59);

            Assert.Equal("Letter Grade: F", resultF1);
        }
    }
}
