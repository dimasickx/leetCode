namespace InorderTraversal
{
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

    public class Solution
    {

        

        public IList<int> InorderTraversal2(TreeNode root)
        {
            var result = new List<int>();
            var stack = new Stack<TreeNode>();
            var current = root;
            while (stack.Count != 0 || current != null)
            {
                while (current != null)
                {
                    stack.Push(current);
                    current = current.left;
                    
                }
                current = stack.Pop();
                result.Add(current.val);
                current = current.right;
            }
            return result;
        }

        public IList<int> InorderTraversal1(TreeNode root)
        {
            return Recursion(root, new List<int>());
        }

        private IList<int> Recursion(TreeNode node, IList<int> list)
        {
            if (node == null)
                return list;
            Recursion(node.left, list);
            list.Add(node.val);
            Recursion(node.right, list);
            return list;
           
            
        }
    }

    public class Program
    {
        public static void Main()
        {
           
        }
    }
}