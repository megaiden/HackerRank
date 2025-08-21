// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");

var newNode = new SinglyLinkedListNode
{
    data = 16,
    next = new SinglyLinkedListNode { data = 13, 
        next = new SinglyLinkedListNode { data = 7, next = null } 
    }

};

var result = Result.agregamemiputada(newNode, 1, 2);

Console.WriteLine(result);

public class SinglyLinkedListNode {
    public int data;
    public  SinglyLinkedListNode next;

    public SinglyLinkedListNode(int data)
    {
        this.data = data;
    }
    public SinglyLinkedListNode()
    {
    }
}
public class Result
{

    public static SinglyLinkedListNode agregamemiputada(SinglyLinkedListNode head, int data, int position)
    {
        SinglyLinkedListNode newNode = new SinglyLinkedListNode(data);

        if (position == 0)
        {
            newNode.next = head; // connecting the previous head to NEXT of new node
            head = newNode; // the new HEAD is newNode
            return head;
        }

        SinglyLinkedListNode current = head;
        int currentPosition = 1;
        while (current != null)
        {
            if (position == currentPosition)
            {
                newNode.next = current.next;
                current.next = newNode;
            }

            current = current.next;
            currentPosition++;
        }


        return head;
    }
}