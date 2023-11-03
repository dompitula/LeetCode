//
// Solution to LeetCode problem #1441 - Build an Array With Stack Operations.
//

namespace LeetCode
{
    /// <summary>
    /// Responsible for running the code.
    /// </summary>
    internal class BuildArrayWithStackOperations
    {

        /// <summary>
        /// Builds array that contains instructions to replicate target array.
        /// </summary>
        /// <param name="target"> given array </param>
        /// <param name="n"> biggest number in the given array </param>
        /// <returns> List of the words that instruct how to get targeted array. </returns>
        public IList<string> BuildArray(int[] target, int n)
        {

            List<string> result = new List<string>();
            int targetId = 0;

            for (int i = 1; i <= n; i++)
            {
                if (targetId == target.Length) break;

                result.Add("Push");

                if (target[targetId] == i)
                {
                    targetId++;
                }
                else
                {
                    result.Add("Pop");
                }
            }

            return result.ToArray();
        }
    }
}

/// Paste in Main to run.
/*static void Main(string[] args)
{
    BuildArrayWithStackOperations solution = new BuildArrayWithStackOperations();
    int[] target = new int[] { 1, 3 };
    int n = 10;

    IList<string> result = solution.BuildArray(target, n);

    foreach (string item in result)
    {
        Console.WriteLine(item);
    }
}*/