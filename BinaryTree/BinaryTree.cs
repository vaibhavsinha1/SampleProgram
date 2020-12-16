using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode.BinaryTreeTest1
{
    public class Tree
    {
        public TreeNode Root;
    }
    public class TreeNode
    {
        public int Data;
        public TreeNode Left;
        public TreeNode Right;
        public TreeNode NextRight;

        public TreeNode(int _data)
        {
            this.Data = _data;
            this.Left = null;
            this.Right = null;
            this.NextRight = null;
        }
    }

    public class BinaryTreeTest
    {
        public Tree CreateTree()
        {
            var tree = new Tree();
            tree.Root = new TreeNode(1);
            tree.Root.Left = new TreeNode(2);
            tree.Root.Right = new TreeNode(3);
            
            tree.Root.Left.Left = new TreeNode(4);
            tree.Root.Left.Right = new TreeNode(5);
            tree.Root.Right.Left = new TreeNode(6);
            tree.Root.Right.Right = new TreeNode(7);

            return tree;
        }

        public void InorderTraversal(TreeNode node)
        {
            if (node != null)
            {
                InorderTraversal(node.Left);
                VisitNode(node);
                InorderTraversal(node.Right);
            }
        }

        public void LevelTraversal(TreeNode node)
        {
            if (node == null)
                return;
            else
            {
                int height = GetHeight(node);
                if (height == 0)
                    return;
                for (int i = 1; i <= height; i++)
                {
                    PrintLevelTraversal(node, i);
                    Console.WriteLine("");
                }
            }
        }

        public void PrintLevelTraversal(TreeNode node, int level)
        {
            if (node == null)
                return;
            if (level == 1)
            {
                Console.Write(node.Data + " ");
            }
            else
            {
                PrintLevelTraversal(node.Left, level - 1);
                PrintLevelTraversal(node.Right, level - 1);
            }
        }

        public void PrintZigZagTraversal(TreeNode rootNode)
        {
            if (rootNode == null)
                return;

            var currentLevel = new Stack<TreeNode>();
            var nextLevel = new Stack<TreeNode>();
            // push the root  
            currentLevel.Push(rootNode);
            bool leftToRight = true;

            // check if stack is empty  
            while (currentLevel.Count > 0)
            {

                // pop out of stack  
                TreeNode node = currentLevel.Pop();

                // print the data in it  
                Console.Write(node.Data + " ");

                // store data according to current  
                // order.  
                if (leftToRight)
                {
                    if (node.Left != null)
                    {
                        nextLevel.Push(node.Left);
                    }

                    if (node.Right != null)
                    {
                        nextLevel.Push(node.Right);
                    }
                }
                else
                {
                    if (node.Right != null)
                    {
                        nextLevel.Push(node.Right);
                    }

                    if (node.Left != null)
                    {
                        nextLevel.Push(node.Left);
                    }
                }

                if (currentLevel.Count == 0)
                {
                    leftToRight = !leftToRight;
                    Stack<TreeNode> temp = currentLevel;
                    currentLevel = nextLevel;
                    nextLevel = temp;
                }
            }

        }

        public int GetHeight(TreeNode node)
        {
            if (node == null)
                return 0;
            else
            {
                int lHeight = GetHeight(node.Left);
                int rHeight = GetHeight(node.Right);

                if (lHeight > rHeight)
                    return (lHeight + 1);
                else
                    return (rHeight + 1);
            }
        }
        public void VisitNode(TreeNode node)
        {
            Console.WriteLine(node.Data);
        }


        public void ConnectNode(TreeNode root)
        {
            // initialize queue to hold nodes at same level  
            Queue<TreeNode> q = new Queue<TreeNode>();

            q.Enqueue(root); // adding nodes to tehe queue  

            TreeNode temp = null; // initializing prev to null  
            while (q.Count > 0)
            {
                int n = q.Count;
                for (int i = 0; i < n; i++)
                {
                    TreeNode prev = temp;
                    temp = q.Dequeue();

                    // i > 0 because when i is 0 prev points  
                    // the last node of previous level,  
                    // so we skip it  
                    if (i > 0)
                        prev.NextRight = temp;

                    if (temp.Left != null)
                        q.Enqueue(temp.Left);

                    if (temp.Right != null)
                        q.Enqueue(temp.Right);
                }

                // pointing last node of the nth level to null  
                temp.NextRight = null;
            }
        }
    }
}

