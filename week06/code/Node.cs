using System.Diagnostics;

public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
            return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2

        if (value == Data)
        {
            return true;
        }
        else if (Left is not null && value < Data)
        {
            return Left.Contains(value);
        }
        else if (Right is not null && value > Data)
        {
            return Right.Contains(value);
        }
            
        return false;
    }

    public int GetHeight()
    {
        // TODO Start Problem 4

        // heaight of tree = 1 + bigger subtree

        if (Left is null && Right is null)
        {
            return 1;
        }

        if (Left is not null && Right is not null)
        {
            int height = Right!.GetHeight() > Left!.GetHeight() ? Right.GetHeight() : Left.GetHeight();
            return 1 + height;
        }

        if (Left is not null)
        {
            return 1 + Left.GetHeight();
        }

        if (Right is not null)
        {
            return 1 + Right.GetHeight();
        }
        
        return 0;
    }
}