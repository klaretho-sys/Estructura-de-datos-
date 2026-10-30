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

    public void Insert(int data)
    {
        Root = InsertRec(Root, data);
    }

    private Node InsertRec(Node root, int data)
    {
        if (root == null)
            return new Node(data);

        if (data < root.Data)
            root.Left = InsertRec(root.Left, data);
        else if (data > root.Data)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    public bool Search(int key)
    {
        return SearchRec(Root, key);
    }

    private bool SearchRec(Node root, int key)
    {
        if (root == null) return false;
        if (root.Data == key) return true;

        return key < root.Data
            ? SearchRec(root.Left, key)
            : SearchRec(root.Right, key);
    }
}

public class TreeTraversals
{
    public void PreOrder(Node node)
    {
        if (node == null) return;
        Console.Write(node.Data + " ");
        PreOrder(node.Left);
        PreOrder(node.Right);
    }

    public void InOrder(Node node)
    {
        if (node == null) return;
        InOrder(node.Left);
        Console.Write(node.Data + " ");
        InOrder(node.Right);
    }

    public void PostOrder(Node node)
    {
        if (node == null) return;
        PostOrder(node.Left);
        PostOrder(node.Right);
        Console.Write(node.Data + " ");
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
        TreeTraversals traversals = new TreeTraversals();

        bst.Insert(50);
        bst.Insert(30);
        bst.Insert(70);

        Console.WriteLine("¿Existe el 30?: " + bst.Search(30)); // True
        Console.Write("Inorden: ");
        traversals.InOrder(bst.Root);
    }
}