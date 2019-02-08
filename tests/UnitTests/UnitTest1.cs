using System;
using Xunit;

namespace UnitTests
{
    public class MusicControllerTests
    {
        [Fact]
        public void Squareofnum()
        {
            var expected = 1;
            var a = 1;
            
            var actual = Square(a);
            Assert.Equal(expected, actual);
        }

      
        
        [Theory]
        [InlineData(4,2)]
        [InlineData(49, 7)]
        [InlineData(9, 3)]
        public void square_WorksWithManyInputs(int exp, int n1)
        {
            Assert.Equal(exp, Square(n1));
        }



        // for more see https://xunit.github.io/docs/getting-started/netcore/cmdline

        int Square(int x)
        {
            return x*x;
        }

    }
}
