using System;
using Xunit;



namespace TestPierwiastki
{
    public class TestPierwiastki
    {
        [Theory]
        [InlineData(1, -5, 6, 2, 3)]
        [InlineData(2, -4, 2, 1, double.NaN)]
        [InlineData(2, 0, 2, double.NaN, double.NaN)]
        public void TestSolve(double a, double b, double c, double x1, double x2)
        {
            var result = PierwiastekRownaniaKw.Solve(a, b, c);
            if (double.IsNaN(x1))
            {
                Assert.True(double.IsNaN(result.Item1) && double.IsNaN(result.Item2));
            }
            else
            {
                Assert.Equal(x1, result.Item1, 4);
                Assert.Equal(x2, result.Item2, 4);
            }
        }
    }
}
