using System;
using Xunit;
using streaks.fs;

namespace streaks.csharp
{
    public class Streaks
    {
        /// <summary>
        /// Invariants
        /// f(0) = [1, 1]
        /// f(i) = [c_i, g_i]
        /// f(i+1) = s(i) == s(i+1) ? [c_i+1, g_i] : [1, max(c_i,g_i)]
        /// </summary>        
        private static (int, string)[] TestCases = new (int, string)[]
        {
            (1, "0"),
            (1, "1"),
            (2, "011"),
            (2, "1001"),
            (3, "100111"),
            (3, "1001110"),
            (4, "101101111011"),
            (4, "000011100")
        };

        [Fact]
        public void Check1()
        {
            foreach(var (length, s) in TestCases) 
            {
                Assert.Equal(length, CSharpSolution.ComputeLength1(s));
            }
        }

        [Fact]
        public void Check2()
        {
            foreach(var (length, s) in TestCases) 
            {
                Assert.Equal(length, CSharpSolution.ComputeLength2(s));
            }
        }

        [Fact]
        public void Foo()
        {
            foreach(var (length, s) in TestCases) 
            {
                Assert.Equal(length, streaks.fs.FsSolution.ComputeLength(s));
            }
        }
    }
}
