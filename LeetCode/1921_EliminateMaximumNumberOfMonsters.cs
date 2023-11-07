//
// Solution to LeetCode problem #1921 - Eliminate Maximum Number of Monsters
//

namespace LeetCode
{
    /// <summary>
    /// Responsible for running the code.
    /// </summary>
    public class EliminateMaximumNumberOfMonsters
    {

        /// <summary>
        /// Simulates how many monsters would be defeated before they
        /// arrive at the destination at given speed
        /// </summary>
        /// <param name="dist"> monsters' distance from the destination </param>
        /// <param name="speed"> monsters' speed at which they are heading towards
        /// the destination </param>
        /// <returns> integer number of how many monsters will be eliminated </returns>
        public int EliminateMaximum(int[] dist, int[] speed)
        {
            int n = dist.Length;
            int eliminated = 0;
            int[] timeToArrive = new int[n];


            // Ceiling of estimated time for the monsters to arrive at the destination
            for (int i = 0; i < n; i++)
            {
                timeToArrive[i] = (dist[i] + speed[i] - 1) / speed[i];
            }

            Array.Sort(timeToArrive);

            for (int i = 0; i < n; i++)
            {
                if (timeToArrive[i] <= i)
                {
                    return eliminated;
                }

                ++eliminated;
            }

            return eliminated;
        }
    }
}

/// Paste in Main method to run.
/*
    EliminateMaximumNumberOfMonsters Elim = new EliminateMaximumNumberOfMonsters();
    int[] mon = { 1, 3, 4 };
    int[] speed = { 1, 1, 1 };

    Console.WriteLine(Elim.EliminateMaximum(mon, speed));
*/