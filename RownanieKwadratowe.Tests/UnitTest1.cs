using Xunit;
using RownanieKwadratowe;

namespace RownanieKwadratowe.Tests
{
    public class QuadraticEquationSolverTests
    {
        [Fact]
        public void Test_Zero_Delta()
        {
            var (x1, x2) = QuadraticEquationSolver.Solve(1, 2, 1);
            Assert.Equal(-1, x1);
            Assert.Null(x2); // Testuje jedno rozwiązanie jako x1 i null jako x2
        }
    }
}

