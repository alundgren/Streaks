using System;

namespace Streaks.CSharp
{
    public class CSharpSolution 
    {
        public static int ComputeLength1(string s)
        {
            (int, int) f(int i) 
            {
                if(i == 0)
                    return (1, 1);

                var (c, g) = f(i-1);
                return s[i] == s[i - 1]
                    ? (c + 1, g)
                    : (1, Math.Max(c, g));
            }
            var (c,g) = f(s.Length - 1);
            return Math.Max(c, g);
        }

        public static int ComputeLength2(string s) 
        {
            int f(int i, int c, int g) =>
                i == 0
                    ? Math.Max(c, g)
                    : (s[i] == s[i - 1] 
                        ? f(i - 1, c + 1, g) 
                        : f(i - 1, 1, Math.Max(c, g)));
            return f(s.Length - 1, 1, 1);
        }
    }
}   