using System;

namespace BinaryTreeDepth
{
    
	public class Node
	{
		public int data;
		public Node left, right;

		public Node(int item)
		{
			data = item;
			left = right = null;
		}
	}

	public class BinaryTree
	{
		Node root;
		int maxDepth(Node node)
		{
			if (node == null)
				return 0;
			else
			{				
				int lDepth = maxDepth(node.left);
				int rDepth = maxDepth(node.right);

				/* use the larger one */
				if (lDepth > rDepth)
					return (lDepth + 1);
				else
					return (rDepth + 1);
			}
		}

		

		
		public static void Main(String[] args)
		{
			BinaryTree tree = new BinaryTree();

            tree.root = new Node(9);
            tree.root.left = new Node(5);
            tree.root.right = new Node(12);
            tree.root.left.left = new Node(1);
            tree.root.left.right = new Node(7);
			tree.root.right.left = new Node(10);
			tree.root.left.left.right = new Node(4);			
			

			Console.WriteLine("Thellsia e pemes eshte : " +
										tree.maxDepth(tree.root));

		}
	}
}
