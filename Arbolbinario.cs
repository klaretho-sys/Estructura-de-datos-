using System;

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

class Program
{
    static void Main(string[] args)
    {
        BinarySearchTree sistemaEmpleados = new BinarySearchTree();

        Console.WriteLine("=======Registros de Personal ==========");

  
       int[] idsNuevos = { 60, 50, 150, 25, 75, 125, 175, 17, 23, 88, 14 };

        foreach (int id in idsNuevos)
        {
            sistemaEmpleados.Insert(id);
            Console.WriteLine($"Registrado con ID: {id}");
        }

        Console.WriteLine("\n--- CONSULTAS EN EL SISTEMA ---");
        int idBuscado1 = 75;
        int idBuscado2 = 999;

        VerificarEmpleado(sistemaEmpleados, idBuscado1);
        VerificarEmpleado(sistemaEmpleados, idBuscado2);
    }

    static void VerificarEmpleado(BinarySearchTree bst, int id)
    {
        bool encontrado = bst.Search(id);
        if (encontrado)
        {
            Console.WriteLine($"La persona con ID {id} SÍ labora en la empresa.");
        }
        else
        {
            Console.WriteLine($"La persona con ID {id} NO se encuentra registrado.");
        }
    }
}