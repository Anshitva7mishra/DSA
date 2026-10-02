using System;
namespace TreeDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ITreeIO consoleIO = new ConsoleTreeIO();
            BinaryTree tree = new BinaryTree(consoleIO);

            Console.WriteLine("___Tree Creation___");
            tree.CreateTree();

            Console.WriteLine("\n\n___Traversals___");

            Console.Write("Pre-Order: ");
            tree.PreOrder(tree.Root);

            Console.Write("\nIn-Order: ");
            tree.InOrder(tree.Root);

            Console.Write("\nPost_Order: ");
            tree.PostOrder(tree.Root);

            Console.Write("\nLevel-Order: ");
            tree.LevelOrder(tree.Root);

            Console.WriteLine();
        }
    }
}