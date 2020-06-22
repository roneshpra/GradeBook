using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            var x = 5;
            var y = 2;
            var expected = 7;

            //Act
            var actual = x + y;

            //Assert
           Assert.Equal(expected, actual); 

        }
    }
}
