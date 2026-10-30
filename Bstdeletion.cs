using System;
using System.Collections.Generic;

public class Node
{
    public int Data;
    public Node Left;
    public Node Right;

    public Node(int value)
    {
        Data = value;
        Left = null;
        Right = null;
    }
}

public class BinarySearchTree
{
    public Node Root;

    public void Insert(int data) => Root = InsertRec(Root, data);

    private Node InsertRec(Node root, int data)
    {
        if (root == null) return new Node(data);
        if (data < root.Data) root.Left = InsertRec(root.Left, data);
        else if (data > root.Data) root.Right = InsertRec(root.Right, data);
        return root;
    }

    public bool Search(int key) => SearchRec(Root, key);

    private bool SearchRec(Node root, int key)
    {
        if (root == null) return false;
        if (root.Data == key) return true;
        return key < root.Data ? SearchRec(root.Left, key) : SearchRec(root.Right, key);
    }

    public void Delete(int key) => Root = DeleteNode(Root, key);

    public Node DeleteNode(Node root, int key)
    {
        if (root == null) return root;
        if (key < root.Data) root.Left = DeleteNode(root.Left, key);
        else if (key > root.Data) root.Right = DeleteNode(root.Right, key);
        else
        {
            if (root.Left == null) return root.Right;
            if (root.Right == null) return root.Left;
            root.Data = MinValue(root.Right);
            root.Right = DeleteNode(root.Right, root.Data);
        }
        return root;
    }

    private int MinValue(Node root)
    {
        int minv = root.Data;
        while (root.Left != null)
        {
            minv = root.Left.Data;
            root = root.Left;
        }
        return minv;
    }
}

public class TreeTraversals
{
    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    public void LevelOrder(Node root)
    {
        if (root == null) return;
        Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);
        while (queue.Count > 0)
        {
            Node current = queue.Dequeue();
            Console.Write(current.Data + " ");
            if (current.Left != null) queue.Enqueue(current.Left);
            if (current.Right != null) queue.Enqueue(current.Right);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree bst = new BinarySearchTree();
        TreeTraversals t = new TreeTraversals();

        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);

        t.InOrder(bst.Root);
    }
}