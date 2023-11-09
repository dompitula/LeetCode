//
// Solution to LeetCode problem #1759 - Count Number of Homogenous Substrings
//

namespace LeetCode
{
    internal class CountNumberOfHomogenousSubstrings
    {

        /// <summary>
        /// Checks for every continous appearance of character or character sequence
        /// </summary>
        /// <param name="s"> string of character groups </param>
        /// <returns> integer sum of appearances of characters </returns>
        public int CountHomogenous(string s)
        {
            const int MOD = 1000000007;
            long result = 0;
            int record = 0;
            char last = new char();

            foreach (char c in s)
            {
                if (c == last)
                {
                    ++record;
                }
                else
                {
                    record = 1;
                }

                last = c;
                result = (result + record) % MOD;
            }


            return (int)result;
        }
    }
}

/// Paste in Main method to run.
/*
CountNumberOfHomogenousSubstrings solution = new CountNumberOfHomogenousSubstrings();

// Example 1
Console.WriteLine(solution.CountHomogenous("abbcccaa")); // Output: 13

// Example 2
Console.WriteLine(solution.CountHomogenous("xy")); // Output: 2

// Example 3
Console.WriteLine(solution.CountHomogenous("zzzzz")); // Output: 15
*/