using BusinessLayer.Service;
using Xunit;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void TestMuliply()
        {
            //Arrange
            TestMethods test = new TestMethods();

            //Act
            var result = test.TestMuliply(5, 10);

            //Assert
            Assert.Equal(50, result);
        }

        [Fact]
        public void TestDivide()
        {
            //Arrange
            TestMethods test = new TestMethods();

            //Act
            var result = test.TestDivide(10, 5);

            //Assert
            Assert.Equal(2, result);
        }

        [Theory]
        [InlineData(3, 2, 6)]
        [InlineData(7, 4, 28)]

        public void TestMuliplyMany(int a, int b, int c)
        {
            //Arrange
            TestMethods test = new TestMethods();

            //Act
            var result = test.TestMuliply(a, b);

            //Assert
            Assert.Equal(c, result);
        }
    }
}