using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class TreeNode
    {
      public int val;
      public TreeNode left;
      public TreeNode right;
      public TreeNode(int x)
        {
            val = x;
            left = null;
            right = null;
        }

        public void InsertData(ref TreeNode node, int d)
        {
            if(node==null)
            {
                node = new TreeNode(d);
            }
            else if(d > node.val)
            {
                InsertData(ref node.right, d);
            }
            else if(d < node.val )
            {
                InsertData(ref node.left, d);
            }
        }

  }

    public class BinaryTree
    {
        public TreeNode root;
        public bool IsEmpty()
        {
            return root == null;
        }

        public void Insert(int d)
        {
            if(IsEmpty())
            {
                root = new TreeNode(d);
            }
            else
            {
                root.InsertData(ref root, d);
            }
        }

        public void InOrderTraversal(TreeNode node)
        {
            if(node != null)
            {
                InOrderTraversal(node.left);
                Visit(node);
                InOrderTraversal(node.right);
            }
        }

        public void PreOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                Visit(node);
                PreOrderTraversal(node.left);
                PreOrderTraversal(node.right);
            }
        }

        public void PostOrderTraversal(TreeNode node)
        {
            if (node != null)
            {
                PostOrderTraversal(node.left);
                PostOrderTraversal(node.right);
                Visit(node);
            }
        }
        private void Visit(TreeNode node)
        {
            Console.WriteLine(node.val);
        }
    }


}
