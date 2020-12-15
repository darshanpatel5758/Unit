using System;
using Testing;
using Xunit;



namespace Unit_Testing_Part1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var sut =  new TempCon();
            var expected = 0;

            var result = sut.TempConvert(32, 'f');

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(32, 'f',0)]
        [InlineData(68, 'f',20)]
        [InlineData(100, 'c',212)]
        [InlineData(-40, 'c',-40)]
        public void Test2(double number, char system, double output)
        {
            var sut = new TempCon();
           
            var result = sut.TempConvert(number, system);

            Assert.Equal(output, result);
        }
       
    }
}
