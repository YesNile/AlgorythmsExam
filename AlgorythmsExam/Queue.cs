using System.Collections;

namespace AlgorythmsExam;

public class NodeQueue<TValue>
{
    public NodeQueue(TValue value)
    {
        Value = value;
    }
    public NodeQueue<TValue> Next;
    public NodeQueue<TValue> Previous;
    public TValue Value;
}
public class MyLinkedListQueue<TValue>
{
    public NodeQueue<TValue> Head;
    public NodeQueue<TValue> Tail;
    public int Count { get; private set; } = 0;

    public bool IsEmpty()
    {
        return Head == null && Tail == null;
    }
    public void Add(TValue value)
    {
        var node = new NodeQueue<TValue>(value);
        var temp = Head;
        node.Next = temp;
        Head = node;
        if (Count == 0)
            Tail = Head;
        else
            temp.Previous = node;
        Count++;
    }

    public void AddLast(TValue value)
    {
        var node = new NodeQueue<TValue>(value);
        if (Head == null)
        {
            Head = node;
        }
        else
        {
            Tail.Next = node;
            node.Previous = Tail;
        }
        Tail = node;
        Count++;
    }

    public TValue RemoveFirst()
    {
        var value = Head.Value;
        var temp = Head.Next;
        if (temp != null)
        {
            temp.Previous = null;
        }
        Head = temp;
        Count = Count ==0?0:Count--;
        return value;
    }
    public TValue RemoveLast()
    {
        var value = Tail.Value;
        var temp = Tail.Previous;
        if (temp != null)
        {
            temp.Next = null;
        }
        Tail = temp;
        Count = Count ==0?0:Count--;
        return value;
    }
}
public class Queue<TValue>
{
    
    private MyLinkedListQueue<TValue> list = new MyLinkedListQueue<TValue>();
    public int Count { get; private set; } = 0;
    public void Enqueue(TValue value)
    {
        Count++;
        list.Add(value);
    }

    public TValue Dequeue()
    {
        if (Count == 0)
        {
            throw new Exception("Queue is clear");
        }
        else
        {
            Count--;
            return list.RemoveLast();
        }
    }

    public TValue Peek()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return list.Tail.Value;
    }

    public bool IsEmpty()
    {
        return list.IsEmpty();
    }
}