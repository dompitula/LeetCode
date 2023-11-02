/*
 * 2265. Count Nodes Equal to Average of Subtree
 * Given the root of a binary tree, 
 * return the number of nodes where the value of the node is equal to the average of the values in its subtree.
 */

namespace LeetCode
{
    /// <summary>
    /// This class is responsible for running the code for Count Nodes Equal to Average of Subtree task.
    /// </summary>
    internal class AverageOfSubtree
    {

        /// <summary>
        /// Tree Node Constructor Class
        /// </summary>
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }

        private int count = 0;

        /// <summary>
        /// Calculates the number of subtrees with the average value equal to the root node's value.
        /// </summary>
        /// <param name="root"> Tree Node root input </param>
        /// <returns> average of the node that fits the criterea </returns>
        public int Average(TreeNode root)
        {
            if (root == null) return 0;
            PreOrder(root);

            return count;
        }

        /// <summary>
        /// performs a pre-order traversal of the binary tree to compute the sum
        /// and count of nodes in each subtree and check if the subtree's average equals the root value.
        /// </summary>
        /// <param name="root"> given Tree Node </param>
        /// <returns> sum of node children and count of the nodes </returns>
        private int[] PreOrder(TreeNode root)
        {
            if (root == null) return new int[] { 0, 0 };

            int[] left = PreOrder(root.left);
            int[] right = PreOrder(root.right);

            int sum = left[0] + right[0] + root.val;
            int n = left[1] + right[1] + 1;
            int total = sum / n;

            if (total == root.val) count++;

            return new int[] { sum, n };
        }
    }
}

/// Paste this in Main method to run the code
/*static void Main(string[] args)
{
    AverageOfSubtree.TreeNode root = new AverageOfSubtree.TreeNode(4);
    root.left = new AverageOfSubtree.TreeNode(8);
    root.right = new AverageOfSubtree.TreeNode(5);
    root.left.left = new AverageOfSubtree.TreeNode(0);
    root.left.right = new AverageOfSubtree.TreeNode(1);
    root.left.left.right = new AverageOfSubtree.TreeNode(6);

    AverageOfSubtree solution = new AverageOfSubtree();
    int result = solution.Average(root);

    Console.WriteLine("Number of subtrees with the average value equal to the root node's value: " + result);
}*/