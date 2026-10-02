using System;
using System.Collections.Generic;

namespace TreeDataStructure
{
    public class BinaryTree
    {
        private readonly ITreeIO _io;
        public TreeNode Root { get; private set; }

        public BinaryTree(ITreeIO io)
        {
            _io = io ?? throw new ArgumentNullException(nameof(io));
        }

        public void CreateTree()
        {
            Root = BuildTreeInteractively("root node");
        }

        private TreeNode BuildTreeInteractively(string positionContext)
        {
            int data = _io.GetIntInput($"Enter {positionContext} (-1 for null): ");

            if(data == -1) return null;

            TreeNode node = new TreeNode(data);

            node.Left = BuildTreeInteractively($"left child of {data}");
            node.Right = BuildTreeInteractively($"right child of {data}");

            return node;
        }

        public void PreOrder(TreeNode node)
        {
            if(node == null) return;
            _io.Output(node.Data.ToString());
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(TreeNode node)
        {
            if(node == null) return;
            InOrder(node.Left);
            _io.Output(node.Data.ToString());
            InOrder(node.Right);
        }

        public void PostOrder(TreeNode node)
        {
            if(node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            _io.Output(node.Data.ToString());
        }

        public void LevelOrder(TreeNode root)
        {
            if(root == null) return;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while(queue.Count > 0){
                TreeNode current = queue.Dequeue();
                _io.Output(current.Data.ToString());

                if(current.Left != null) queue.Enqueue(current.Left);
                if(current.Right != null) queue.Enqueue(current.Right);
            }
        }
    }
}