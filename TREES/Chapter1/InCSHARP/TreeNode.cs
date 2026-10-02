namespace TreeDataStructure
{
    public class TreeNode
    {
        public int Data { get; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }

        public TreeNode(int data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }
}